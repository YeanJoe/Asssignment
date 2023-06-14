using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Asssignment.Lecturer
{
    public partial class Profile : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public Profile()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LecturerDashboard next = new LecturerDashboard();
            next.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            UpdateData(txtEmail.Text, txtNumber.Text);
        }

        private void UpdateData(string email , string contact)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE LecturerTable set Email=@Email, ContactNumber=@ContactNumber))", con);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@ContactNumber", contact);
            con.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }
    }
}
