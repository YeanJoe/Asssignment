using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Security.Cryptography;
using System.Configuration;
using Asssignment.Admin;

namespace Assignment_Admin_
{
    public partial class Trainer_Register_and_Delete : Form
    {
        public Trainer_Register_and_Delete()
        {
            InitializeComponent();
        }

        private void Trainer_Register_and_Delete_Load(object sender, EventArgs e)
        {
            cmbTrainerID.Items.Clear();
            GetTrainerIDList ID = new GetTrainerIDList();
            foreach (var id in ID.Refresh())
            {
                cmbTrainerID.Items.Add(id.ToString());
            }
        }

        private void cmbTrainerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTrainerID.Text != "New Trainer")
            {
                txtUserID.Enabled = false;
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                txtName.Enabled = false;
                txtEmail.Enabled = false;
                txtContactNumber.Enabled = false;
                txtAddress.Enabled = false;

                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString());
                con.Open();
                int TrainerID = int.Parse(cmbTrainerID.Text);

                SqlCommand cmdTrainerUID = new SqlCommand($"SELECT UserId FROM [Trainer] WHERE TrainerId = '{TrainerID}'", con);
                txtUserID.Text = cmdTrainerUID.ExecuteScalar().ToString();

                string UID = txtUserID.Text;
                SqlCommand cmdUsername = new SqlCommand($"SELECT Username FROM [User] WHERE UserID = '{UID}'", con);
                txtUsername.Text = cmdUsername.ExecuteScalar().ToString();

                SqlCommand cmdPassword = new SqlCommand($"SELECT Password FROM [User] WHERE UserID = '{UID}'", con);
                txtPassword.Text = cmdPassword.ExecuteScalar().ToString();

                SqlCommand cmdName = new SqlCommand($"SELECT FullName FROM [Trainer] WHERE TrainerID = '{TrainerID}'", con);
                txtName.Text = cmdName.ExecuteScalar().ToString();

                SqlCommand cmdTrainerEmail = new SqlCommand($"SELECT Email FROM [Trainer] WHERE TrainerID = '{TrainerID}'", con);
                txtEmail.Text = cmdTrainerEmail.ExecuteScalar().ToString();

                SqlCommand cmdTrainerCN = new SqlCommand($"SELECT ContactNumber FROM [Trainer] WHERE TrainerID = '{TrainerID}'", con);
                txtContactNumber.Text = cmdTrainerCN.ExecuteScalar().ToString();

                SqlCommand cmdTrainerAddress = new SqlCommand($"SELECT Address FROM [Trainer] WHERE TrainerID = '{TrainerID}'", con);
                txtAddress.Text = cmdTrainerAddress.ExecuteScalar().ToString();
                con.Close();
            }
            else if (cmbTrainerID.Text == "New Trainer")
            {
                txtUserID.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
                txtName.Clear();
                txtEmail.Clear();
                txtContactNumber.Clear();
                txtAddress.Clear();

                txtUserID.Enabled = false;
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
                txtName.Enabled = true;
                txtEmail.Enabled = true;
                txtContactNumber.Enabled = true;
                txtAddress.Enabled = true;
            }
        
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

                try
                {
                    using (SqlCommand cmdInsertTrainer = new SqlCommand($"INSERT INTO [User] VALUES (@Username,@Password,@Role)", con))
                    {
                        cmdInsertTrainer.Parameters.Add("@Username", SqlDbType.NVarChar).Value = "34";
                        cmdInsertTrainer.Parameters.Add("@Password", SqlDbType.NVarChar).Value = "34";
                        cmdInsertTrainer.Parameters.Add("@Role", SqlDbType.NVarChar).Value = "Trainer";
                        int test = cmdInsertTrainer.ExecuteNonQuery();
                        if (test > 0) { MessageBox.Show("Yes"); }
                        else { MessageBox.Show("No"); }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }*/
            if (cmbTrainerID.Text == "New Trainer")
            {
                string Username = txtUsername.Text;
                string Password = txtPassword.Text;
                string Name = txtName.Text;
                string Email = txtEmail.Text;
                string Contact = txtContactNumber.Text;
                string Address = txtAddress.Text;

                if (Username != "" && Password != "" && Name != "" && Email != "" && Contact != "" && Address != "")
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString());
                    con.Open();

                    SqlCommand cmdInsertIntoUser = new SqlCommand("INSERT  INTO [User] (Username, Password, Role) VALUES (@username, @password, 'trainer')", con);
                    cmdInsertIntoUser.Parameters.AddWithValue("@username", Username);
                    cmdInsertIntoUser.Parameters.AddWithValue("@password", Password);
                    cmdInsertIntoUser.ExecuteNonQuery();

                    SqlCommand cmdUID = new SqlCommand($"SELECT UserID FROM [User] WHERE Username = '{Username}' AND Password = '{Password}'", con);
                    string UID = cmdUID.ExecuteScalar().ToString();

                    SqlCommand cmdInsertIntoTrainer = new SqlCommand($"INSERT INTO [Trainer] (UserId, FullName, Email, ContactNumber, Address, Password) Values(@uid, @name, @email, @number, @address, @password)", con);
                    cmdInsertIntoTrainer.Parameters.AddWithValue("@uid", UID);
                    cmdInsertIntoTrainer.Parameters.AddWithValue("@name", Name);
                    cmdInsertIntoTrainer.Parameters.AddWithValue("@email", Email);
                    cmdInsertIntoTrainer.Parameters.AddWithValue("@number", Contact);
                    cmdInsertIntoTrainer.Parameters.AddWithValue("@address", Address);
                    cmdInsertIntoTrainer.Parameters.AddWithValue("@password", Password);
                    cmdInsertIntoTrainer.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Trainer Registered!");

                    cmbTrainerID.Items.Clear();
                    GetTrainerIDList ID = new GetTrainerIDList();
                    foreach (var id in ID.Refresh())
                    {
                        cmbTrainerID.Items.Add(id.ToString());
                    }
                }
                else { MessageBox.Show("Information Missing!"); }
               
            }
            else
            {
                MessageBox.Show("Trainer Existed!");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (cmbTrainerID.Text != "New Trainer")
            {
                MessageBox.Show("You are trying to delete a trainer! Press enter to continue");
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString());
                con.Open();

                string UID = txtUserID.Text;
                string Username = txtUsername.Text;
                string Password = txtPassword.Text;
                SqlCommand cmdDeleteFromUser = new SqlCommand($"DELETE FROM [User] WHERE UserID = '{UID}' AND Username = '{Username}' AND Password = '{Password}'", con);
                cmdDeleteFromUser.ExecuteNonQuery();
                SqlCommand cmdDeleteFromTrainer = new SqlCommand($"DELETE FROM [Trainer] WHERE UserId = '{UID}' AND Password = '{Password}'", con);
                cmdDeleteFromTrainer.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Trainer Deleted");

                cmbTrainerID.Items.Clear();
                GetTrainerIDList ID = new GetTrainerIDList();
                foreach (var id in ID.Refresh())
                {
                    cmbTrainerID.Items.Add(id.ToString());
                }
            }
            else
            {
                MessageBox.Show("Cannot delete a trainer that is not existing!");
            }
        }

        private void btn2Home_Click(object sender, EventArgs e)
        {
            this.Close();
            FormProvider.Admin.Show();
        }
    }
}
