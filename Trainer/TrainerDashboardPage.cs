using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU_Programming_Cafe_Management_System
{
    public partial class TrainerDashboardPage : Form
    {
        string username;
        public TrainerDashboardPage(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            UpdateCoachClassPage updateCoachClassPage = new UpdateCoachClassPage(username);
            updateCoachClassPage.Show();

            // Close Form1
            this.Close();
        }

        private void BtnAddClass_Click(object sender, EventArgs e)
        {
            AddCoachingClassPage addCoachingClassPage = new AddCoachingClassPage(username);
            addCoachingClassPage.Show();

            // Close Form1
            this.Close();
        }

        private void BtnViewStudent_Click(object sender, EventArgs e)
        {
            ViewStudentsPage viewStudentsPage = new ViewStudentsPage(username);
            viewStudentsPage.Show();

            // Close Form1
            this.Close();
        }

        private void BtnFeedback_Click(object sender, EventArgs e)
        {
            TrainerFeedbackPage trainerFeedbackPage = new TrainerFeedbackPage(username);
            trainerFeedbackPage.Show();

            // Close Form1
            this.Close();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            TrainerUpdateProfilePage updateProfilePage = new TrainerUpdateProfilePage(username);
            updateProfilePage.Show();

            // Close Form1
            this.Close();
        }

        private void TrainerDashboardPage_Load(object sender, EventArgs e)
        {

        }
    }
}
