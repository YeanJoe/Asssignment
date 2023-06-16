using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asssignment
{
    public partial class StudentUpdateProfile : Form
    {
        public static string name = "";
        public StudentUpdateProfile()
        {
            InitializeComponent();
        }
        public StudentUpdateProfile(string n)
        {
            InitializeComponent();
            name = n;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student std = new Student(name);
            MessageBox.Show(std.Update(txtEmail.Text, txtContact.Text, txtAddress.Text));
            
            frmHome home = new frmHome(name);
            home.Show();

            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Profile pro = new Profile(name);
            pro.Show();

            this.Hide();
        }


    }
}
