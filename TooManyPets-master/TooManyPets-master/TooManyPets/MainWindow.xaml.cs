// Author:  Brendan Obilo
// Created: September 17, 2024
// Modified: September 24, 2024
// Description:
//  Attempts to measure whether a user has too many pets or not using
// a super-secret proprietary algorithm. It's so secret I don't know
// what it is as of this writing.

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TooManyPets
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructor for the form.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            ResetForm();
        }

        #region "Event Handlers"

        /// <summary>
        /// Checks whether the person has too many pets based on the data entered into
        /// several form controls.
        /// </summary>
        private void CheckClick(object sender, RoutedEventArgs e)
        {
            if (ValidateAllTextboxes())
            {
                CheckPets();
            }
        }

        /// <summary>
        /// Clears all input and output fields to put the form in its initial state.
        /// </summary>
        private void ClearClick(object sender, RoutedEventArgs e)
        {
            ResetForm();
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        private void ExitClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        #endregion

        #region "Functions"

        /// <summary>
        /// Set the form to its default state.
        /// </summary>
        private void ResetForm()
        {
            // Clear all the inputs and outputs.
            textPeople.Clear();
            textDogs.Clear();
            textCats.Clear();
            textBirds.Clear();
            textOther.Clear();
            checkFish.IsChecked = false;
            textOutput.Clear();

            // Set focus.
            textPeople.Focus();
        }

        /// <summary>
        /// Check whether all textboxes on the form contain valid numbers.
        /// </summary>
        /// <returns>true if all textboxes have valid numbers; false otherwise.</returns>
        private bool ValidateAllTextboxes()
        {
            return ValidateTextbox(textPeople) &&
                ValidateTextbox(textDogs) &&
                ValidateTextbox(textCats) &&
                ValidateTextbox(textBirds) &&
                ValidateTextbox(textOther);
        }

        /// <summary>
        /// Validates a single textbox as a positive whole number.
        /// </summary>
        /// <param name="textToValidate">A textbox to validate</param>
        /// <returns>true if textbox's contents are a positive whole number; false otherwise</returns>
        private bool ValidateTextbox(TextBox textToValidate)
        {
            const int Minimum = 0;
            const int Maximum = Int32.MaxValue;
            int contents;
            if (int.TryParse(textToValidate.Text, out contents))
            {
                if (Minimum <= contents && contents < Maximum)
                {
                    return true;
                }
                else
                {
                    textOutput.Text = "Pet counts must be between " + Minimum + " and " + Maximum + ".";
                    textToValidate.SelectAll();
                    textToValidate.Focus();
                    return false;
                }
            }
            else
            {
                textOutput.Text = "Pet counts must be whole numbers.";
                textToValidate.SelectAll();
                textToValidate.Focus();
                return false;
            }
        }

        private void CheckPets()
        {
            // Some kind of algorithm for whether a person has too many pets...
            int people = int.Parse(textPeople.Text);
            int cats = int.Parse(textCats.Text);
            int dogs = int.Parse(textDogs.Text);
            int birds = int.Parse(textBirds.Text);
            int other = int.Parse(textOther.Text);
            int fish = 0;
            if (checkFish.IsChecked == true)
            {
                fish++;
            }

            // adjusted quantity = cats + dogs + birds + sqrt(other) + (if fish 1)
            double adjusted_pet_quantity = cats + dogs + birds + Math.Sqrt(other) + fish;

            // if people * 2 >= adjusted quantity it's not too many
            if (people * 2 > adjusted_pet_quantity)
            {
                textOutput.Text = "You have a good amount of pets. 😀";
            }
            else
            {
                // Sorry for judging.
                textOutput.Text = "You have too many pets. 🐕🐈🦏";
            }
        }
        
        #endregion
    }
}