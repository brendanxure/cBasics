// Author:  Brendan Xure
// Date:    September 5, 2024
// Description:
// A program that detects awesomeness and then
// forces the user to acknowledge any detected
// awesomeness.

namespace Awesomeness
{
    public partial class formAwesomeness : Form
    {
        // Constructor for the form. I didn't write this. ;)
        public formAwesomeness()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When you click yes, the program is nice and then exits.
        /// </summary>
        private void YesClick(object sender, EventArgs e)
        {
            MessageBox.Show("Yes, you are awesome. That's great. Yay.");
            Close();
        }
        /// <summary>
        /// Event handler for the left no button.
        /// </summary>
        private void buttonLeftNo_Click(object sender, EventArgs e)
        {
            buttonLeftNo.Visible = false;
            buttonRightNo.Visible = true;
        }

        /// <summary>
        /// When you attempt to click the right button, it goes away.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRightNo_Click(object sender, EventArgs e)
        {
            buttonRightNo.Visible = false;
            buttonLeftNo.Visible = true;

            //MessageBox.Show(sender.ToString());
        }
    }
}
