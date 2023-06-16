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
    public partial class TrainerUpdateProfilePage : Form
    {
        Trainer trainer;
        
        public TrainerUpdateProfilePage(Trainer trainer)
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



        private void UpdateProfilePage_Load(object sender, EventArgs e)
        {
            txtEmail.Text = trainer.Email;
            txtContactNumber.Text = trainer.ContactNumber;
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text != "")
            {
                if(int.TryParse(txtContactNumber.Text, out int contactNumber))
                {
                    MessageBox.Show(trainer.UpdateContactInfo(txtEmail.Text, txtContactNumber.Text));
                }
                else
                {
                    MessageBox.Show("Please enter a valid contact number");
                }
            }
            else
            {
                MessageBox.Show("Please fill up the textBoxes");
            }
        }
    }
}
