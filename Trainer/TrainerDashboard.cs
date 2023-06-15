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
        public TrainerDashboardPage()
        {
            InitializeComponent();
        }

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            UpdateCoachClassPage updateCoachClassPage = new UpdateCoachClassPage();
            updateCoachClassPage.Show();

            // Close Form1
            this.Close();
        }

        private void BtnAddClass_Click(object sender, EventArgs e)
        {
            AddCoachingClassPage addCoachingClassPage = new AddCoachingClassPage();
            addCoachingClassPage.Show();

            // Close Form1
            this.Close();
        }

        private void BtnViewStudent_Click(object sender, EventArgs e)
        {
            ViewStudentsPage viewStudentsPage = new ViewStudentsPage();
            viewStudentsPage.Show();

            // Close Form1
            this.Close();
        }

        private void BtnFeedback_Click(object sender, EventArgs e)
        {
            TrainerFeedbackPage trainerFeedbackPage = new TrainerFeedbackPage();
            trainerFeedbackPage.Show();

            // Close Form1
            this.Close();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            UpdateProfilePage updateProfilePage = new UpdateProfilePage();
            updateProfilePage.Show();

            // Close Form1
            this.Close();
        }
    }
}
