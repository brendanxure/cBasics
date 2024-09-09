namespace Awesomeness
{
    partial class formAwesomeness
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
            components = new System.ComponentModel.Container();
            labelMessage = new Label();
            buttonLeftNo = new Button();
            buttonRightNo = new Button();
            toolTip1 = new ToolTip(components);
            buttonYes = new Button();
            SuspendLayout();
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMessage.ForeColor = Color.FromArgb(0, 64, 0);
            labelMessage.Location = new Point(12, 39);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(412, 50);
            labelMessage.TabIndex = 0;
            labelMessage.Text = "The computer has detected that you are awesome.\r\nIs it possible that you are awesome?";
            labelMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonLeftNo
            // 
            buttonLeftNo.Location = new Point(168, 105);
            buttonLeftNo.Name = "buttonLeftNo";
            buttonLeftNo.Size = new Size(94, 29);
            buttonLeftNo.TabIndex = 2;
            buttonLeftNo.Text = "&No";
            toolTip1.SetToolTip(buttonLeftNo, "Click if you are not awesome");
            buttonLeftNo.UseVisualStyleBackColor = true;
            buttonLeftNo.Visible = false;
            buttonLeftNo.Click += buttonLeftNo_Click;
            buttonLeftNo.MouseEnter += buttonLeftNo_Click;
            // 
            // buttonRightNo
            // 
            buttonRightNo.Location = new Point(310, 105);
            buttonRightNo.Name = "buttonRightNo";
            buttonRightNo.Size = new Size(94, 29);
            buttonRightNo.TabIndex = 100;
            buttonRightNo.Text = "&No";
            toolTip1.SetToolTip(buttonRightNo, "Click if you are not awesome");
            buttonRightNo.UseVisualStyleBackColor = true;
            buttonRightNo.Click += buttonRightNo_Click;
            buttonRightNo.MouseEnter += buttonRightNo_Click;
            // 
            // buttonYes
            // 
            buttonYes.Location = new Point(27, 105);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new Size(94, 29);
            buttonYes.TabIndex = 1;
            buttonYes.Text = "&Yes";
            toolTip1.SetToolTip(buttonYes, "Click if you are not awesome");
            buttonYes.UseVisualStyleBackColor = true;
            buttonYes.Click += YesClick;
            // 
            // formAwesomeness
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 182);
            Controls.Add(buttonYes);
            Controls.Add(buttonRightNo);
            Controls.Add(buttonLeftNo);
            Controls.Add(labelMessage);
            MinimizeBox = false;
            Name = "formAwesomeness";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Awesomeness Detector";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMessage;
        private Button buttonLeftNo;
        private Button buttonRightNo;
        private ToolTip toolTip1;
        private Button buttonYes;
    }
}
