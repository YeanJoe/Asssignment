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
    public partial class UpdateCoachClassPage : Form
    {
        Trainer trainer;
        public UpdateCoachClassPage(Trainer trainer)
        {
            InitializeComponent();
            this.trainer = trainer;
        }

        private void UpdateCoachClassPage_Load(object sender, EventArgs e)
        {
            List<int> classIDs = trainer.GetTrainerClassIDList();
            foreach(int classID in classIDs)
            {
                cmbBoxClass.Items.Add(classID);
            }

  
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            TrainerDashboardPage trainerDashboardPage = new TrainerDashboardPage(trainer);
            trainerDashboardPage.Show();

            this.Close();
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            if(cmbBoxClass.Text != "" && txtBoxModule.Text != "" && cboDay.Text != "" && cboTime.Text != "")
            {
                if(int.TryParse(txtBoxCharge.Text, out int charge))
                {
                    int classID = Convert.ToInt32(cmbBoxClass.Text);
                    int moduleID = Module.GetModuleID(txtBoxModule.Text);
                    string schedule = cboDay.Text + "," + cboTime.Text;
                    CoachingClass coachingClass = new CoachingClass(classID, moduleID, trainer.TrainerID, charge, schedule);
                    MessageBox.Show(coachingClass.UpdateRow(txtBoxModule.Text));

                }
                else
                {
                    MessageBox.Show("Syntax error in Charge textbox");
                }
            }
            else
            {
                MessageBox.Show("Some values are empty");
            }
        }


        private void cmbBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            int classID = Convert.ToInt32(cmbBoxClass.Text);
            CoachingClass coachingClass = new CoachingClass(classID);
            List<string> values = coachingClass.GetAllOtherColumnValues();

            txtBoxModule.Text = Module.GetModuleName(Convert.ToInt32(values[0]));
            txtBoxCharge.Text = values[1];
            string[] schedule = values[2].Split(',');
            cboDay.SelectedItem = schedule[0];
            cboTime.SelectedItem = schedule[1];

        }
    }
}
