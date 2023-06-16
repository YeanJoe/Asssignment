using Asssignment;
using Asssignment.Trainer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace APU_Programming_Cafe_Management_System
{
    public partial class TrainerFeedbackPage : Form
    {
        Trainer trainer;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public TrainerFeedbackPage(Trainer trainer)
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

        private void TrainerFeedbackPage_Load(object sender, EventArgs e)
        {
            //Insert the possile admin into the combo box from the administrator table
            List<string> adminlist = CoachingClass.GetAllAdminUsername();
            foreach (string FullName in adminlist)
            {
                cboAdmin.Items.Add(FullName);
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (cboAdmin.SelectedIndex >= 0 && txtFeedback.Text != "")
            {
                int adminID = GetAdminID(cboAdmin.Text);
                string trainerfeedback = txtFeedback.Text;
                con.Open();
                string cmdString = "INSERT INTO [TrainerFeedback] (AdminID, TrainerID, FeedbackMessage) ";
                cmdString += ("VALUES({0}, {1}, '{2}')");
                cmdString = string.Format(cmdString, adminID, trainer.TrainerID, txtFeedback.Text);
                SqlCommand cmd = new SqlCommand(cmdString, con);
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i != 0)
                {
                    MessageBox.Show("Feedback Submitted");
                }
                else
                {
                    MessageBox.Show("Failed to Insert");
                }
            }   
        }

        private int GetAdminID(string adminName)
        {
            int adminID = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT AdminID FROM [Admin] WHERE FullName = '" + adminName + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                adminID = rd.GetInt32(0);
            }
            con.Close();
            return adminID;
        }
    }
}
