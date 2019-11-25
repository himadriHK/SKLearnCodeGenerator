using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
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
			Dictionary<string,dynamic> algoSettings = skLearnAlgoDoc.SelectSingleNode("root").SelectSingleNode("AlgorithmTypes")
				.ChildNodes.Cast<XmlNode>()
				.ToDictionary(x => x.Attributes.GetNamedItem("name").Value, 
				x => { dynamic obj = new List<ExpandoObject>(); return obj; });

			var rootNode = skLearnAlgoDoc.SelectSingleNode("root");

			foreach (string key in algoSettings.Keys)
			{
				var sectionNode = rootNode.SelectSingleNode(key);
				if(sectionNode != null)
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
		}
	}
}
