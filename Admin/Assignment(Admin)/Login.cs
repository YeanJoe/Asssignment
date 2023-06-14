using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Admin_
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            UserLogin user = new UserLogin(txtUserID.Text.ToString(), txtPassword.Text.ToString());
            user.login();

            /*using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                string query = $"SELECT Role FROM [User] WHERE Username = '{txtUserID.Text.ToString()}' AND '{txtPassword.Text.ToString()}'" ;
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                txtPassword.Text = cmd.ExecuteScalar().ToString();
                conn.Close();
            }*/
            
            /*SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Wong Wei Xiang\\OneDrive - Asia Pacific University\\Documents\\Year 1 Sem2\\IOOP\\Assignment\\Assignment(Admin)\\Database1.mdf\";Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT FROM [User]");
            SqlDataReader reader = cmd.ExecuteReader();
            txtPassword.Text = reader.GetString(2);*/
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }   
    }
}
