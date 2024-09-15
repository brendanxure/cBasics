
namespace BananaCalculator
{
    partial class formBananaCalculator
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
            this.components = new System.ComponentModel.Container();
            this.labelNumberOfBanana = new System.Windows.Forms.Label();
            this.textBoxCurrentBananas = new System.Windows.Forms.TextBox();
            this.labelDaysUntilShop = new System.Windows.Forms.Label();
            this.textBoxDaysUntilShop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBananasPerDay = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNumberOfBanana
            // 
            this.labelNumberOfBanana.AutoSize = true;
            this.labelNumberOfBanana.Location = new System.Drawing.Point(28, 40);
            this.labelNumberOfBanana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumberOfBanana.Name = "labelNumberOfBanana";
            this.labelNumberOfBanana.Size = new System.Drawing.Size(144, 25);
            this.labelNumberOfBanana.TabIndex = 0;
            this.labelNumberOfBanana.Text = "Current &Bananas:";
            // 
            // textBoxCurrentBananas
            // 
            this.textBoxCurrentBananas.Location = new System.Drawing.Point(228, 37);
            this.textBoxCurrentBananas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCurrentBananas.Name = "textBoxCurrentBananas";
            this.textBoxCurrentBananas.Size = new System.Drawing.Size(141, 31);
            this.textBoxCurrentBananas.TabIndex = 1;
            this.toolTip.SetToolTip(this.textBoxCurrentBananas, "Enter your current amount of bananas");
            // 
            // labelDaysUntilShop
            // 
            this.labelDaysUntilShop.AutoSize = true;
            this.labelDaysUntilShop.Location = new System.Drawing.Point(28, 90);
            this.labelDaysUntilShop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDaysUntilShop.Name = "labelDaysUntilShop";
            this.labelDaysUntilShop.Size = new System.Drawing.Size(179, 25);
            this.labelDaysUntilShop.TabIndex = 2;
            this.labelDaysUntilShop.Text = "&Days Until Shopping:";
            // 
            // textBoxDaysUntilShop
            // 
            this.textBoxDaysUntilShop.Location = new System.Drawing.Point(228, 87);
            this.textBoxDaysUntilShop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDaysUntilShop.Name = "textBoxDaysUntilShop";
            this.textBoxDaysUntilShop.Size = new System.Drawing.Size(141, 31);
            this.textBoxDaysUntilShop.TabIndex = 3;
            this.toolTip.SetToolTip(this.textBoxDaysUntilShop, "Enter the number of days until you expect to go shopping");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bananas Per Day:";
            // 
            // textBoxBananasPerDay
            // 
            this.textBoxBananasPerDay.Location = new System.Drawing.Point(228, 138);
            this.textBoxBananasPerDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBananasPerDay.Name = "textBoxBananasPerDay";
            this.textBoxBananasPerDay.ReadOnly = true;
            this.textBoxBananasPerDay.Size = new System.Drawing.Size(141, 31);
            this.textBoxBananasPerDay.TabIndex = 5;
            this.toolTip.SetToolTip(this.textBoxBananasPerDay, "Displays the calculated number of bananas per day");
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(28, 252);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(107, 38);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "&Calculate";
            this.toolTip.SetToolTip(this.buttonCalculate, "Click to attempt to calculate the number of bananas per day");
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.CalculateClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(145, 252);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(107, 38);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "&Reset";
            this.toolTip.SetToolTip(this.buttonReset, "Click to reset the form to its default state");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(262, 252);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(107, 38);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "E&xit";
            this.toolTip.SetToolTip(this.buttonExit, "Click to exit the application");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ExitClick);
            // 
            // labelResult
            // 
            this.labelResult.Location = new System.Drawing.Point(28, 192);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(341, 38);
            this.labelResult.TabIndex = 9;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formBananaCalculator
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(396, 312);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxBananasPerDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDaysUntilShop);
            this.Controls.Add(this.labelDaysUntilShop);
            this.Controls.Add(this.textBoxCurrentBananas);
            this.Controls.Add(this.labelNumberOfBanana);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formBananaCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banana Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumberOfBanana;
        private System.Windows.Forms.TextBox textBoxCurrentBananas;
        private System.Windows.Forms.Label labelDaysUntilShop;
        private System.Windows.Forms.TextBox textBoxDaysUntilShop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBananasPerDay;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label labelResult;
    }
}

