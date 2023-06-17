using Asssignment.Trainer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Asssignment.Lecturer
{
    internal class Enrollment
    {
        private int enrollmentID;
        private int studentID;
        private int classID;
        private string level;
        private string month;
        private List<int> studentList;
        private List<int> classList;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

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

        public List<int> StudentList
        { 
            get { return studentList; }
            set { studentList = value; }
        }
        
        public List<int> ClassList
        {
            get { return classList; }
            set { classList = value; }
        }

        public Enrollment(int studentID)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Enrollment] WHERE StudentID = '" + studentID + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                EnrollmentID = rd.GetInt32(0);
                StudentID = rd.GetInt32(1);
                ClassID = rd.GetInt32(2);
                Level = rd.GetString(3);
                Month= rd.GetString(4);
            }
            rd.Close();
            con.Close();
        }

        public Enrollment(int studentID, int classID)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Enrollment] WHERE StudentID = " + studentID + " AND ClassID = " + classID, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                EnrollmentID = rd.GetInt32(0);
                StudentID = rd.GetInt32(1);
                ClassID = rd.GetInt32(2);
                Level = rd.GetString(3);
                Month = rd.GetString(4);
            }
            rd.Close();
            con.Close();
        }

        public Enrollment()
        {

        }

        public List<int> GetClassIDsByStudent()
        {
            List<int> classIDs = new List<int>();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ClassID FROM [Enrollment] WHERE StudentID = '" + studentID + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                classIDs.Add(rd.GetInt32(0));

            }
            rd.Close();
            con.Close();
            return classIDs;
        }



        public static string InsertRow(string moduleName, string level, string username, string enrollmentMonth)
        {
            string stat = "Failed to Enroll Student";
            int classID = 0;
            int moduleID = Module.GetModuleID(moduleName);
            if (moduleID != 0)
            {
                classID = GetClassIDFromCoachingClassByModuleAndLevel(moduleID, level);
                //Check if classID is 0, if it is then the class doesnt exist
                if (classID == 0)
                {
                    //create class without the trainerID
                    CreateClassWithoutTrainer(moduleID, level);

                    //get the classID of the class that was just created
                    classID = GetClassIDFromCoachingClassByModuleAndLevel(moduleID, level);
                }
                //Get StudentID from username
                Student student = new Student(username);
                int studentID = student.StdID;

                

                con.Open();
                string cmdString = "INSERT INTO [Enrollment] (StudentID, ClassID, Level, Month) ";
                cmdString += ("VALUES({0}, {1}, '{2}', '{3}')");
                cmdString = string.Format(cmdString, studentID, classID, level, enrollmentMonth);
                SqlCommand cmd = new SqlCommand(cmdString, con);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    stat = "Insert table row success!";
                }
                con.Close();
                MessageBox.Show(stat);
            }
            return stat;

        }

        public string UpdateRow(string moduleName, string level)
        {
            int moduleID = Module.GetModuleID(moduleName);

            //Gets the class with the matching module and level
            int classID = GetClassIDFromCoachingClassByModuleAndLevel(moduleID, level);
            if(classID == 0)
            {
                CreateClassWithoutTrainer(moduleID, level);
                classID = GetClassIDFromCoachingClassByModuleAndLevel(moduleID, level);
            }

            string stat = "Update failed";
            con.Open();
            string cmdString = "UPDATE [Enrollment] SET ClassID = {0}, Level = '{1}', Month = '{2}' WHERE StudentID = {3} ";
            cmdString = string.Format(cmdString, classID, level, Month, studentID);
            SqlCommand cmd = new SqlCommand(cmdString, con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                stat = "Update success!";
            }
            con.Close();
            return stat;

        }

        public void GetStudentsCompletedClasses()
        {
            studentList = new List<int>();
            classList = new List<int>();
            string currentMonth = DateTime.Now.ToString("MMMM", CultureInfo.InvariantCulture);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Month, StudentID, ClassID FROM Enrollment", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                //Check if 3 months has passed from the enrollment month if it has then add the student and its classID to the list
                //Turn the Month column value like "March" to number 3
                int monthNumber = DateTime.ParseExact(rd.GetString(0), "MMMM", CultureInfo.InvariantCulture).Month;
                if(DateTime.Now.Month - monthNumber >= 3)
                {
                    studentList.Add(rd.GetInt32(1));
                    classList.Add(rd.GetInt32(2));
                }
                
            }
            con.Close();
            rd.Close();
        }


        public string DeleteRow()
        {
            string stat = "Delete failed";
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM [Enrollment] WHERE EnrollmentID = " + EnrollmentID, con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                stat = "Delete success!";
            }
            con.Close();
            return stat;
        }

        private static void CreateClassWithoutTrainer(int moduleID, string level)
        {
            //create class without the trainerID
            CoachingClass newCoachingClass = new CoachingClass();
            newCoachingClass.ModuleID = moduleID;
            newCoachingClass.Level = level;
            newCoachingClass.Charges = 100;
            newCoachingClass.InsertRow();
        }

        private static int GetClassIDFromCoachingClassByModuleAndLevel(int moduleID, string level)
        {
            con.Open();
            int classID = 0;    
            SqlCommand cmd = new SqlCommand("SELECT ClassID FROM [CoachingClass] WHERE ModuleID = " + moduleID + " AND Level = '" + level + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                classID = rd.GetInt32(0);
            }
            con.Close();
            return classID;
        }

            
        
    }
}
