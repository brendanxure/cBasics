namespace RegistrationApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            fileToolStripMenuItem2 = new ToolStripMenuItem();
            registerToolStripMenuItem = new ToolStripMenuItem();
            recordToolStripMenuItem = new ToolStripMenuItem();
            updateRecordToolStripMenuItem = new ToolStripMenuItem();
            deleteRecordToolStripMenuItem = new ToolStripMenuItem();
            deleteAllRecordsToolStripMenuItem = new ToolStripMenuItem();
            loadRecordsToServerToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            readHelpToolStripMenuItem = new ToolStripMenuItem();
            technicalSupportsToolStripMenuItem = new ToolStripMenuItem();
            aboutDCRegistrationAppToolStripMenuItem = new ToolStripMenuItem();
            groupBoxInformation = new GroupBox();
            comboBoxSchoolGrade = new ComboBox();
            labelSchoolGrade = new Label();
            comboBoxTestScore = new ComboBox();
            labelTestScore = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxSin = new TextBox();
            labelSin = new Label();
            textBoxLastName = new TextBox();
            labelLastName = new Label();
            textBoxFirstName = new TextBox();
            labelFirstName = new Label();
            buttonCheck = new Button();
            groupBoxPrograms = new GroupBox();
            labelCostValue = new Label();
            labelCost = new Label();
            labelPeriodValue = new Label();
            labelPeriod = new Label();
            comboBoxPrograms = new ComboBox();
            labelPrograms = new Label();
            comboBoxLocation = new ComboBox();
            labelLocation = new Label();
            buttonRegister = new Button();
            dataGridViewRecord = new DataGridView();
            ColumnFirstName = new DataGridViewTextBoxColumn();
            ColumnLastName = new DataGridViewTextBoxColumn();
            ColumnSin = new DataGridViewTextBoxColumn();
            ColumnEmail = new DataGridViewTextBoxColumn();
            ColumnSchoolGrade = new DataGridViewTextBoxColumn();
            ColumnTestScore = new DataGridViewTextBoxColumn();
            ColumnLocation = new DataGridViewTextBoxColumn();
            ColumnProgram = new DataGridViewTextBoxColumn();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonRemoveAll = new Button();
            buttonLoad = new Button();
            labelSinSearch = new Label();
            comboBoxSinSearch = new ComboBox();
            buttonExit = new Button();
            menuStrip1.SuspendLayout();
            groupBoxInformation.SuspendLayout();
            groupBoxPrograms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecord).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile, fileToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1115, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { fileToolStripMenuItem2, registerToolStripMenuItem, recordToolStripMenuItem, deleteAllRecordsToolStripMenuItem, loadRecordsToServerToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(46, 24);
            menuFile.Text = "File";
            // 
            // fileToolStripMenuItem2
            // 
            fileToolStripMenuItem2.Name = "fileToolStripMenuItem2";
            fileToolStripMenuItem2.Size = new Size(245, 26);
            fileToolStripMenuItem2.Text = "File";
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(245, 26);
            registerToolStripMenuItem.Text = "Register";
            registerToolStripMenuItem.Click += ButtonRegisterClick;
            // 
            // recordToolStripMenuItem
            // 
            recordToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { updateRecordToolStripMenuItem, deleteRecordToolStripMenuItem });
            recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            recordToolStripMenuItem.Size = new Size(245, 26);
            recordToolStripMenuItem.Text = "Record";
            // 
            // updateRecordToolStripMenuItem
            // 
            updateRecordToolStripMenuItem.Name = "updateRecordToolStripMenuItem";
            updateRecordToolStripMenuItem.Size = new Size(192, 26);
            updateRecordToolStripMenuItem.Text = "Update Record";
            // 
            // deleteRecordToolStripMenuItem
            // 
            deleteRecordToolStripMenuItem.Name = "deleteRecordToolStripMenuItem";
            deleteRecordToolStripMenuItem.Size = new Size(192, 26);
            deleteRecordToolStripMenuItem.Text = "Delete Record";
            // 
            // deleteAllRecordsToolStripMenuItem
            // 
            deleteAllRecordsToolStripMenuItem.Name = "deleteAllRecordsToolStripMenuItem";
            deleteAllRecordsToolStripMenuItem.Size = new Size(245, 26);
            deleteAllRecordsToolStripMenuItem.Text = "Delete All Records";
            // 
            // loadRecordsToServerToolStripMenuItem
            // 
            loadRecordsToServerToolStripMenuItem.Name = "loadRecordsToServerToolStripMenuItem";
            loadRecordsToServerToolStripMenuItem.Size = new Size(245, 26);
            loadRecordsToServerToolStripMenuItem.Text = "Load Records to Server";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(242, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(245, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitClick;
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { readHelpToolStripMenuItem, technicalSupportsToolStripMenuItem, aboutDCRegistrationAppToolStripMenuItem });
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(55, 24);
            fileToolStripMenuItem1.Text = "Help";
            // 
            // readHelpToolStripMenuItem
            // 
            readHelpToolStripMenuItem.Name = "readHelpToolStripMenuItem";
            readHelpToolStripMenuItem.Size = new Size(275, 26);
            readHelpToolStripMenuItem.Text = "Read Help";
            readHelpToolStripMenuItem.Click += ReadHelpClick;
            // 
            // technicalSupportsToolStripMenuItem
            // 
            technicalSupportsToolStripMenuItem.Name = "technicalSupportsToolStripMenuItem";
            technicalSupportsToolStripMenuItem.Size = new Size(275, 26);
            technicalSupportsToolStripMenuItem.Text = "Technical Supports";
            technicalSupportsToolStripMenuItem.Click += TechnicalSupportsClick;
            // 
            // aboutDCRegistrationAppToolStripMenuItem
            // 
            aboutDCRegistrationAppToolStripMenuItem.Name = "aboutDCRegistrationAppToolStripMenuItem";
            aboutDCRegistrationAppToolStripMenuItem.Size = new Size(275, 26);
            aboutDCRegistrationAppToolStripMenuItem.Text = "About DC-Registration App";
            aboutDCRegistrationAppToolStripMenuItem.Click += AboutDCRegistrationAppClick;
            // 
            // groupBoxInformation
            // 
            groupBoxInformation.Controls.Add(comboBoxSchoolGrade);
            groupBoxInformation.Controls.Add(labelSchoolGrade);
            groupBoxInformation.Controls.Add(comboBoxTestScore);
            groupBoxInformation.Controls.Add(labelTestScore);
            groupBoxInformation.Controls.Add(textBoxEmail);
            groupBoxInformation.Controls.Add(labelEmail);
            groupBoxInformation.Controls.Add(textBoxSin);
            groupBoxInformation.Controls.Add(labelSin);
            groupBoxInformation.Controls.Add(textBoxLastName);
            groupBoxInformation.Controls.Add(labelLastName);
            groupBoxInformation.Controls.Add(textBoxFirstName);
            groupBoxInformation.Controls.Add(labelFirstName);
            groupBoxInformation.Location = new Point(28, 31);
            groupBoxInformation.Name = "groupBoxInformation";
            groupBoxInformation.Size = new Size(1053, 110);
            groupBoxInformation.TabIndex = 1;
            groupBoxInformation.TabStop = false;
            groupBoxInformation.Text = "Student Information";
            // 
            // comboBoxSchoolGrade
            // 
            comboBoxSchoolGrade.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSchoolGrade.FormattingEnabled = true;
            comboBoxSchoolGrade.Items.AddRange(new object[] { "10", "20", "30", "40", "50", "60", "70", "80", "90" });
            comboBoxSchoolGrade.Location = new Point(877, 57);
            comboBoxSchoolGrade.Name = "comboBoxSchoolGrade";
            comboBoxSchoolGrade.Size = new Size(151, 28);
            comboBoxSchoolGrade.TabIndex = 11;
            // 
            // labelSchoolGrade
            // 
            labelSchoolGrade.AutoSize = true;
            labelSchoolGrade.Location = new Point(723, 62);
            labelSchoolGrade.Name = "labelSchoolGrade";
            labelSchoolGrade.Size = new Size(134, 20);
            labelSchoolGrade.TabIndex = 10;
            labelSchoolGrade.Text = "High School &Grade";
            // 
            // comboBoxTestScore
            // 
            comboBoxTestScore.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTestScore.FormattingEnabled = true;
            comboBoxTestScore.Items.AddRange(new object[] { "10", "20", "30", "40", "50", "60", "70", "80", "90" });
            comboBoxTestScore.Location = new Point(877, 23);
            comboBoxTestScore.Name = "comboBoxTestScore";
            comboBoxTestScore.Size = new Size(151, 28);
            comboBoxTestScore.TabIndex = 9;
            // 
            // labelTestScore
            // 
            labelTestScore.AutoSize = true;
            labelTestScore.Location = new Point(708, 29);
            labelTestScore.Name = "labelTestScore";
            labelTestScore.Size = new Size(149, 20);
            labelTestScore.TabIndex = 8;
            labelTestScore.Text = "Admission &Test Score";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(384, 56);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(279, 27);
            textBoxEmail.TabIndex = 7;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(332, 60);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "&Email";
            // 
            // textBoxSin
            // 
            textBoxSin.Location = new Point(384, 22);
            textBoxSin.Name = "textBoxSin";
            textBoxSin.Size = new Size(279, 27);
            textBoxSin.TabIndex = 5;
            // 
            // labelSin
            // 
            labelSin.AutoSize = true;
            labelSin.Location = new Point(346, 26);
            labelSin.Name = "labelSin";
            labelSin.Size = new Size(32, 20);
            labelSin.TabIndex = 4;
            labelSin.Text = "&SIN";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(94, 55);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(125, 27);
            textBoxLastName.TabIndex = 3;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(12, 56);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(79, 20);
            labelLastName.TabIndex = 2;
            labelLastName.Text = "Last &Name";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(94, 22);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(125, 27);
            textBoxFirstName.TabIndex = 1;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(8, 25);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(80, 20);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "&First Name";
            // 
            // buttonCheck
            // 
            buttonCheck.Location = new Point(27, 144);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(94, 29);
            buttonCheck.TabIndex = 12;
            buttonCheck.Text = "&Check";
            buttonCheck.UseVisualStyleBackColor = true;
            buttonCheck.Click += ButtonCheckClick;
            // 
            // groupBoxPrograms
            // 
            groupBoxPrograms.Controls.Add(labelCostValue);
            groupBoxPrograms.Controls.Add(labelCost);
            groupBoxPrograms.Controls.Add(labelPeriodValue);
            groupBoxPrograms.Controls.Add(labelPeriod);
            groupBoxPrograms.Controls.Add(comboBoxPrograms);
            groupBoxPrograms.Controls.Add(labelPrograms);
            groupBoxPrograms.Controls.Add(comboBoxLocation);
            groupBoxPrograms.Controls.Add(labelLocation);
            groupBoxPrograms.Enabled = false;
            groupBoxPrograms.Location = new Point(29, 186);
            groupBoxPrograms.Name = "groupBoxPrograms";
            groupBoxPrograms.Size = new Size(1052, 99);
            groupBoxPrograms.TabIndex = 3;
            groupBoxPrograms.TabStop = false;
            groupBoxPrograms.Text = "Available Programs";
            // 
            // labelCostValue
            // 
            labelCostValue.AutoSize = true;
            labelCostValue.Location = new Point(972, 45);
            labelCostValue.Name = "labelCostValue";
            labelCostValue.Size = new Size(17, 20);
            labelCostValue.TabIndex = 20;
            labelCostValue.Text = "0";
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Location = new Point(952, 23);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(75, 20);
            labelCost.TabIndex = 19;
            labelCost.Text = "Total Cost";
            // 
            // labelPeriodValue
            // 
            labelPeriodValue.AutoSize = true;
            labelPeriodValue.Location = new Point(854, 45);
            labelPeriodValue.Name = "labelPeriodValue";
            labelPeriodValue.Size = new Size(17, 20);
            labelPeriodValue.TabIndex = 18;
            labelPeriodValue.Text = "0";
            // 
            // labelPeriod
            // 
            labelPeriod.AutoSize = true;
            labelPeriod.Location = new Point(834, 23);
            labelPeriod.Name = "labelPeriod";
            labelPeriod.Size = new Size(92, 20);
            labelPeriod.TabIndex = 17;
            labelPeriod.Text = "Study Period";
            // 
            // comboBoxPrograms
            // 
            comboBoxPrograms.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPrograms.FormattingEnabled = true;
            comboBoxPrograms.Location = new Point(516, 37);
            comboBoxPrograms.Name = "comboBoxPrograms";
            comboBoxPrograms.Size = new Size(267, 28);
            comboBoxPrograms.TabIndex = 16;
            comboBoxPrograms.SelectedValueChanged += ComboxBoxProgramOnChange;
            // 
            // labelPrograms
            // 
            labelPrograms.AutoSize = true;
            labelPrograms.Location = new Point(438, 40);
            labelPrograms.Name = "labelPrograms";
            labelPrograms.Size = new Size(72, 20);
            labelPrograms.TabIndex = 15;
            labelPrograms.Text = "&Programs";
            // 
            // comboBoxLocation
            // 
            comboBoxLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLocation.FormattingEnabled = true;
            comboBoxLocation.Items.AddRange(new object[] { "ON", "QC", "NS", "NB", "MB", "BC", "PE", "SK", "AB", "NL " });
            comboBoxLocation.Location = new Point(136, 37);
            comboBoxLocation.Name = "comboBoxLocation";
            comboBoxLocation.Size = new Size(184, 28);
            comboBoxLocation.TabIndex = 14;
            comboBoxLocation.SelectedIndexChanged += ComboxBoxCampusOnChange;
            // 
            // labelLocation
            // 
            labelLocation.AutoSize = true;
            labelLocation.Location = new Point(7, 40);
            labelLocation.Name = "labelLocation";
            labelLocation.Size = new Size(123, 20);
            labelLocation.TabIndex = 13;
            labelLocation.Text = "Campus &Location";
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(28, 291);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(94, 29);
            buttonRegister.TabIndex = 21;
            buttonRegister.Text = "&Register Student";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += ButtonRegisterClick;
            // 
            // dataGridViewRecord
            // 
            dataGridViewRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecord.Columns.AddRange(new DataGridViewColumn[] { ColumnFirstName, ColumnLastName, ColumnSin, ColumnEmail, ColumnSchoolGrade, ColumnTestScore, ColumnLocation, ColumnProgram });
            dataGridViewRecord.Location = new Point(27, 326);
            dataGridViewRecord.Name = "dataGridViewRecord";
            dataGridViewRecord.RowHeadersWidth = 51;
            dataGridViewRecord.Size = new Size(1054, 188);
            dataGridViewRecord.TabIndex = 22;
            // 
            // ColumnFirstName
            // 
            ColumnFirstName.HeaderText = "First Name";
            ColumnFirstName.MinimumWidth = 6;
            ColumnFirstName.Name = "ColumnFirstName";
            ColumnFirstName.Width = 125;
            // 
            // ColumnLastName
            // 
            ColumnLastName.HeaderText = "Last Name";
            ColumnLastName.MinimumWidth = 6;
            ColumnLastName.Name = "ColumnLastName";
            ColumnLastName.Width = 125;
            // 
            // ColumnSin
            // 
            ColumnSin.HeaderText = "SIN";
            ColumnSin.MinimumWidth = 6;
            ColumnSin.Name = "ColumnSin";
            ColumnSin.Width = 125;
            // 
            // ColumnEmail
            // 
            ColumnEmail.HeaderText = "Email";
            ColumnEmail.MinimumWidth = 6;
            ColumnEmail.Name = "ColumnEmail";
            ColumnEmail.Width = 125;
            // 
            // ColumnSchoolGrade
            // 
            ColumnSchoolGrade.HeaderText = "High School Grade";
            ColumnSchoolGrade.MinimumWidth = 6;
            ColumnSchoolGrade.Name = "ColumnSchoolGrade";
            ColumnSchoolGrade.Width = 125;
            // 
            // ColumnTestScore
            // 
            ColumnTestScore.HeaderText = "Admission Test Score";
            ColumnTestScore.MinimumWidth = 6;
            ColumnTestScore.Name = "ColumnTestScore";
            ColumnTestScore.Width = 125;
            // 
            // ColumnLocation
            // 
            ColumnLocation.HeaderText = "Campus Location";
            ColumnLocation.MinimumWidth = 6;
            ColumnLocation.Name = "ColumnLocation";
            ColumnLocation.Width = 125;
            // 
            // ColumnProgram
            // 
            ColumnProgram.HeaderText = "Program";
            ColumnProgram.MinimumWidth = 6;
            ColumnProgram.Name = "ColumnProgram";
            ColumnProgram.Width = 125;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(28, 531);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(167, 29);
            buttonDelete.TabIndex = 23;
            buttonDelete.Text = "&Delete Record";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += ButtonDeleteRecordClick;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(212, 531);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(167, 29);
            buttonUpdate.TabIndex = 24;
            buttonUpdate.Text = "&Update Record";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += ButtonUpdateClick;
            // 
            // buttonRemoveAll
            // 
            buttonRemoveAll.Location = new Point(519, 531);
            buttonRemoveAll.Name = "buttonRemoveAll";
            buttonRemoveAll.Size = new Size(205, 29);
            buttonRemoveAll.TabIndex = 25;
            buttonRemoveAll.Text = "Remove &All Records";
            buttonRemoveAll.UseVisualStyleBackColor = true;
            buttonRemoveAll.Click += ButtonDeleteAllRecordClick;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(745, 531);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(210, 29);
            buttonLoad.TabIndex = 26;
            buttonLoad.Text = "L&oad Records to Server";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += ButtonLoadToServerClick;
            // 
            // labelSinSearch
            // 
            labelSinSearch.AutoSize = true;
            labelSinSearch.Location = new Point(27, 582);
            labelSinSearch.Name = "labelSinSearch";
            labelSinSearch.Size = new Size(32, 20);
            labelSinSearch.TabIndex = 27;
            labelSinSearch.Text = "S&IN";
            // 
            // comboBoxSinSearch
            // 
            comboBoxSinSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSinSearch.FormattingEnabled = true;
            comboBoxSinSearch.Location = new Point(66, 578);
            comboBoxSinSearch.Name = "comboBoxSinSearch";
            comboBoxSinSearch.Size = new Size(259, 28);
            comboBoxSinSearch.TabIndex = 28;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(987, 578);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 29;
            buttonExit.Text = "E&xit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += ExitClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 647);
            Controls.Add(buttonExit);
            Controls.Add(comboBoxSinSearch);
            Controls.Add(labelSinSearch);
            Controls.Add(buttonLoad);
            Controls.Add(buttonRemoveAll);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(dataGridViewRecord);
            Controls.Add(buttonRegister);
            Controls.Add(groupBoxPrograms);
            Controls.Add(buttonCheck);
            Controls.Add(groupBoxInformation);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DC Registration App";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBoxInformation.ResumeLayout(false);
            groupBoxInformation.PerformLayout();
            groupBoxPrograms.ResumeLayout(false);
            groupBoxPrograms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecord).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem fileToolStripMenuItem2;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private GroupBox groupBoxInformation;
        private TextBox textBoxLastName;
        private Label labelLastName;
        private TextBox textBoxFirstName;
        private Label labelFirstName;
        private Label labelTestScore;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private TextBox textBoxSin;
        private Label labelSin;
        private Label labelSchoolGrade;
        private ComboBox comboBoxTestScore;
        private ComboBox comboBoxSchoolGrade;
        private Button buttonCheck;
        private GroupBox groupBoxPrograms;
        private Label labelLocation;
        private Label labelPeriod;
        private ComboBox comboBoxPrograms;
        private Label labelPrograms;
        private ComboBox comboBoxLocation;
        private Label labelCostValue;
        private Label labelCost;
        private Label labelPeriodValue;
        private Button buttonRegister;
        private DataGridView dataGridViewRecord;
        private DataGridViewTextBoxColumn ColumnFirstName;
        private DataGridViewTextBoxColumn ColumnLastName;
        private DataGridViewTextBoxColumn ColumnSin;
        private DataGridViewTextBoxColumn ColumnEmail;
        private DataGridViewTextBoxColumn ColumnSchoolGrade;
        private DataGridViewTextBoxColumn ColumnTestScore;
        private DataGridViewTextBoxColumn ColumnLocation;
        private DataGridViewTextBoxColumn ColumnProgram;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonRemoveAll;
        private Button buttonLoad;
        private Label labelSinSearch;
        private ComboBox comboBoxSinSearch;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem recordToolStripMenuItem;
        private ToolStripMenuItem updateRecordToolStripMenuItem;
        private ToolStripMenuItem deleteRecordToolStripMenuItem;
        private ToolStripMenuItem deleteAllRecordsToolStripMenuItem;
        private ToolStripMenuItem loadRecordsToServerToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button buttonExit;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem readHelpToolStripMenuItem;
        private ToolStripMenuItem technicalSupportsToolStripMenuItem;
        private ToolStripMenuItem aboutDCRegistrationAppToolStripMenuItem;
    }
}
