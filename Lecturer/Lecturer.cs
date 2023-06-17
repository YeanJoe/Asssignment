using Asssignment.Trainer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Asssignment.Lecturer
{
    public class Lecturer
    {
        private int lecturerID;
        private int userID;
        private string fullName;
        private string email;
        private string contactNumer;
        private string address;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public int LecturerID
        {
            get { return lecturerID; }
            set { lecturerID = value; }
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

        public Lecturer(string username)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT UserID FROM [User] WHERE Username = '" + username + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                // Access the UserID column value
                userID = rd.GetInt32(0);
            }
            rd.Close();
            cmd = new SqlCommand("SELECT LecturerID, FullName, Email, ContactNumber, Address FROM [LecturerTable] WHERE UserID = " + userID, con);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                LecturerID = rd.GetInt32(0);
                FullName = rd.GetString(1);
                Email = rd.GetString(2);
                ContactNumber = rd.GetString(3);
                Address = rd.GetString(4);
            }
            con.Close();
        }

        public string UpdateProfile(string name, string email, string contactNumber, string address)
        {
            string stat = "Failed to Update Profile";
            con.Open();
            string commandString = "UPDATE [LecturerTable] SET UserID = {0}, FullName = '{1}', Email = '{2}', ContactNumber = '{3}', Address = '{4}' WHERE LecturerID = {5}";
            commandString = String.Format(commandString, userID, name, email, contactNumber, address, lecturerID);
            SqlCommand cmd = new SqlCommand(commandString, con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                stat = "Update Contact Info success!";
            }
            con.Close();
            return stat;
        }

        internal static string RegisterStudent(string username, string password, Student student)
        {
            string stat = "Failed to register Student";

            //Check if user already exist
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE Username = '" + username + "'", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            if (count == 0)
            {
                //insert to usertable
                con.Open();
                string cmdString = "INSERT INTO [User] (Username, Password, Role) ";
                cmdString += ("VALUES('{0}', '{1}', '{2}')");
                cmdString = string.Format(cmdString, username, password, "student");
                cmd = new SqlCommand(cmdString, con);
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i != 0)
                {
                    //Get the newly created userID from username
                    student.UserID = GetUserID(username);

                    //insert to studentTable
                    con.Open();
                    cmdString = "INSERT INTO [StudentTable] (UserID, FullName, Email, ContactNum, TPNumber, Address) ";
                    cmdString += ("VALUES({0}, '{1}', '{2}', '{3}', '{4}', '{5}')");
                    cmdString = string.Format(cmdString, student.UserID, student.Stdname, student.Email, student.PhoneNum, student.Tpnum, student.Address);
                    cmd = new SqlCommand(cmdString, con);
                    i = cmd.ExecuteNonQuery();
                    if (i != 0)
                    {
                        stat = "Student Registered!";
                    }
                    con.Close();
                }

            }
            else
            {
                stat = "Username already exists";
            }

            return stat;

        }



        public static int GetUserID(string username)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT UserID FROM [User] WHERE Username = '" + username + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            int userID = 0;
            while (rd.Read())
            {
                // Access the UserID column value
                userID = rd.GetInt32(0);
            }
            rd.Close();
            con.Close();
            return userID;
        }
    }
}
