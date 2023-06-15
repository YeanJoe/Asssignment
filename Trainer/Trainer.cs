using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asssignment.Trainer
{
    public class Trainer
    {
        private string trainerID;
        private string userID;
        private string fullName;
        private string email;
        private string contactNumer;
        private string address;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string TrainerID
        {
            get { return trainerID; }
            set { trainerID = value; }
        }

        public string UserID
        {
            get { return userID; }
            set { userID = value; }

        }
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }  
        }
        public string ContactNumer
        {
            get { return contactNumer; }
            set { contactNumer = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public Trainer() 
        {
            
        }

        public List<string> GetExistingModules()
        {
            SqlCommand cmd = new SqlCommand("SELECT ModuleName ", con);

        }
        {
            con.Open();
            string cmdString = "SELECT * FROM" + tableName + "WHERE ";
            
            for(int i = 0; i<values.Count; i++)
            {
                cmdString += variables[i] + "= '" + values[i] + "', ";
            }
                
                
                
            SqlDataReader rd = cmd.ExecuteReader();
            con.Close();

            return rd;

        }
    }
}
