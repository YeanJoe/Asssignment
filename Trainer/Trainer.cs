using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asssignment.Trainer
{
    public class Trainer
    {
        private int trainerID;
        private int userID;
        private string fullName;
        private string email;
        private string contactNumer;
        private string address;
        private string password;
        private string username;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public int TrainerID
        {
            get { return trainerID; }
            set { trainerID = value; }
        }

        public int UserID
        {
            get { return userID; }
            set { userID = value; }

        }
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }  
        }
        public string ContactNumber
        {
            get { return contactNumer; }
            set { contactNumer = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public Trainer(string username) 
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT  FROM [User] WHERE Username = '" + username + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                // Access the UserID column value
                userID = rd.GetInt32(0);
            }
            rd.Close();
            cmd = new SqlCommand("SELECT TrainerID, FullName, Email, ContactNumber, Address, Password, Username FROM [Trainer] WHERE UserID = " + userID, con);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                TrainerID = rd.GetInt32(0);
                FullName = rd.GetString(1);
                Email = rd.GetString(2);
                ContactNumber = rd.GetString(3);
                Address = rd.GetString(4);
                Password = rd.GetString(5);
                Username = rd.GetString(6);
                
            }
            con.Close();
        }

        public List<string> GetTrainerExistingModules()
        {
            con.Open();
            List<string> modules = new List<string>();

            //Get ModuleIDs where this trainer is teaching
            SqlCommand cmd = new SqlCommand("SELECT ModuleID FROM [CoachingClass] WHERE TrainerID = '" + TrainerID + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            List<int> moduleIDs = new List<int>();
            
            while(rd.Read())
            {
                int moduleID = rd.GetInt32(0);
                if(!moduleIDs.Contains(moduleID))
                {
                    moduleIDs.Add(moduleID);
                }
            }
            rd.Close();
            con.Close();
            if(moduleIDs.Count>0)
            {
                //Get the respective Module Names from the ModuleIDs
                modules = new List<string>();
                foreach (int moduleID in moduleIDs)
                {
                    Module module = new Module(moduleID);
                    string moduleName = module.ModuleName;
                    if(moduleName != "")
                    {
                        modules.Add(moduleName);
                    }

                }

            }
            con.Close();
            return modules;

        }

        public List<int> GetTrainerClassIDList(string moduleName)
        {
            List<int> classIDs = new List<int>();
            int moduleID = Module.GetModuleID(moduleName);
            if(moduleID != 0)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ClassID FROM [CoachingClass] WHERE TrainerID = '" + TrainerID + "' AND ModuleID = '" + moduleID + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    int classID = rd.GetInt32(0);
                    classIDs.Add(classID);
                }
                con.Close();
            }
            return classIDs;
        }

        public List<int> GetTrainerClassIDList()
        {
            List<int> classIDs = new List<int>();
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ClassID FROM [CoachingClass] WHERE TrainerID = '" + TrainerID + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    int classID = rd.GetInt32(0);
                    classIDs.Add(classID);
                }
                con.Close();

            return classIDs;
        }

        //Get student list which is being handled by trainer
        public List<string> GetTrainerStudentList (string moduleName)
        {
            //Get classes handled based on module
            List<int> classIDs = GetTrainerClassIDList(moduleName);
            List<int> studentIDs = new List<int>();
            
            //Get StudentIDs from the classes
            foreach(int classID in classIDs)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT StudentID FROM [Enrollment] WHERE ClassID = '" + classID + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    int studentID = rd.GetInt32(0);
                    studentIDs.Add(studentID);
                }
                rd.Close();
                con.Close();
            }

            //Get student names based on studentIDs
            List<string> studentNames = new List<string>();
            foreach (int studentID in studentIDs)
            {
                string studentName = GetValueFromTableWhere("StudentTable", "FullName", "StudentID", studentID);
                studentNames.Add(studentName);
            }

            return studentNames;
        }

        public string UpdateContactInfo(string email, string contactNumber)
        {
            this.email = email;
            this.contactNumer = contactNumber;
            string stat = "Failed to Update Contact Info";
            con.Open();
            string cmdString = "UPDATE [Trainer] SET Email = '{0}', ContactNumber = '{1}' WHERE TrainerID = {2} ";
            cmdString = string.Format(cmdString, email, contactNumber, trainerID);
            SqlCommand cmd = new SqlCommand(cmdString, con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                stat = "Update Contact Info success!";
            }
            con.Close();
            return stat;
        }

        //Searches the database in the specified tablename and column and returns a value
        //Accepts a string and returns an int
        private int GetValueFromTableWhere(string tableName, string selectColumn, string whereColumn, string whereColumnValue)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT " + selectColumn + " FROM [" + tableName + "] WHERE " + whereColumn + " = '" + whereColumnValue + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            int value = 0;
            while (rd.Read())
            {
                value = rd.GetInt32(0);

            }
            con.Close();
            return value;
        }

        //Overload function which accepts an int instead and returns a string
        private string GetValueFromTableWhere(string tableName, string selectColumn, string whereColumn, int whereColumnValue)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT " + selectColumn + " FROM [" + tableName + "] WHERE " + whereColumn + " = '" + whereColumnValue + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            string value = "";
            while (rd.Read())
            {
                value = rd.GetString(0);

            }
            con.Close();
            return value;
        }

        private int GetValueFromTableWhere(string tableName, string selectColumn, string whereColumn, int whereColumnValue, int returnType)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT " + selectColumn + " FROM [" + tableName + "] WHERE " + whereColumn + " = '" + whereColumnValue + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            int value = 0;
            while (rd.Read())
            {
                value = rd.GetInt32(0);

            }
            con.Close();
            return value;
        }

    }
}
