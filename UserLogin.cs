using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Admin_
{
    public class UserLogin
    {
        public string UID;
        public string Password;

        public string GetUID()
        {
            return UID;
        }

        public UserLogin(string uid, string password)
        {
            this.UID = uid;
            this.Password = password;
        }

        public void login()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand($"SELECT COUNT(Role) FROM [User] WHERE Username ='{UID}' AND Password ='{Password}' GROUP BY Role", con);
            int count;
            object result = cmd.ExecuteScalar();
            if (int.TryParse(result.ToString(), out count))
            {
                if (count > 0)
                {
                    SqlCommand cmdRole = new SqlCommand($"SELECT Role FROM [User] WHERE Username = '{UID}' AND Password ='{Password}'", con);
                    string Role = Convert.ToString(cmdRole.ExecuteScalar());
                    if (Role == "Administrator")
                    {
                        SqlCommand cmdName = new SqlCommand($"SELECT FullName FROM [Admin] WHERE Username = '{UID}' AND Password = '{Password}'", con);
                        string name = Convert.ToString(cmdName.ExecuteScalar());
                        con.Close();
                        FormProvider.Login.Hide();
                        FormProvider.Admin.Show();
                    }
                    else
                    {
                        MessageBox.Show("You are a " + Role);
                    }
                }
            }
            
        }
    }
}
