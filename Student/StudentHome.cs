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
    public partial class frmHome : Form
    {
        public static string name = "";
        public frmHome()
        {
            InitializeComponent();
        }

        public frmHome(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            this.Hide();

            Request request = new Request(name);
            request.Show();
        }

        private void btnViewReq_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmViewReq view = new frmViewReq(name);
            view.Show();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            Student obj1 = new Student(name);
            lblWelcome.Text = "Welcome, " + name;
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();   

            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile pro = new Profile(name);
            pro.Show();

            this.Hide();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule(name);
            schedule.Show();

            this.Hide();
        }
    }
}
