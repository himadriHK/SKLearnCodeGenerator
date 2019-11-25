namespace SKLearnCodeGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openTrainData = new System.Windows.Forms.Button();
            this.inputFile = new System.Windows.Forms.TextBox();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.modelParams = new System.Windows.Forms.TextBox();
            this.algorithmName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.modelType = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openTestData = new System.Windows.Forms.Button();
            this.testData = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ModelStats = new System.Windows.Forms.TabControl();
            this.CurrentModel = new System.Windows.Forms.TabPage();
            this.PrevModel = new System.Windows.Forms.TabPage();
            this.trainPredictBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataPreProcessScript = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.targetVariableName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.ModelStats.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.targetVariableName);
            this.groupBox1.Controls.Add(this.openTrainData);
            this.groupBox1.Controls.Add(this.inputFile);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Training Data";
            // 
            // openTrainData
            // 
            this.openTrainData.Location = new System.Drawing.Point(406, 19);
            this.openTrainData.Name = "openTrainData";
            this.openTrainData.Size = new System.Drawing.Size(87, 33);
            this.openTrainData.TabIndex = 1;
            this.openTrainData.Text = "Browse";
            this.openTrainData.UseVisualStyleBackColor = true;
            this.openTrainData.Click += new System.EventHandler(this.openTrainData_Click);
            // 
            // inputFile
            // 
            this.inputFile.Location = new System.Drawing.Point(103, 24);
            this.inputFile.Name = "inputFile";
            this.inputFile.ReadOnly = true;
            this.inputFile.Size = new System.Drawing.Size(294, 22);
            this.inputFile.TabIndex = 0;
            // 
            // fileDialog
            // 
            this.fileDialog.Filter = "CSV files|*.csv";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.modelParams);
            this.groupBox2.Controls.Add(this.algorithmName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.modelType);
            this.groupBox2.Location = new System.Drawing.Point(14, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Parameters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Algorithm";
            // 
            // modelParams
            // 
            this.modelParams.Location = new System.Drawing.Point(103, 82);
            this.modelParams.Name = "modelParams";
            this.modelParams.Size = new System.Drawing.Size(294, 22);
            this.modelParams.TabIndex = 0;
            // 
            // algorithmName
            // 
            this.algorithmName.FormattingEnabled = true;
            this.algorithmName.Location = new System.Drawing.Point(103, 51);
            this.algorithmName.Name = "algorithmName";
            this.algorithmName.Size = new System.Drawing.Size(294, 24);
            this.algorithmName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // modelType
            // 
            this.modelType.FormattingEnabled = true;
            this.modelType.Location = new System.Drawing.Point(103, 21);
            this.modelType.Name = "modelType";
            this.modelType.Size = new System.Drawing.Size(169, 24);
            this.modelType.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.openTestData);
            this.groupBox3.Controls.Add(this.testData);
            this.groupBox3.Location = new System.Drawing.Point(14, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(499, 81);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Predict";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Test Data";
            // 
            // openTestData
            // 
            this.openTestData.Location = new System.Drawing.Point(406, 27);
            this.openTestData.Name = "openTestData";
            this.openTestData.Size = new System.Drawing.Size(87, 33);
            this.openTestData.TabIndex = 1;
            this.openTestData.Text = "Browse";
            this.openTestData.UseVisualStyleBackColor = true;
            this.openTestData.Click += new System.EventHandler(this.openTestData_Click);
            // 
            // testData
            // 
            this.testData.Location = new System.Drawing.Point(103, 32);
            this.testData.Name = "testData";
            this.testData.ReadOnly = true;
            this.testData.Size = new System.Drawing.Size(294, 22);
            this.testData.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ModelStats);
            this.groupBox4.Location = new System.Drawing.Point(526, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 427);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Model Statistics";
            // 
            // ModelStats
            // 
            this.ModelStats.Controls.Add(this.CurrentModel);
            this.ModelStats.Controls.Add(this.PrevModel);
            this.ModelStats.Location = new System.Drawing.Point(7, 16);
            this.ModelStats.Name = "ModelStats";
            this.ModelStats.SelectedIndex = 0;
            this.ModelStats.Size = new System.Drawing.Size(255, 411);
            this.ModelStats.TabIndex = 0;
            // 
            // CurrentModel
            // 
            this.CurrentModel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentModel.Location = new System.Drawing.Point(4, 25);
            this.CurrentModel.Name = "CurrentModel";
            this.CurrentModel.Padding = new System.Windows.Forms.Padding(3);
            this.CurrentModel.Size = new System.Drawing.Size(247, 382);
            this.CurrentModel.TabIndex = 0;
            this.CurrentModel.Text = "Current";
            // 
            // PrevModel
            // 
            this.PrevModel.BackColor = System.Drawing.Color.Transparent;
            this.PrevModel.Location = new System.Drawing.Point(4, 25);
            this.PrevModel.Name = "PrevModel";
            this.PrevModel.Padding = new System.Windows.Forms.Padding(3);
            this.PrevModel.Size = new System.Drawing.Size(247, 382);
            this.PrevModel.TabIndex = 1;
            this.PrevModel.Text = "Previous";
            // 
            // trainPredictBtn
            // 
            this.trainPredictBtn.Location = new System.Drawing.Point(162, 399);
            this.trainPredictBtn.Name = "trainPredictBtn";
            this.trainPredictBtn.Size = new System.Drawing.Size(189, 38);
            this.trainPredictBtn.TabIndex = 3;
            this.trainPredictBtn.Text = "Start Training";
            this.trainPredictBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataPreProcessScript);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(14, 102);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(499, 83);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Data PreProcessing";
            // 
            // dataPreProcessScript
            // 
            this.dataPreProcessScript.Location = new System.Drawing.Point(106, 23);
            this.dataPreProcessScript.Name = "dataPreProcessScript";
            this.dataPreProcessScript.Size = new System.Drawing.Size(386, 54);
            this.dataPreProcessScript.TabIndex = 0;
            this.dataPreProcessScript.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Script";
            // 
            // targetVariableName
            // 
            this.targetVariableName.Location = new System.Drawing.Point(103, 51);
            this.targetVariableName.Name = "targetVariableName";
            this.targetVariableName.Size = new System.Drawing.Size(169, 22);
            this.targetVariableName.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Target Var";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.trainPredictBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SKLearn Code Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ModelStats.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openTrainData;
        private System.Windows.Forms.TextBox inputFile;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox modelParams;
        private System.Windows.Forms.ComboBox algorithmName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox modelType;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button openTestData;
        private System.Windows.Forms.TextBox testData;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabControl ModelStats;
        private System.Windows.Forms.TabPage CurrentModel;
        private System.Windows.Forms.TabPage PrevModel;
        private System.Windows.Forms.Button trainPredictBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox dataPreProcessScript;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox targetVariableName;
    }
}

