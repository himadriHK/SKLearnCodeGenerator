using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SKLearnCodeGenerator
{
	public partial class MainForm : Form
	{
		XmlDocument skLearnAlgoDoc;
		Dictionary<string, dynamic> algoSettings;
		public MainForm()
		{
			InitializeComponent();
		}

		private void openTrainData_Click(object sender, EventArgs e)
		{
			fileDialog.ShowDialog();
			inputFile.Text = fileDialog.FileName;
		}

		private void openTestData_Click(object sender, EventArgs e)
		{
			fileDialog.ShowDialog();
			testData.Text = fileDialog.FileName;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			skLearnAlgoDoc = new XmlDocument();
			skLearnAlgoDoc.Load("SkLearnAlgos.xml");
			algoSettings = skLearnAlgoDoc.SelectSingleNode("root").SelectSingleNode("AlgorithmTypes")
				.ChildNodes.Cast<XmlNode>()
				.ToDictionary(x => x.Attributes.GetNamedItem("name").Value,
				x => { dynamic obj = new List<ExpandoObject>(); return obj; });

			var rootNode = skLearnAlgoDoc.SelectSingleNode("root");

			foreach (string key in algoSettings.Keys)
			{
				var sectionNode = rootNode.SelectSingleNode(key);
				if (sectionNode != null)
					foreach (XmlNode node in sectionNode.ChildNodes)
					{
						dynamic nodeData = new ExpandoObject();
						nodeData.Name = node.Name;
						nodeData.Import = node.Attributes["import"].Value;
						nodeData.Class = node.Attributes["class"].Value;
						nodeData.DefaultParams = node.Attributes["default_params"].Value;
						algoSettings[key].Add(nodeData);
					}
			}

			modelType.Items.AddRange(algoSettings.Keys.ToArray());
		}

		private void modelType_SelectedIndexChanged(object sender, EventArgs e)
		{
			algorithmName.Items.Clear();
			foreach (var algo in algoSettings[modelType.SelectedItem.ToString()])
			{
				algorithmName.Items.Add(algo.Name);
			}

		}

		private void trainPredictBtn_Click(object sender, EventArgs e)
		{
			string common_imports = @" 
#import required libraries
import pandas as pd
import numpy as np
";
			string algo_class_import = $@"
#import required class for the algorithm
{algoSettings[modelType.SelectedItem.ToString()][algorithmName.SelectedIndex].Import}";

			string load_data = $@"
training_data = pd.read_csv(""{inputFile.Text}"")
";

			string data_preprocessing = dataPreProcessScript.Text;

			string get_x_train_y_train = $@"
x_train = training_data[training_data.columns[training_data.columns!='{targetVariableName.Text}'] ]
y_train = training_data['{targetVariableName.Text}']
";
			string train_model = $@"
model = {algoSettings[modelType.SelectedItem.ToString()][algorithmName.SelectedIndex].Class}({modelParams.Text})
model.fit(x_train,y_train)
print(model.score(x_train,y_train))
";
            string dirPath = Path.GetDirectoryName(inputFile.Text);
            using (StreamWriter sw = new StreamWriter(File.Create(dirPath + "\\pythonscript.py"),Encoding.ASCII))
            {
                sw.Write(common_imports);
                sw.Write(algo_class_import);
                sw.Write(load_data);
                sw.Write(data_preprocessing);
                sw.Write(get_x_train_y_train);
                sw.Write(train_model);
            }

            MessageBox.Show(executeInPython('"'+dirPath + "\\pythonscript.py"+'"'));
		}

		private string executeInPython(string pythonScriptPath)
		{
			try
			{
				using (Process myProcess = new Process())
				{
					myProcess.StartInfo.UseShellExecute = false;
					myProcess.StartInfo.FileName = @"C:\Program Files (x86)\Microsoft Visual Studio\Shared\Python37_64\python.exe";
					myProcess.StartInfo.CreateNoWindow = true;
					myProcess.StartInfo.RedirectStandardOutput = true;
					myProcess.StartInfo.RedirectStandardError = true;
					myProcess.StartInfo.Arguments = pythonScriptPath;
					myProcess.Start();
                    
                    myProcess.WaitForExit();
                    string result1 = myProcess.StandardError.ReadToEnd();
                    string result2 = myProcess.StandardOutput.ReadToEnd();
                    myProcess.StandardError.ReadToEnd();
                    return result1 +"\n"+result2;
				}
			}
			catch (Exception e)
			{
				return e.Message;
			}
		}
	}
}
