using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            skLearnAlgoDoc.PreserveWhitespace = true;
            skLearnAlgoDoc.Load("SkLearnAlgos.xml");
            dynamic algos = skLearnAlgoDoc.SelectNodes("root")[0].SelectNodes("Algorithms");
        }
    }
}
