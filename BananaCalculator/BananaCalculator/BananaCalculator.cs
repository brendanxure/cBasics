/* FileName:        BananaCalculator.cs
   Author:          Brendan Obilo
   Date Created:    September 13, 2024
   Date Modified:   September 13, 2024
   Description:
 This is a Windows form that is designed to tell a user whether
 they have enough bananas to make it to their next planned
 shopping trip.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BananaCalculator
{
    public partial class formBananaCalculator : Form
    {
        /// <summary>
        /// Constructor for the form.
        /// </summary>
        public formBananaCalculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This attempts to parse the input to ensure it's valid, and then determine the number of bananas per day.
        /// </summary>
        private void CalculateClick(object sender, EventArgs e)
        {
            // Declarations
            const int ChapmanBananasPerDay = 3;
            
            double currentBananas;
            double remainingDays;
            double bananasPerDay;

            // Try to parse the number of bananas entered to a number, and check if it's positive.
            if (double.TryParse(textBoxCurrentBananas.Text, out currentBananas) && currentBananas > 0)
            {
                // Try to parse the remaining days to a number, and check if it's positive.
                if (double.TryParse(textBoxDaysUntilShop.Text, out remainingDays) && remainingDays > 0)
                {
                    // This is where the processing happens.
                    bananasPerDay = currentBananas / remainingDays;
                    // Output.
                    textBoxBananasPerDay.Text = Math.Round(bananasPerDay, 1).ToString();

                    if (bananasPerDay >= ChapmanBananasPerDay)
                    {
                        labelResult.Text = currentBananas + " is enough bananas!";
                    }
                    else
                    {
                        labelResult.Text = currentBananas + " is not enough bananas.";
                    }

                    // Disable the input features until reset.
                    textBoxCurrentBananas.ReadOnly = true;
                    textBoxDaysUntilShop.ReadOnly = true;
                    buttonCalculate.Enabled = false;
                    buttonReset.Focus();
                }
                // The remaining days is non-numeric or negative.
                else
                {
                    MessageBox.Show("Please enter a positive number of days.");
                }        
            }
            // The number of bananas is non-numeric or negative.
            else
            {
                MessageBox.Show("Please enter a positive number of bananas.");
            }
        }

        /// <summary>
        /// This exits the application.
        /// </summary>
        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Reset all fields!
        /// </summary>
        private void ResetClick(object sender, EventArgs e)
        {
            // Clear all input and output fields.
            textBoxCurrentBananas.Clear();
            textBoxDaysUntilShop.Text = String.Empty;
            textBoxBananasPerDay.Text = "";
            labelResult.Text = String.Empty;

            // Re-enable all input controls.
            textBoxCurrentBananas.ReadOnly = false;
            textBoxDaysUntilShop.ReadOnly = false;
            buttonCalculate.Enabled = true;

            // Set focus to allow easy entry.
            textBoxCurrentBananas.Focus();
        }
    }
}