// Name: Brendan Obilo
// Project name: DC Registration App
// Date: 19/11/2024
// 

using Newtonsoft.Json;
using System.Collections;

namespace RegistrationApp
{
    public partial class Form1 : Form
    {
        // Instance Variables
        List<Programs> programList;
        List<Student> studentList = new List<Student>();
        private int sinNumber;
        public Form1()
        {
            InitializeComponent();
            programList = new List<Programs>
            {
                new Programs("Architectural", 15000m, 3),
                new Programs("Science and Art", 12000m, 2),
                new Programs("Law", 20000m, 3),
                new Programs("Health", 18000m, 3),
                new Programs("Engineering", 22000m, 3),
                new Programs("Music", 10000m, 1),
                new Programs("Business", 14000m, 2)
            };
        }

        // Event handler for read help that is clicked to show the details in a new page
        private void ReadHelpClick(object sender, EventArgs e)
        {
            string helpDetails = "Fill in the following fields:\r\nFirst Name and Last Name: Use the provided text boxes.\r\nEmail: Enter a valid email address in the text box.\r\nSIN: Provide a unique Social Insurance Number in the text box.\r\nHigh School Grade: Select a value from the dropdown list (options: 10, 20, ..., 90).\r\nAdmission Test Score: Select a value from the dropdown list (options: 10, 20, ..., 90).\r\n\r\nOnce the student is eligible, select a campus from the activated Campus Location dropdown.\r\nThe Programs dropdown will activate, listing only the programs available at the selected campus.\r\nProgram options include: {Architectural, Science and Art, Law, Health, Engineering, Music, Business}.\r\n\r\nAfter selecting a campus and program, the student’s admission details will be finalized.\r\nThe system will automatically record the following:\r\n1. Program Fees (per year)\r\n2. Registration Fees (per year)\r\n3. Study Duration (1–3 years)\r\nAdmission details will appear in the DataGridView, showing all the information entered.\r\n";
            Form2 help = new Form2();
            help.DisplayDetails = helpDetails;
            help.Text = "Read Help";
            help.ShowDialog();
        }

        // Event handler for teach support that is clicked to show the details in a new page
        private void TechnicalSupportsClick(object sender, EventArgs e)
        {
            string techSupportDetails = "Name: \r\n\r\nID: \r\n\r\nDC email: \r\n";
            Form2 techSupport = new Form2();
            techSupport.DisplayDetails = techSupportDetails;
            techSupport.Text = "Technical Support";
            techSupport.ShowDialog();
        }

        // Event handler for About DC - Registration App that is clicked to show the details in a new page
        private void AboutDCRegistrationAppClick(object sender, EventArgs e)
        {
            string description = "The DC Registration App is a comprehensive student registration management system for Durham College. \r\n" +
                                 "Designed for efficiency, the app allows users to easily register, update, and manage student records. \r\n" +
                                 "Students can provide personal details such as their name, SIN, email address, school grade, and test score. \r\n" +
                                 "With a simple and intuitive interface, users can delete individual records or remove all records in bulk. \r\n" +
                                 "Additionally, the app includes the ability to load records to a server and conduct searches. \r\n" +
                                 "The system supports multiple programs, each offering varying costs and duration based on student input. \r\n" +
                                 "Users can choose from a variety of locations and programs to customize their registration experience. \r\n" +
                                 "The dynamic cost and period labels update automatically as users select different options. \r\n" +
                                 "The app's navigation is streamlined with a menu system that provides quick access to all functions. \r\n" +
                                 "Administrative users can quickly update or delete student records as needed. \r\n" +
                                 "The registration form is designed to ensure that all necessary information is captured with ease. \r\n" +
                                 "Record management is simplified, offering features for easy updates, deletions, and data verification. \r\n" +
                                 "Data integrity is maintained through real-time validation, minimizing errors in student records. \r\n" +
                                 "The DC Registration App ensures a smooth registration process while keeping all student data organized.";
            Form2 aboutDCRegistrationApp = new Form2();
            aboutDCRegistrationApp.DisplayDetails = description;
            aboutDCRegistrationApp.Text = "About DC - Registration App";
            aboutDCRegistrationApp.ShowDialog();
        }

