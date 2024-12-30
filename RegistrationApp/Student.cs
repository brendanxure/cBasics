// Name: Kyle Hosein
// student id: 100720682
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
    public class Student
    {
        // Properties of the Student class
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int SIN { get; set; }
        public string Email { get; set; }
        public int highSchoolGrade { get; set; }
        public int admissionTestScore { get; set; }
        public string campusLocation { get; set; }
        public string programName { get; set; }

        // Parameterized constructor to initialize the properties
        public Student(string fName, string lName, int sin, string email, int hsGrade, int testScore, string location, string program)
        {
            firstName = fName;
            lastName = lName;
            SIN = sin;
            Email = email;
            highSchoolGrade = hsGrade;
            admissionTestScore = testScore;
            campusLocation = location;
            programName = program;
        }
    }
}
