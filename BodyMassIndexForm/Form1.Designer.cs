namespace BodyMassIndexForm
{
    partial class BodyMassIndexCalculator
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
            labelHeight = new Label();
            textBoxHeight = new TextBox();
            labelWeight = new Label();
            textBoxWeight = new TextBox();
            label1 = new Label();
            textBoxOutput = new TextBox();
            buttonCalculate = new Button();
            buttonReset = new Button();
            buttonExit = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Font = new Font("Segoe UI", 12F);
            labelHeight.Location = new Point(142, 72);
            labelHeight.Margin = new Padding(4, 0, 4, 0);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(123, 28);
            labelHeight.TabIndex = 0;
            labelHeight.Text = "&Height(inch):";
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(338, 69);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(221, 34);
            textBoxHeight.TabIndex = 1;
            toolTip1.SetToolTip(textBoxHeight, "Enter height in inch");
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Location = new Point(142, 154);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(157, 28);
            labelWeight.TabIndex = 2;
            labelWeight.Text = "&Weight(pounds):";
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(338, 151);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(221, 34);
            textBoxWeight.TabIndex = 3;
            toolTip1.SetToolTip(textBoxWeight, "Enter weight in pounds");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 229);
            label1.Name = "label1";
            label1.Size = new Size(50, 28);
            label1.TabIndex = 4;
            label1.Text = "&BMI:";
            // 
            // textBoxOutput
            // 
            textBoxOutput.Enabled = false;
            textBoxOutput.Location = new Point(338, 229);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(335, 142);
            textBoxOutput.TabIndex = 5;
            toolTip1.SetToolTip(textBoxOutput, "Displays the result of the calculation");
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(144, 403);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(155, 40);
            buttonCalculate.TabIndex = 6;
            buttonCalculate.Text = "&Calculate";
            toolTip1.SetToolTip(buttonCalculate, "Click to calculate");
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += ButtonCalculateClick;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(381, 403);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(177, 40);
            buttonReset.TabIndex = 7;
            buttonReset.Text = "&Reset";
            toolTip1.SetToolTip(buttonReset, "Click to reset fields");
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += ButtonResetClick;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(642, 402);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(148, 43);
            buttonExit.TabIndex = 8;
            buttonExit.Text = "E&xit";
            toolTip1.SetToolTip(buttonExit, "Click to exit the application");
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += ButtonExitClick;
            // 
            // BodyMassIndexCalculator
            // 
            AcceptButton = buttonCalculate;
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonExit;
            ClientSize = new Size(1199, 630);
            Controls.Add(buttonExit);
            Controls.Add(buttonReset);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxOutput);
            Controls.Add(label1);
            Controls.Add(textBoxWeight);
            Controls.Add(labelWeight);
            Controls.Add(textBoxHeight);
            Controls.Add(labelHeight);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "BodyMassIndexCalculator";
            Text = "BodyMassIndexCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeight;
        private TextBox textBoxHeight;
        private Label labelWeight;
        private TextBox textBoxWeight;
        private Label label1;
        private TextBox textBoxOutput;
        private Button buttonCalculate;
        private Button buttonReset;
        private Button buttonExit;
        private ToolTip toolTip1;
    }
}
