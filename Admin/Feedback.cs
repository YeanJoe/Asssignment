using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Asssignment.Trainer;

namespace Asssignment.Admin
{
    internal class Feedback
    {
        private int FeedbackID;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public int feedbackID
        {
            get { return FeedbackID; }
            set { FeedbackID = value; }
        }



        public List<string> GetFeedbackIDList(int TrainerID)
        {
            List<string> FeedbackIDs = new List<string>();

            con.Open();
            SqlCommand cmdFeedbackID = new SqlCommand($"SELECT FeedbackID FROM [TrainerFeedback] WHERE TrainerID = '{TrainerID}'", con);
            using (SqlDataReader reader = cmdFeedbackID.ExecuteReader())
            {
                while (reader.Read())
                {
                    FeedbackIDs.Add(reader["FeedbackID"].ToString());
                }
            }
            con.Close();
            return FeedbackIDs;
        }

        public string GetFeedbackMessage(int FeedbackID)
        {
            string message = null;
            con.Open();

            SqlCommand Feedback = new SqlCommand($"SELECT FeedbackMessage FROM [TrainerFeedback] WHERE FeedbackID = '{FeedbackID}'", con);
            message = Feedback.ExecuteScalar().ToString();
            con.Close();

            return message;
        }

    }
}
