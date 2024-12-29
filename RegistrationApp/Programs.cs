// Name: Brendan Obilo
// Project name: DC Registration App
// Date: 19/11/2024
// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp
{
    internal class Programs
    {
        public string programName { get; set; }
        public decimal programFees { get; set; }
        public int programDuration { get; set; }

        // Constructor to initialize the Program object
        public Programs(string name, decimal fees, int duration)
        {
            programName = name;
            programFees = fees;
            programDuration = duration;
        }
    }
}
