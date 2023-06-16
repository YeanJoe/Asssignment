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

            this.Close();
        }

        private void AddCoachingClassPage_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(txtModule.Text != "" && cboDay.SelectedIndex >=0 && cboTime.SelectedIndex >= 0)
            {
                if (int.TryParse(txtCharge.Text, out int charge))
                {
                    CoachingClass newCoachingClass = new CoachingClass(trainer);
                    string schedule = cboDay.Text + "," + cboTime.Text;
                    MessageBox.Show(newCoachingClass.InsertRow(txtModule.Text, charge, schedule));

            

                }
                else
                {
                    MessageBox.Show("Incorrect syntax on Charge section please enter an int");
                }
            }
            else
            {
                MessageBox.Show("Some values are empty");
            }
 
        }
    }
}
