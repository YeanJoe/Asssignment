using Asssignment.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Admin_
{
    public partial class AdminHomePage : Form
    {
        public static string name;
        public AdminHomePage(string n)
        {
            InitializeComponent();
            name = n;
        }

        public AdminHomePage() 
        {
            InitializeComponent();
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {
            lblHomeTitle.Text = "Welcome, " + name;
        }

        private void btnTrainerRaD_Click(object sender, EventArgs e)
        {
            Trainer_Register_and_Delete t = new Trainer_Register_and_Delete(name);
            t.Show();
            this.Hide();
        }

        private void btnTrainerModule_Click(object sender, EventArgs e)
        {
            Trainer_s_Module_Assignment t = new Trainer_s_Module_Assignment(name);
            t.Show();
            this.Hide();
        }

        private void btnTrainerIncome_Click(object sender, EventArgs e)
        {
            Trainer_s_Monthly_Income_Report t = new Trainer_s_Monthly_Income_Report(name);
            t.Show(); 
            this.Hide();
        }

        private void btnFeedbackHub_Click(object sender, EventArgs e)
        {
            Feedback_HUB t = new Feedback_HUB(name);
            t.Show();
            this.Hide();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            AdminProfile t = new AdminProfile(name);
            t.Show();
            this.Hide();
        }
    }
}
