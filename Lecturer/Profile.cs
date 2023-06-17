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
        Lecturer lecturer;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public Profile(Lecturer lecturer)
        {
            InitializeComponent();
            this.lecturer = lecturer;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LecturerDashboard next = new LecturerDashboard(lecturer);
            next.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lecturer.UpdateProfile(txtName.Text, txtEmail.Text, txtNumber.Text, txtAddress.Text));
            LecturerDashboard next = new LecturerDashboard(lecturer);
            next.Show();
            this.Hide();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            txtID.Text = lecturer.LecturerID.ToString();
            txtName.Text = lecturer.FullName;
            txtEmail.Text = lecturer.Email;
            txtAddress.Text = lecturer.Address;
            txtNumber.Text = lecturer.ContactNumber;
        }
    }
}
