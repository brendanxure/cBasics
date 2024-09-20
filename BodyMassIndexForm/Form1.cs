/* FileName:        BodyMassIndexForm.cs
   Author:          Brendan Obilo
   Date Created:    September 19, 2024
   Date Modified:   September 20, 2024
   Description:
   This is a Windows form that is designed to calculate the body mass index
   of user and gives the user the required output based on the required 
   height and weight input.
*/
namespace BodyMassIndexForm
{
    public partial class BodyMassIndexCalculator : Form
    {
        public BodyMassIndexCalculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This button closes the entire window form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// This button calculates the bmi of the user based on the input
        /// inserted in the textboxes after proper validation based on the
        /// valid datatypes and ranges required
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCalculateClick(object sender, EventArgs e)
        {
            // To establish a constant to hold the maximum limit for height in inches
            const int HeightMaxRange = 120;
            // To establish a constant to hold the minimum limit for height in inches
            const int HeightMinRange = 24;
            // To establish a constant to hold the minimum limit for weight in pounds
            const int WeightMinRange = 25;
            // To establish a constant to hold the minimum limit for an obese BMI
            const int ObeseMin = 30;
            // To establish a constant to hold the minimum limit for an overweight BMI
            const int OverweightMin = 25;
            // To establish a constant to hold the minimum limit for a healthy BMI
            const double HealthyMin = 18.5;
            // To establish a constant to hold the minimum limit for an underweight BMI
            const int UnderweightMin = 16;
            // To establish a constant to hold the BMI constant for calculation with pounds and inches
            const int BmiConstant = 703;
            // To establish a variable and initialize to hold the user height input
            double height;
            // To establish a variable and initialize to hold the user weight input
            double weight;
            // To establish a variable to determine if BMI should be calculated
            bool isValid = true;
            // To establish a variable to hold the body mass index calculated
            double bodyMassIndex;
            // To establish a variable to hold the value of the BMI condition
            String outputCategory;


            // To do a proper validation for the height input by the user
            if (double.TryParse(textBoxHeight.Text, out height))
            {
                // To determine if the height is between 24 and 120
                if (!(height >= HeightMinRange && height <= HeightMaxRange))
                {
                    // To ensure the calculation does not happen because input failed validation
                    isValid = false;
                    // To inform user the input wasn't between the range and prompt to input again
                    MessageBox.Show($"Please enter input between {HeightMinRange} inches and {HeightMaxRange} inches");
                }
            }
            else
            {
                // To ensure the calculation does not happen because input failed validation
                isValid = false;
                // To display error message due to data type from user input
                MessageBox.Show("Please enter a valid number for height");
            }

            // To do a proper validation for the weigth input by the user
            if (double.TryParse(textBoxWeight.Text, out weight))
            {
                // To determine if the weight is 25 pounds and above
                if (!(weight >= WeightMinRange))
                {
                    // To ensure the calculation does not happen because input failed validation
                    isValid = false;
                    // To inform user the input wasn't between the range and prompt to input again
                    MessageBox.Show($"Please enter input from {WeightMinRange} pounds and above");
                }
            }
            else
            {
                // To ensure the calculation does not happen because input failed validation
                isValid = false;
                // To display error message due to data type from user input
                MessageBox.Show("Please enter a valid number for weight");
            }

            if (isValid)
            {
                // To store the result of the BMI calculation
                bodyMassIndex = (BmiConstant) * weight / Math.Pow(height, 2);

                // To convert the BMI result to one decimal place
                bodyMassIndex = Math.Round(bodyMassIndex * 10) / 10.0;

                // To compare the BMI to know which BMI level it falls into
                if (bodyMassIndex >= ObeseMin)
                {
                    outputCategory = "Obese";
                }
                else if (bodyMassIndex >= OverweightMin)
                {
                    outputCategory = "Overweight";
                }
                else if (bodyMassIndex >= HealthyMin)
                {
                    outputCategory = "Healthy";
                }
                else if (bodyMassIndex >= UnderweightMin)
                {
                    outputCategory = "Underweight";
                }
                else
                {
                    outputCategory = "Severely Underweight";
                }

                // To display the desired output consisting of user inputs, BMI, and BMI level it falls on
                textBoxOutput.Text = $"A height of {height:F1} inches and a body weight of {weight:F1} pounds give a BMI of {bodyMassIndex:F1}, you are considered {outputCategory}";

                // To determine the amount of weight the user needs to gain if needed
                if (bodyMassIndex < HealthyMin)
                {
                    double massIndexLoss = HealthyMin - bodyMassIndex;
                    double weightToAdd = (massIndexLoss / BmiConstant) * Math.Pow(height, 2);
                    textBoxOutput.Text = $"{textBoxOutput.Text} \nGain {weightToAdd:F1} pounds to be healthy";
                }

                // To determine the amount of weight the user needs to lose if needed
                if (bodyMassIndex >= OverweightMin)
                {
                    double massIndexAdded = bodyMassIndex - OverweightMin;
                    double weightToLose = (massIndexAdded / BmiConstant) * Math.Pow(height, 2);
                    textBoxOutput.Text = $"{textBoxOutput.Text}{Environment.NewLine}Lose {weightToLose:F1} pounds to be healthy";
                }

                // Disable the input features until reset.
                textBoxHeight.ReadOnly = true;
                textBoxWeight.ReadOnly = true;
                buttonCalculate.Enabled = false;
                buttonReset.Focus();
            }
        }

        /// <summary>
        /// This button is used to clears the entire fields and sets the text boxes
        /// to back to default and place the focus on the text box for height 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonResetClick(object sender, EventArgs e)
        {
            // Clear all input and output fields.
            textBoxHeight.Clear();
            textBoxWeight.Text = string.Empty;
            textBoxOutput.Clear();

            // Re-enable all input controls.
            textBoxHeight.ReadOnly = false;
            textBoxWeight.ReadOnly = false;
            buttonCalculate.Enabled = true;

            // Set focus to allow easy entry.
            textBoxHeight.Focus();
        }

    }
}
