using System;
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

namespace Assignment_Admin_
{
    public partial class Feedback_HUB : Form
    {
        public Feedback_HUB()
        {
            InitializeComponent();
        }

        private void Feedback_HUB_Load(object sender, EventArgs e)
        {
            //Open Connection to the database
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()) ;
            con.Open();

            //Query to find total number of trainers in the trainer table
            SqlCommand cmdTrainerID = new SqlCommand($"SELECT TrainerID FROM [TrainerFeedback] GROUP BY TrainerID", con);

            //Display all TrainerID into the TrainerID ComboBox
            using (SqlDataReader reader = cmdTrainerID.ExecuteReader())
            {
                while (reader.Read())
                {
                    cmbTrainerID.Items.Add(reader["TrainerID"].ToString());
                }
            }
        }

        private void cmbTrainerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstFeedback.Items.Clear();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            string TrainerID = cmbTrainerID.Text;
            SqlCommand cmdFeedbackID = new SqlCommand($"SELECT FeedbackID FROM [TrainerFeedback] WHERE TrainerID = '{TrainerID}'", con);
            using (SqlDataReader reader = cmdFeedbackID.ExecuteReader())
            {
                while (reader.Read())
                {
                    lstFeedback.Items.Add(reader["FeedbackID"].ToString());
                }
            }
            con.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string FeedbackID = lstFeedback.SelectedItem.ToString();
            string TrainerID = cmbTrainerID.Text;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdViewFeedback = new SqlCommand($"SELECT FeedbackMessage FROM [TrainerFeedback] WHERE TrainerID = '{TrainerID}' AND FeedbackID = '{FeedbackID}'", con);
            string Message = cmdViewFeedback.ExecuteScalar().ToString();
            MessageBox.Show(Message);


        }
    }
}
