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
        //Fields
        private string TrainerID;
        private string UID;
        private string Username;
        private string Password;
        private string Name;
        private string Email;
        private string PhoneNumber;
        private string Address;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string trainerID
        {
            get {  return TrainerID; }
            set { TrainerID = value; }
        }
        public string uid
        {
            get { return UID; }
            set { UID = value; }
        }
        public string username
        {
            get { return Username; }
            set { Username = value; }
        }
        public string password
        {
            get { return Password; }
            set { Password = value; }
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string email
        {
            get { return Email; }
            set { Email = value; }
        }
        public string phoneNumber
        {
            get { return PhoneNumber; }
            set { PhoneNumber = value; }
        }
        public string address
        {
            get { return Address; }
            set { Address = value; }
        }

        //CONSTRUCTORS

        //Parameterless
        public Admin()
        {

        }

        public Admin(string _uid, string _username, string _password)
        {
            this.UID = _uid;
            this.Username = _username;
            this.Password = _password;
        }

        //for Register
        public Admin(string _username, string _password, string _name, string _email, string _phoneNumber, string _address)
        {
            this.Username = _username;
            this.Password = _password;
            this.Name = _name;
            this.Email = _email;
            this.PhoneNumber = _phoneNumber;
            this.Address = _address;
        }


        public void ReadTrainerPro(string _trainerID)
        {
            con.Open();
            SqlCommand cmdReadTrainer = new SqlCommand($"SELECT * FROM [Trainer] WHERE TrainerId = '{_trainerID}'", con);
            using (SqlDataReader reader = cmdReadTrainer.ExecuteReader())
            {
                while (reader.Read())
                {
                    UID = reader["UserId"].ToString();
                    Username = reader["Username"].ToString();
                    Name = reader["FullName"].ToString();
                    Email = reader["Email"].ToString();
                    PhoneNumber = reader["ContactNumber"].ToString();
                    Address = reader["Address"].ToString();
                    Password = reader["Password"].ToString();
                }
            }
            con.Close();
        }

        public void RegisterTrainer()
        {
            /*string _username = this.Username;
            string _password = this.Password;
            string _name = this.Name;
            string _email = this.Email;
            string _phoneNumber = this.PhoneNumber;
            string _address = this.Address;*/

            con.Open();

            SqlCommand cmdInsertIntoUser = new SqlCommand("INSERT  INTO [User] (Username, Password, Role) VALUES (@username, @password, 'trainer')", con);
            cmdInsertIntoUser.Parameters.AddWithValue("@username", Username);
            cmdInsertIntoUser.Parameters.AddWithValue("@password", Password);
            cmdInsertIntoUser.ExecuteNonQuery();

            SqlCommand cmdUID = new SqlCommand($"SELECT UserID FROM [User] WHERE Username = '{Username}' AND Password = '{Password}'", con);
            string UID = cmdUID.ExecuteScalar().ToString();

            SqlCommand cmdInsertIntoTrainer = new SqlCommand($"INSERT INTO [Trainer] (UserId, FullName, Email, ContactNumber, Address, Password, Username) Values(@uid, @name, @email, @number, @address, @password, @username)", con);
            cmdInsertIntoTrainer.Parameters.AddWithValue("@uid", UID);
            cmdInsertIntoTrainer.Parameters.AddWithValue("@name", Name);
            cmdInsertIntoTrainer.Parameters.AddWithValue("@email", Email);
            cmdInsertIntoTrainer.Parameters.AddWithValue("@number", PhoneNumber);
            cmdInsertIntoTrainer.Parameters.AddWithValue("@address", Address);
            cmdInsertIntoTrainer.Parameters.AddWithValue("@password", Password);
            cmdInsertIntoTrainer.Parameters.AddWithValue("@username", Username);
            cmdInsertIntoTrainer.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Trainer Registered!");
        }

        public void DeleteTrainer()
        {
            string _uid = this.UID;
            string _username = this.Username;
            string _password = this.Password;

            con.Open();
            SqlCommand cmdDeleteFromUser = new SqlCommand($"DELETE FROM [User] WHERE UserID = '{_uid}' AND Username = '{_username}' AND Password = '{_password}'", con);
            cmdDeleteFromUser.ExecuteNonQuery();
            SqlCommand cmdDeleteFromTrainer = new SqlCommand($"DELETE FROM [Trainer] WHERE UserId = '{_uid}' AND Password = '{_password}'", con);
            cmdDeleteFromTrainer.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Trainer Deleted");

        }

        public ArrayList Refresh()
        {
            ArrayList TrainerID = new ArrayList();

            //Open Connection to the database
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
