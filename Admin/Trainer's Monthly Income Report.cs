using System;
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
            //Open Connection to the database
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            //Query to find total number of trainers in the trainer table
            SqlCommand cmdTrainerID = new SqlCommand($"SELECT TrainerID FROM [TrainerModule] GROUP BY TrainerID", con);

            //Display all TrainerID into the TrainerID ComboBox
            using (SqlDataReader reader = cmdTrainerID.ExecuteReader())
            {
                while (reader.Read())
                {
                    cmbTrainerID.Items.Add(reader["TrainerID"].ToString());
                }
            }

            con.Close();
        }

        private void cmbTrainerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLevel.Clear();
            txtIncome.Clear();
            lstModules.Items.Clear();
            string TrainerID = cmbTrainerID.Text;

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmdLvl = new SqlCommand($"SELECT TOP 1 Level FROM [TrainerModule] WHERE TrainerID = '{TrainerID}'", con);
            txtLevel.Text = cmdLvl.ExecuteScalar().ToString();
            try
            {
                SqlCommand cmdModules = new SqlCommand($"SELECT ModuleName FROM [TrainerModule] WHERE TrainerID = '{TrainerID}'", con);
                using (SqlDataReader reader = cmdModules.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string Module = reader.GetString(0);
                        lstModules.Items.Add(Module);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The trainer has not been assigned to any module. Please assign the trainer to a module to view monthly report of the trainer.");
            }
            con.Close();

            double lvlBonus = 0;
            if (txtLevel.Text == "Beginner")
            {
                lvlBonus = 1.1;
            }
            else if (txtLevel.Text == "Intermediate")
            {
                lvlBonus = 1.4;
            }
            else if (txtLevel.Text == "Advance")
            {
                lvlBonus = 1.6;
            }
            
            float baseIncome = 0;

            int ModulesAssigned = lstModules.Items.Count;
            for (int i = 0; i < ModulesAssigned; i++)
            {
                foreach (var module in lstModules.Items)
                {
                    if (module.ToString() == "Python")
                    {
                        baseIncome = baseIncome + 1000;
                    }
                    else if (module.ToString() == "C++")
                    {
                        baseIncome = baseIncome + 1250;
                    }
                    else if (module.ToString() == "C#")
                    {
                        baseIncome = baseIncome + 1500;
                    }
                    else if (module.ToString() == "HTML")
                    {
                        baseIncome = baseIncome + 1100;
                    }
                }

                string TotalIncome = (baseIncome * lvlBonus).ToString();

                txtIncome.Text = TotalIncome;

            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            FormProvider.Admin.Show();
        }
    }
}