        // An exit button handler to close the application
        private void ExitClick(object sender, EventArgs e)
        {
            this.Close();
        }

        // An event handler for the check button to validate the student info details entered
        private void ButtonCheckClick(object sender, EventArgs e)
        {
            try
            {
                ValidateStudentInfo();
            }
            catch (ArgumentNullException ex)
            {
                comboBoxTestScore.SelectedIndex = -1;
                comboBoxSchoolGrade.SelectedIndex = -1;
                MessageBox.Show(ex.Message);
            }
            catch (InvalidCastException ex) 
            {
                comboBoxTestScore.SelectedIndex = -1;
                comboBoxSchoolGrade.SelectedIndex = -1;
                MessageBox.Show(ex.Message);
            }

        }

        // An event handler that handles the change in state of selection for combobox for campus
        private void ComboxBoxCampusOnChange(object sender, EventArgs e)
        {
            comboBoxPrograms.Enabled = true ;
            if (comboBoxPrograms.Items.Count == 0)
            {
                foreach (Programs item in programList)
                {
                    comboBoxPrograms.Items.Add(item.programName);
                }
            }
            
        }

        // An event handler that fires when a program is selected in the combobox
        private void ComboxBoxProgramOnChange(object sender, EventArgs e)
        {
            foreach (Programs item in programList)
            {
                if (item.programName.Trim() == comboBoxPrograms.Text.Trim())
                {
                    labelCostValue.Text = "$" + item.programFees.ToString();
                    labelPeriodValue.Text = item.programDuration.ToString() + "year(s)";
                }
            }
        }
        
        /// <summary>
        /// An Event Handler to validate the sin and register stduent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRegisterClick(object sender, EventArgs e)
        {
            try
            {
                ValidateStudentInfo();
                if (ValidateSin(sinNumber))
                {
                    ResetForm();
                    throw new ArgumentException("Student already has an admission");
                }
                else if (comboBoxLocation.SelectedIndex == -1 || comboBoxPrograms.SelectedIndex == -1)
                {
                    throw new ArgumentException("Please enter the campus location and program");
                }
                else
                {
                    Student newStudent = new Student(textBoxFirstName.Text.Trim(), textBoxLastName.Text.Trim(), int.Parse(textBoxSin.Text.Trim()), textBoxEmail.Text.Trim(), int.Parse(comboBoxSchoolGrade.Text.Trim()), int.Parse(comboBoxTestScore.Text.Trim()), comboBoxLocation.Text, comboBoxPrograms.Text);
                    studentList.Add(newStudent);
                    UpdateGridView();
                };
                
            }
            catch (ArgumentException ex) 
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// A button to update the student record by retrieving it back to the student info and deleting it previous record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxSinSearch.SelectedIndex == -1)
                {
                    throw new ArgumentNullException("Select a sin number from the drop list");
                }
                else 
                {
                    for(int i = 0; i <studentList.Count; i ++) 
                    {
                        Student student = studentList[i];
                        if (student.SIN.ToString() == comboBoxSinSearch.SelectedItem.ToString())
                        {
                            textBoxFirstName.Text = student.firstName;
                            textBoxLastName.Text = student.lastName;
                            textBoxSin.Text = student.SIN.ToString();
                            textBoxEmail.Text = student.Email;
                            comboBoxSchoolGrade.Text = student.highSchoolGrade.ToString();
                            comboBoxTestScore.Text = student.admissionTestScore.ToString();
                            groupBoxPrograms.Enabled = false;
                            studentList.Remove(student);
                            comboBoxSinSearch.Items.Remove(student.SIN);
                        }
                    }
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// To delete a record in the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeleteRecordClick(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxSinSearch.SelectedIndex == -1)
                {
                    throw new ArgumentNullException("Select a sin number from the drop list");
                }
                else
                {
                    for (int i = 0; i < studentList.Count; i++)
                    {
                        Student student = studentList[i];
                        if (student.SIN.ToString() == comboBoxSinSearch.SelectedItem.ToString())
                        {
                            studentList.RemoveAt(i);
                        }
                    }
                    UpdateGridView();
                }
            }
            catch (ArgumentNullException ex) 
            { 
                MessageBox.Show(ex.Message, "Error");
            }
        }

