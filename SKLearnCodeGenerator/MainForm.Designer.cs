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
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.targetVariableName = new System.Windows.Forms.TextBox();
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
			this.groupBox1.Location = new System.Drawing.Point(10, 11);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Size = new System.Drawing.Size(374, 66);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Input Data";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(4, 44);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 13);
			this.label7.TabIndex = 2;
			this.label7.Text = "Target Var";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 22);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Training Data";
			// 
			// targetVariableName
			// 
			this.targetVariableName.Location = new System.Drawing.Point(77, 41);
			this.targetVariableName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.targetVariableName.Name = "targetVariableName";
			this.targetVariableName.Size = new System.Drawing.Size(128, 20);
			this.targetVariableName.TabIndex = 0;
			// 
			// openTrainData
			// 
			this.openTrainData.Location = new System.Drawing.Point(304, 15);
			this.openTrainData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.openTrainData.Name = "openTrainData";
			this.openTrainData.Size = new System.Drawing.Size(65, 27);
			this.openTrainData.TabIndex = 1;
			this.openTrainData.Text = "Browse";
			this.openTrainData.UseVisualStyleBackColor = true;
			this.openTrainData.Click += new System.EventHandler(this.openTrainData_Click);
			// 
			// inputFile
			// 
			this.inputFile.Location = new System.Drawing.Point(77, 20);
			this.inputFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.inputFile.Name = "inputFile";
			this.inputFile.ReadOnly = true;
			this.inputFile.Size = new System.Drawing.Size(222, 20);
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
			this.groupBox2.Location = new System.Drawing.Point(10, 155);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox2.Size = new System.Drawing.Size(374, 93);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Model";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(4, 67);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Parameters";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(4, 44);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Algorithm";
			// 
			// modelParams
			// 
			this.modelParams.Location = new System.Drawing.Point(77, 67);
			this.modelParams.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.modelParams.Name = "modelParams";
			this.modelParams.Size = new System.Drawing.Size(222, 20);
			this.modelParams.TabIndex = 0;
			// 
			// algorithmName
			// 
			this.algorithmName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.algorithmName.FormattingEnabled = true;
			this.algorithmName.Location = new System.Drawing.Point(77, 41);
			this.algorithmName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.algorithmName.Name = "algorithmName";
			this.algorithmName.Size = new System.Drawing.Size(222, 21);
			this.algorithmName.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 20);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Type";
			// 
			// modelType
			// 
			this.modelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.modelType.FormattingEnabled = true;
			this.modelType.Location = new System.Drawing.Point(77, 17);
			this.modelType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.modelType.Name = "modelType";
			this.modelType.Size = new System.Drawing.Size(128, 21);
			this.modelType.TabIndex = 0;
			this.modelType.SelectedIndexChanged += new System.EventHandler(this.modelType_SelectedIndexChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.openTestData);
			this.groupBox3.Controls.Add(this.testData);
			this.groupBox3.Location = new System.Drawing.Point(10, 254);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox3.Size = new System.Drawing.Size(374, 66);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Predict";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(4, 28);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Test Data";
			// 
			// openTestData
			// 
			this.openTestData.Location = new System.Drawing.Point(304, 22);
			this.openTestData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.openTestData.Name = "openTestData";
			this.openTestData.Size = new System.Drawing.Size(65, 27);
			this.openTestData.TabIndex = 1;
			this.openTestData.Text = "Browse";
			this.openTestData.UseVisualStyleBackColor = true;
			this.openTestData.Click += new System.EventHandler(this.openTestData_Click);
			// 
			// testData
			// 
			this.testData.Location = new System.Drawing.Point(77, 26);
			this.testData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.testData.Name = "testData";
			this.testData.ReadOnly = true;
			this.testData.Size = new System.Drawing.Size(222, 20);
			this.testData.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.ModelStats);
			this.groupBox4.Location = new System.Drawing.Point(394, 11);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox4.Size = new System.Drawing.Size(196, 347);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Model Statistics";
			// 
			// ModelStats
			// 
			this.ModelStats.Controls.Add(this.CurrentModel);
			this.ModelStats.Controls.Add(this.PrevModel);
			this.ModelStats.Location = new System.Drawing.Point(5, 13);
			this.ModelStats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ModelStats.Name = "ModelStats";
			this.ModelStats.SelectedIndex = 0;
			this.ModelStats.Size = new System.Drawing.Size(191, 334);
			this.ModelStats.TabIndex = 0;
			// 
			// CurrentModel
			// 
			this.CurrentModel.BackColor = System.Drawing.Color.Transparent;
			this.CurrentModel.Location = new System.Drawing.Point(4, 22);
			this.CurrentModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.CurrentModel.Name = "CurrentModel";
			this.CurrentModel.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.CurrentModel.Size = new System.Drawing.Size(183, 308);
			this.CurrentModel.TabIndex = 0;
			this.CurrentModel.Text = "Current";
			// 
			// PrevModel
			// 
			this.PrevModel.BackColor = System.Drawing.Color.Transparent;
			this.PrevModel.Location = new System.Drawing.Point(4, 22);
			this.PrevModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.PrevModel.Name = "PrevModel";
			this.PrevModel.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.PrevModel.Size = new System.Drawing.Size(183, 308);
			this.PrevModel.TabIndex = 1;
			this.PrevModel.Text = "Previous";
			// 
			// trainPredictBtn
			// 
			this.trainPredictBtn.Location = new System.Drawing.Point(122, 324);
			this.trainPredictBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.trainPredictBtn.Name = "trainPredictBtn";
			this.trainPredictBtn.Size = new System.Drawing.Size(142, 31);
			this.trainPredictBtn.TabIndex = 3;
			this.trainPredictBtn.Text = "Start Training";
			this.trainPredictBtn.UseVisualStyleBackColor = true;
			this.trainPredictBtn.Click += new System.EventHandler(this.trainPredictBtn_Click);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.dataPreProcessScript);
			this.groupBox5.Controls.Add(this.label6);
			this.groupBox5.Location = new System.Drawing.Point(10, 83);
			this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox5.Size = new System.Drawing.Size(374, 67);
			this.groupBox5.TabIndex = 4;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Data PreProcessing";
			// 
			// dataPreProcessScript
			// 
			this.dataPreProcessScript.Location = new System.Drawing.Point(80, 19);
			this.dataPreProcessScript.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dataPreProcessScript.Name = "dataPreProcessScript";
			this.dataPreProcessScript.Size = new System.Drawing.Size(290, 45);
			this.dataPreProcessScript.TabIndex = 0;
			this.dataPreProcessScript.Text = "";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(4, 32);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(34, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Script";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 366);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.trainPredictBtn);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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

