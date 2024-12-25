// Name: Brendan Obilo
// Project name: DC Registration App
// Date: 19/11/2024
// 

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp
{
    internal class Campus
    {
        //Properties
        public int HSGradeReq { get; set; }
        public int admissionTSReq { get; set; }
        public int regFees { get; set; }
        public ArrayList listPrograms { get; set; }

        // Constructor to initialize the Campus object
        public Campus(int gradeReq, int testScoreReq, int fees)
        {
            HSGradeReq = gradeReq;
            admissionTSReq = testScoreReq;
            regFees = fees;
            listPrograms = new ArrayList();
        }

        // Method to add a program to the list of available programs
        public void AddProgram(Programs program)
        {
            listPrograms.Add(program);
        }
    }
}
