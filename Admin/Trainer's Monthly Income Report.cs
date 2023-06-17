using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asssignment.Trainer;

namespace Assignment_Admin_
{
    public partial class Trainer_s_Monthly_Income_Report : Form
    {
        public Trainer_s_Monthly_Income_Report()
        {
            InitializeComponent();
        }

        private void Trainer_s_Monthly_Income_Report_Load(object sender, EventArgs e)
        {
            Trainer trainers = new Trainer();
            ArrayList ids = trainers.GetAllTrainerID();
            foreach (string id in ids)
            {
                cmbTrainerID.Items.Add(id);
            }
            
        }

        private void cmbTrainerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIncome.Clear();
            lstModules.Items.Clear();
            lstClassID.Items.Clear();
            lstLevel.Items.Clear();
            int TrainerID = Convert.ToInt32(cmbTrainerID.Text);

            
            double TotalIncome = 0;

            Trainer trainer = new Trainer(TrainerID);
            List<int> classes = trainer.GetTrainerClassIDList();
            foreach (int classID in classes)
            {
                double basePay = 0;
                double bonus = 0;
                lstClassID.Items.Add(classID);

                string module = trainer.GetClassModule(classID.ToString());
                lstModules.Items.Add(module);
                string level = trainer.GetClassLevel(classID.ToString());
                lstLevel.Items.Add(level);

                if (module == "C#") { basePay = 1000; }
                else if (module == "Database") { basePay = 1100; }
                else if (module == "Java") { basePay = 1200; }
                else if (module == "Python") { basePay = 1250; }

                if (level == "Beginner") { bonus = 1.1; }
                else if (level == "Intermediate") { bonus = 1.25; }
                else if (level == "Advance") { bonus = 1.4; }

                TotalIncome = TotalIncome + (basePay * bonus);
            }

            txtIncome.Text = TotalIncome.ToString();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            AdminHomePage adminHomePage = new AdminHomePage();
            adminHomePage.Show();
            this.Hide();
            
        }

    }
}
