namespace ScreenSizeGUI
{
    public partial class formScreenSize : Form
    {
        public formScreenSize()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Declarations.
            // A decimal value representing the width of a screen.
            double width = 0.0;
            // Unsigned 32-bit integer.
            uint height = 0u;
            // A decimal value for the diagonal.
            decimal diagonal;
            // Boolean.
            bool isValid = true;

            // Input.
            if (double.TryParse(textWidth.Text, out width))
            {
                // Check that the width is positive.
                if (width <= 0)
                {
                    // Type is valid, range is valid: it's valid. Exit the loop.
                    isValid = false;
                    textDiagonal.Text = "Width must be a positive number.";
                }
            }
            // Input was not a double; write an error message.
            else
            {
                isValid = false;
                textDiagonal.Text = "Width must be numeric.";
            }

            if (uint.TryParse(textHeight.Text, out height))
            {
                // Check that the height is positive.
                if (height <= 0)
                {
                    // Type is valid, range is valid: it's valid. Exit the loop.
                    isValid = false;
                    textDiagonal.Text = "Height must be a positive number.";
                }
            }
            // Input was not a uint; write an error message.
            else
            {
                isValid = false;
                textDiagonal.Text = "Height must be numeric.";
            }

            if (isValid)
            {
                // Processing.
                // Use Pythagorean theorem: square root the height squared + width squared.
                diagonal = (decimal)Math.Sqrt(width * width + height * height);
                diagonal = Math.Round(diagonal, 1);

                textDiagonal.Text = diagonal.ToString() + "\"";
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textWidth.Clear();
            textHeight.Text = "";
            textDiagonal.Text = String.Empty;
            textWidth.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
