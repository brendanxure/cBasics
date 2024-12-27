namespace RegistrationApp
{
    partial class Form2
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
            labelDetails = new Label();
            buttonExitHelp = new Button();
            SuspendLayout();
            // 
            // labelDetails
            // 
            labelDetails.AutoSize = true;
            labelDetails.Location = new Point(47, 20);
            labelDetails.Name = "labelDetails";
            labelDetails.Size = new Size(50, 20);
            labelDetails.TabIndex = 0;
            labelDetails.Text = "label1";
            // 
            // buttonExitHelp
            // 
            buttonExitHelp.Location = new Point(320, 414);
            buttonExitHelp.Name = "buttonExitHelp";
            buttonExitHelp.Size = new Size(119, 49);
            buttonExitHelp.TabIndex = 1;
            buttonExitHelp.Text = "E&xit";
            buttonExitHelp.UseVisualStyleBackColor = true;
            buttonExitHelp.Click += ButtonExitHelpClick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
            Controls.Add(buttonExitHelp);
            Controls.Add(labelDetails);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Help";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDetails;
        private Button buttonExitHelp;
    }
}