/* FileName:        MessageSentForm
   Author:          Brendan Obilo
   Date Created:    September 26, 2024
   Date Modified:   September 28, 2024
   Description:
   This is a Windows program that will take an input for each day in the week 
   numbered from 1 to 7. The user input data will need to be validated and, 
   if it passes validation, the data will need to be displayed to the user. 
   Once the number of units has been entered for the seventh and final day, 
   the solution will calculate and display the average to the user.
*/

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MessageSentForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textBoxUserInput.Focus();
        }

        // To establish a varibale that holds the current day to collect message number
        int presentDay = 1;


        // To etsblish a variable that calculates the present total messages
        int runningTotal = 0;

        // To handle the event that happens when you click the enter button
        private void ButtonEnterClick(object sender, RoutedEventArgs e)
        {
            // To estbalish a constant to hold the maximum number of messages in a day
            const int MaximumNumber = 10000;
            // To estbalish a constant to hold the minimum number of messages in a day
            const int MinimumNumber = 0;
            // To establish a constant that holds the maximum number of days
            const int MaximumDays = 7;
            // To estbalish a variable to hold the user input after validation
            int userInput;

            // To validate the user input and ensure it is the right data type
            if (int.TryParse(textBoxUserInput.Text, out userInput))
            {
                // To ensure the user input is between maximum and minimum limits
                if (userInput > MinimumNumber && userInput <= MaximumNumber)
                {
                    // To collect validated user input and line them up in the textblock
                    textBlockWeeklyMessages.Text += $"{userInput} {Environment.NewLine}";
                    // To calculate the running total by incrementing by the user input
                    runningTotal += userInput;
                    // To clear the user input textbox
                    textBoxUserInput.Clear();
                    // To check if the user has entered all inputs for required amount of days
                    if (presentDay == MaximumDays) 
                    {
                        // To disable the userinput textbox
                        textBoxUserInput.IsEnabled = false;
                        // To disable the enter button
                        buttonEnter.IsEnabled = false;
                        // To set the focus on reset button
                        buttonReset.Focus();
                        // To calculate the average message sent
                        double averageMessageSent = (double) runningTotal / MaximumDays;
                        // To display the result from the textbox to the output textbox
                        textBoxMessagePerDay.Text = $"Messages per day: {averageMessageSent:F1}";
                    } else
                    {
                        // To increment the day by one after each day has been collected
                        presentDay += 1;
                        // To set the focus to user inout textbox after collection of valid input
                        textBoxUserInput.Focus();
                    }
                    // To update the display of the current day to collect message number
                    labelDays.Content = $"Day {presentDay}";
                }
                else
                {
                    // To display a message error box that tell user the boundary of input that is expected
                    MessageBox.Show($"Please input should be between {MinimumNumber} and {MaximumNumber}");
                    // To set the focus to user inout textbox after collection of valid input
                    textBoxUserInput.Focus();
                }
            }
            else
            {
                // To display the message error box that tell user the valid data type that is expected
                MessageBox.Show("Please input a valid interger");
                // To set the focus to user inout textbox after collection of valid input
                textBoxUserInput.Focus();
            }
          
        }

        // To handle the event that happens when you click the reset button
        private void ButtonResetClick(object sender, RoutedEventArgs e)
        {
            // To enable the textbox
            textBoxUserInput.IsEnabled = true;
            // To enable the enter button
            buttonEnter.IsEnabled = true;
            // To clear the user input textbox
            textBoxUserInput.Clear();
            // To clear the textbox output for average messages per day
            textBoxMessagePerDay.Clear();
            // To clear the textblock that displays the entire amount of message for each day
            textBlockWeeklyMessages.Text = "";
            // To set the focus of the window program to the user input textbox
            textBoxUserInput.Focus();
            // To reset the day value back to one
            presentDay = 1;
            // To display the day value set to day 1
            labelDays.Content = $"Day {presentDay}";
            // To clear the entire running total to zero to start another running total
            runningTotal = 0;
        }

        // To handle the event that happens when you click the exit button
        private void ButtonExitClick(object sender, RoutedEventArgs e)
        {
            // to close the entire window program
            this.Close();
        }
    }
}