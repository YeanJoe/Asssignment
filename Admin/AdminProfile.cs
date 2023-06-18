using Assignment_Admin_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asssignment.Admin
{
    public partial class AdminProfile : Form
    {
        public string name;
        
        public AdminProfile(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {
            Admin admin = new Admin(this.name);
            admin.GetAdminProfile();
            txtEmail.Text = admin.Email;
            txtContactNumber.Text = admin.ContactNumber;
            txtAddress.Text = admin.Address;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(txtEmail.Text, txtContactNumber.Text, txtAddress.Text);
            admin.UpdateAdminProfile();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminHomePage adminHomePage = new AdminHomePage();
            adminHomePage.Show();
            this.Hide();
        }
    }
}
