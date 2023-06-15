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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string stat;
            User obj1 = new User(txtUsername.Text, txtPassword.Text);
            stat = obj1.Login(txtUsername.Text);
            if (stat != null)
            {
                MessageBox.Show(stat);
            }
            txtUsername.Text = "";
            txtPassword.Text = "";

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
