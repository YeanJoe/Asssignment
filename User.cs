using Asssignment.Lecturer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asssignment
{
    internal class User
    {
        private string username;
        private string password;
        private string role;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public User(string aUsername, string aPassword)
        {
            username = aUsername;
            password = aPassword;
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public string Login(string username)
        {
            string status = null;
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE Username = @Username AND Password = @Password", con);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("SELECT Role FROM [User] WHERE Username = @Username AND Password = @Password", con);
                cmd2.Parameters.AddWithValue("@Username", username);
                cmd2.Parameters.AddWithValue("@Password", password);
                string userRole = cmd2.ExecuteScalar().ToString();

                if (userRole == "student")
                {
                    frmHome studentHome = new frmHome(username);
                    studentHome.Show();
                }
                else if (userRole == "lecturer")
                {
                    LecturerDashboard lecturerDashboard = new LecturerDashboard(username);
                    lecturerDashboard.Show();
                }
                else if (userRole == "Administrator")
                {
                    LecturerDashboard lecturerDashboard = new LecturerDashboard(username);
                    lecturerDashboard.Show();
                }
                else if (userRole == "trainer")
                {
                    LecturerDashboard lecturerDashboard = new LecturerDashboard(username);
                    lecturerDashboard.Show();
                }

            }
            else
            {
                status = "Incorrect username/password";
            }

            con.Close();
            return status;
        }

    }


}
