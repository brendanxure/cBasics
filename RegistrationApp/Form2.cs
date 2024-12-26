// Name: Brendan Obilo
// Project name: DC Registration App
// Date: 19/11/2024
// 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationApp
{
    public partial class Form2 : Form
    {
        // Declared variables
        private string displayDetails;
        public Form2()
        {
            InitializeComponent();
        }
        // Properties of the display on the form
        protected internal string DisplayDetails { get => displayDetails; set { displayDetails = value; } }
        private void ButtonExitHelpClick(object sender, EventArgs e)
        {
            this.Close();
        }

        // Shows details at run time
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            labelDetails.Text = DisplayDetails;
        }
    }
}
