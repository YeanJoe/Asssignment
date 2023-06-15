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
            /*SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =| DataDirectory |\\Database1.mdf; Integrated Security = True; Connect Timeout = 30");
            con.Open();
            SqlCommand cmdName = new SqlCommand("", con);*/
            // string UID = UserLogin.GetUID();  Cannot access GetUID method from UID
            // I want to get the UID and Password from the UserLogin class in order to run a query
            // To search for the name of the user and show it on the label
            // I have the FormProvider class to show and hide the AdminHomePage but I can't pass the name into it
            lblHomeTitle.Text = "Welcome, " + name;
        }

        private void btnTrainerRaD_Click(object sender, EventArgs e)
        {
            Trainer_Register_and_Delete t = new Trainer_Register_and_Delete();
            FormProvider.Admin.Hide();
            t.ShowDialog();
        }

        private void btnTrainerModule_Click(object sender, EventArgs e)
        {
            Trainer_s_Module_Assignment t = new Trainer_s_Module_Assignment();
            FormProvider.Admin.Hide();
            t.ShowDialog();
        }

        private void btnTrainerIncome_Click(object sender, EventArgs e)
        {
            Trainer_s_Monthly_Income_Report t = new Trainer_s_Monthly_Income_Report();
            FormProvider.Admin.Hide();
            t.ShowDialog();
        }

        private void btnFeedbackHub_Click(object sender, EventArgs e)
        {
            Feedback_HUB t = new Feedback_HUB();
            FormProvider.Admin.Hide();
            t.ShowDialog();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
