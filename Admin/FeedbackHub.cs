using Asssignment.Admin;
using Asssignment.Trainer;
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

namespace Assignment_Admin_
{
    public partial class Feedback_HUB : Form
    {
        public string name;

        public Feedback_HUB(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void Feedback_HUB_Load(object sender, EventArgs e)
        {
            cmbTrainerID.Items.Clear();
            ArrayList TrainerID = new Trainer().GetAllTrainerID();
            foreach (string trainer in TrainerID)
            {
                cmbTrainerID.Items.Add(trainer);
            }
        }

        private void cmbTrainerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstFeedback.Items.Clear();
            List<string> FeedbackIDs = new Feedback().GetFeedbackIDList(Convert.ToInt32(cmbTrainerID.Text));
            foreach (string FeedbackID in FeedbackIDs)
            {
                lstFeedback.Items.Add(FeedbackID);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int FeedbackID = Convert.ToInt32(lstFeedback.GetItemText(lstFeedback.SelectedItem));
            string Message = new Feedback().GetFeedbackMessage(FeedbackID);
            MessageBox.Show(Message);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminHomePage dash = new AdminHomePage(name);
            dash.Show();
            this.Hide();
        }
    }
}
