using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
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
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

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

    }
}
