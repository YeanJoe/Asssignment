using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asssignment.Trainer;


namespace Assignment_Admin_
{
    public partial class Trainer_s_Module_Assignment : Form
    {
        public string name;

        public Trainer_s_Module_Assignment(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void cmbTrainerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbClassID.Items.Clear();
            List<int> ClassID = new Trainer(Convert.ToInt32(cmbTrainerID.Text)).GetTrainerClassIDList();
            foreach (int classID in ClassID)
            {
                cmbClassID.Items.Add(classID);
            }
        }

        private void Trainer_s_Module_Assignment_Load(object sender, EventArgs e)
        {
            ArrayList TrainerID = new Trainer().GetAllTrainerID();
            foreach (string id in TrainerID)
            {
                cmbTrainerID.Items.Add(id);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Trainer ClassID = new Trainer();

            string OriLevel = ClassID.GetClassLevel(cmbClassID.Text);
            string OriModule = ClassID.GetClassModule(cmbClassID.Text);

            if (cmbLevel.SelectedItem != OriLevel || cmbModule.SelectedItem != OriModule)
            {
                CoachingClass newClass = new CoachingClass();
                newClass.ModuleID = Module.GetModuleID(cmbModule.Text);
                newClass.Level = cmbLevel.Text;
                if (cmbLevel.Text == "Beginner")
                {
                    newClass.Charges = 100;
                }
                else if (cmbLevel.Text == "Intermediate")
                {
                    newClass.Charges = 125;
                }
                else if (cmbLevel.Text == "Advance")
                {
                    newClass.Charges = 150;
                }
                newClass.TrainerID = Convert.ToInt32(cmbTrainerID.Text);
                newClass.Schedule = "";

                newClass.RemoveTrainerFromOriClass(cmbClassID.Text);

                MessageBox.Show(newClass.InsertRow());
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminHomePage adminHomePage = new AdminHomePage();
            adminHomePage.Show();
            this.Hide();
        }

        private void cmbClassID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Trainer ClassID = new Trainer();
            cmbLevel.SelectedItem = ClassID.GetClassLevel(cmbClassID.Text);
            cmbModule.SelectedItem = ClassID.GetClassModule(cmbClassID.Text);
        }


    }
}
