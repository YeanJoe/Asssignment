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
    
    public partial class Profile : Form
    {
        public static string name = "";
        public Profile()
        {
            InitializeComponent();
        }

        public Profile(string n)
        {
            InitializeComponent();
            name = n;
        }
         private void btnBack_Click(object sender, EventArgs e)
         {
            frmHome home = new frmHome(name);
            home.Show();

            this.Hide();
         }

        private void Profile_Load(object sender, EventArgs e)
        {
            Student std = new Student(name);
            std.ViewPro(name);

            lblName.Text = std.Stdname;
            lblTPnumber.Text = std.Tpnum;
            lblContact.Text = std.PhoneNum;
            lblEmail.Text = std.Email;
            lblAddress.Text = std.Address;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            StudentUpdateProfile up = new StudentUpdateProfile(name);
            up.Show();

            this.Hide();
        }
    }
}
