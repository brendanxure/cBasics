namespace ScreenSizeGUI
{
    partial class formScreenSize
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
            labelWidth = new Label();
            textWidth = new TextBox();
            labelHeight = new Label();
            textHeight = new TextBox();
            buttonCalculate = new Button();
            buttonReset = new Button();
            buttonExit = new Button();
            textDiagonal = new TextBox();
            labelDiagonal = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // labelWidth
            // 
            labelWidth.AutoSize = true;
            labelWidth.Location = new Point(56, 23);
            labelWidth.Name = "labelWidth";
            labelWidth.Size = new Size(52, 20);
            labelWidth.TabIndex = 0;
            labelWidth.Text = "Width:";
            // 
            // textWidth
            // 
            textWidth.Location = new Point(142, 20);
            textWidth.Name = "textWidth";
            textWidth.Size = new Size(125, 27);
            textWidth.TabIndex = 1;
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Location = new Point(51, 71);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(57, 20);
            labelHeight.TabIndex = 2;
            labelHeight.Text = "Height:";
            // 
            // textHeight
            // 
            textHeight.Location = new Point(142, 68);
            textHeight.Name = "textHeight";
            textHeight.Size = new Size(125, 27);
            textHeight.TabIndex = 3;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(22, 176);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(94, 29);
            buttonCalculate.TabIndex = 4;
            buttonCalculate.Text = "&Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(133, 176);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 29);
            buttonReset.TabIndex = 5;
            buttonReset.Text = "&Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(245, 179);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 6;
            buttonExit.Text = "E&xit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // textDiagonal
            // 
            textDiagonal.Location = new Point(142, 116);
            textDiagonal.Name = "textDiagonal";
            textDiagonal.ReadOnly = true;
            textDiagonal.Size = new Size(125, 27);
            textDiagonal.TabIndex = 8;
            // 
            // labelDiagonal
            // 
            labelDiagonal.AutoSize = true;
            labelDiagonal.Location = new Point(35, 119);
            labelDiagonal.Name = "labelDiagonal";
            labelDiagonal.Size = new Size(73, 20);
            labelDiagonal.TabIndex = 7;
            labelDiagonal.Text = "Diagonal:";
            // 
            // formScreenSize
            // 
            AcceptButton = buttonCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonReset;
            ClientSize = new Size(358, 256);
            Controls.Add(textDiagonal);
            Controls.Add(labelDiagonal);
            Controls.Add(buttonExit);
            Controls.Add(buttonReset);
            Controls.Add(buttonCalculate);
            Controls.Add(textHeight);
            Controls.Add(labelHeight);
            Controls.Add(textWidth);
            Controls.Add(labelWidth);
            Name = "formScreenSize";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Screen Size Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWidth;
        private TextBox textWidth;
        private Label labelHeight;
        private TextBox textHeight;
        private Button buttonCalculate;
        private Button buttonReset;
        private Button buttonExit;
        private TextBox textDiagonal;
        private Label labelDiagonal;
        private ToolTip toolTip1;
    }
}
