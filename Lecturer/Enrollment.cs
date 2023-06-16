using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssignment.Lecturer
{
    internal class Enrollment
    {
        private int enrollmentID;
        private int studentID;
        private int classID;
        private string level;
        private string month;

        public int EnrollmentID
        {
            get { return enrollmentID; }
            set { enrollmentID = value; }
        }

        public int StudentID
        {
            get { return studentID; } 
            set { studentID = value; }
        }

        public int ClassID
        {
            get { return classID; }
            set { classID = value; }
        }

        public string Level
        {
            get { return level; }
            set { level = value; }
        }

        public string Month
        {
            get { return month; }
            set { month = value; }
        }

        public Enrollment()
        {

        }
    }
}
