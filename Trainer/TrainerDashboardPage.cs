using Asssignment.Trainer;
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
        Trainer trainer;
        public TrainerDashboardPage(Trainer trainer)
        {
            InitializeComponent();
            this.trainer = trainer;

        }

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            UpdateCoachClassPage updateCoachClassPage = new UpdateCoachClassPage(trainer);
            updateCoachClassPage.Show();

            // Hide Dashboard
            this.Hide();
        }

        private void BtnAddClass_Click(object sender, EventArgs e)
        {
            AddCoachingClassPage addCoachingClassPage = new AddCoachingClassPage(trainer);
            addCoachingClassPage.Show();

            // Hide Dashboard
            this.Hide();
        }

        private void BtnViewStudent_Click(object sender, EventArgs e)
        {
            ViewStudentsPage viewStudentsPage = new ViewStudentsPage(trainer);
            viewStudentsPage.Show();

            // Hide Dashboard
            this.Hide();
        }

        private void BtnFeedback_Click(object sender, EventArgs e)
        {
            TrainerFeedbackPage trainerFeedbackPage = new TrainerFeedbackPage(trainer);
            trainerFeedbackPage.Show();

            // Hide Dashboard
            this.Hide();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            TrainerUpdateProfilePage updateProfilePage = new TrainerUpdateProfilePage(trainer);
            updateProfilePage.Show();

            // Hide Dashboard
            this.Hide();
        }

        private void TrainerDashboardPage_Load(object sender, EventArgs e)
        {

        }
    }
}
