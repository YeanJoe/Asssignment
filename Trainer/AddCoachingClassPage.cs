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
            if(txtModule.Text != "" && cboLevel.SelectedIndex >= 0 && cboDay.SelectedIndex >= 0 && cboTime.SelectedIndex >= 0)
            {
                if (int.TryParse(txtCharge.Text, out int charge))
                {
                    if(Module.GetModuleID(txtModule.Text) == 0)
                    {
                        Module module = new Module(txtModule.Text);
                        module.InsertRow();
                    }
                    int moduleID = Module.GetModuleID(txtModule.Text);
                    CoachingClass newCoachingClass = new CoachingClass(trainer);
                    string schedule = cboDay.Text + "," + cboTime.Text;
                    newCoachingClass.ModuleID = moduleID;
                    newCoachingClass.Level = cboLevel.SelectedItem.ToString();
                    newCoachingClass.Charges = charge;
                    newCoachingClass.Schedule = schedule;
                    MessageBox.Show(newCoachingClass.InsertRow());

            

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
