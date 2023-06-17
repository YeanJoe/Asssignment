using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asssignment.Admin
{
    internal class Admin
    {
        private string adminID;
        private string userID;
        private string fullName;
        private string email;
        private string contactNumber;
        private string address;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string AdminID
        {
            get { return adminID; }
            set { adminID = value; }
        }
        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public string Fullname
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        public Admin()
        {

        }

        public Admin(string _name)
        {
            this.fullName = _name;
        }

        public Admin(string _email, string _contactNumber, string _address)
        {
            this.email = _email;
            this.contactNumber = _contactNumber;
            this.address = _address;
        }


        public void GetAdminProfile()
        {
            con.Open();

            SqlCommand cmdProfile = new SqlCommand($"SELECT Email, ContactNumber, Address FROM [Admin] WHERE Fullname = '{fullName}'", con);
            using (SqlDataReader reader = cmdProfile.ExecuteReader())
            {
                email = reader.GetString(0);
                contactNumber = reader["ContactNumber"].ToString();
                address = reader["Address"].ToString();
            }
            con.Close();
        }

        public void UpdateAdminProfile()
        {
            con.Open();

            SqlCommand cmdUpdate = new SqlCommand($"UPDATE [Admin] SET Email = '{email}', ContactNumber = '{contactNumber}', Address = '{address}' WHERE AdminID = '{adminID}'", con);
            cmdUpdate.ExecuteNonQuery();
            con.Close();
        }
    }
}
