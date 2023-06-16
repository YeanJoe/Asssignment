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
    public partial class AddCoachingClassPage : Form
    {
        Trainer trainer;
        public AddCoachingClassPage(Trainer trainer)
        {
            InitializeComponent();
            this.trainer = trainer;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            TrainerDashboardPage trainerDashboardPage = new TrainerDashboardPage(trainer);
            trainerDashboardPage.Show();

            // Close Form1
            this.Close();
        }

        private void AddCoachingClassPage_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CoachingClass newCoachingClass = new CoachingClass(trainer);
            string schedule = cboDay.Text + " " + cboTime.Text;
            newCoachingClass.InsertRow(txtModule.Text, Convert.ToInt32(txtCharge.Text), schedule);
        }
    }
}
