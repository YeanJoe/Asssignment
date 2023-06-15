using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssignment.Admin
{
    internal class GetTrainerIDList
    {


        public ArrayList Refresh()
        {
            ArrayList TrainerID = new ArrayList();

            //Open Connection to the database
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString());
            con.Open();

            //Query to find total number of trainers in the trainer table
            SqlCommand cmdTrainerID = new SqlCommand($"SELECT TrainerId FROM [Trainer] GROUP BY TrainerId", con);

            //Display all TrainerID into the TrainerID ComboBox
            using (SqlDataReader reader = cmdTrainerID.ExecuteReader())
            {
                while (reader.Read())
                {
                    TrainerID.Add(reader["TrainerId"].ToString());
                }
            }
            TrainerID.Add("New Trainer");
            con.Close();
            return TrainerID;
        }
    }
}