        /// <summary>
        /// To delete all records in the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeleteAllRecordClick(object sender, EventArgs e)
        {
            try
            {
                studentList.Clear();
                UpdateGridView();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// To load the records to server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLoadToServerClick(object sender, EventArgs e)
        {
            LoadRecordsToServer(studentList);
        }

        // Method to load records to server
        public static void LoadRecordsToServer(List<Student> students)
        {
            foreach (Student studentObj in students)
            {
                // Serialize the student object to JSON format
                string jsonString = JsonConvert.SerializeObject(studentObj, Formatting.Indented);

                // Write JSON to file (simulating server storage)
                File.AppendAllText("students.json", jsonString + Environment.NewLine);

                Console.WriteLine("Record Saved: " + jsonString);
            }
        }

        /// <summary>
        /// Method to refresh the grid view records
        /// </summary>
        internal void UpdateGridView()
        {
            dataGridViewRecord.Rows.Clear();
            comboBoxSinSearch.Items.Clear();
            ResetForm();
            foreach (var student in studentList)
            {
                dataGridViewRecord.Rows.Add(student.firstName, student.lastName, student.SIN, student.Email, student.highSchoolGrade, student.admissionTestScore, student.campusLocation, student.programName);
                comboBoxSinSearch.Items.Add(student.SIN);
            }
        }
        /// <summary>
        /// To Validate the student information
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        internal void ValidateStudentInfo()
        {
            if (textBoxFirstName.Text.Trim() == string.Empty)
            {
                throw new ArgumentNullException("Please enter your first name");
            }
            else if (textBoxLastName.Text.Trim() == string.Empty)
            {
                throw new ArgumentNullException("Please enter your first name");
            }
            else if (textBoxSin.Text.Trim() == string.Empty)
            {
                throw new ArgumentNullException("Please enter your SIN");
            }
            else if (!int.TryParse(textBoxSin.Text.Trim(), out sinNumber))
            {
                throw new InvalidCastException("Sin Number not an Interger");
            }
            else if (textBoxEmail.Text.Trim() == string.Empty)
            {
                throw new ArgumentNullException("Please enter your email address");
            }
            else if (comboBoxTestScore.Text.Trim() == string.Empty)
            {
                throw new ArgumentNullException("Please select a score");
            }
            else if (comboBoxSchoolGrade.Text.Trim() == string.Empty)
            {
                throw new ArgumentNullException("Please select a school grade");
            }
            else
            {
                groupBoxPrograms.Enabled = true;
                comboBoxPrograms.Enabled = false;
            }
        }
        /// <summary>
        /// A Method to validate the sin number of student
        /// </summary>
        /// <param name="sin"></param>
        /// <returns></returns>
        internal bool ValidateSin(int sin) 
        {
            bool retVal = false;
            foreach (var student in studentList) 
            { 
                if(student.SIN == sin)
                {
                    retVal = true;
                }
            }
            return retVal;
        }
        /// A method that reset the entire form
        internal void ResetForm()
        {
            textBoxFirstName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxSin.Text = string.Empty;
            comboBoxSchoolGrade.SelectedIndex = -1;
            comboBoxTestScore.SelectedIndex = -1;
            comboBoxLocation.SelectedIndex = -1;
            comboBoxPrograms.SelectedIndex = -1;
            labelCostValue.Text = "0";
            labelPeriodValue.Text = "0";
            groupBoxPrograms.Enabled = false;
        }
    }
}
