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
            //Open Connection to the database
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            //Query to find total number of trainers in the trainer table
            SqlCommand cmdTrainerCount = new SqlCommand($"SELECT COUNT(TrainerID) FROM [Trainer]", con);
            
            //Display all TrainerID into the TrainerID ComboBox
            int TotalTrainer = Convert.ToInt32(cmdTrainerCount.ExecuteScalar());
            for (int i = 1; i <= TotalTrainer; i++)
            {
                cmbTrainerID.Items.Add(i.ToString());
            }
            cmbTrainerID.Items.Add("New Trainer");
            con.Close();
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

                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                int TrainerID = int.Parse(cmbTrainerID.Text);

                SqlCommand cmdTrainerUID = new SqlCommand($"SELECT UserID FROM [Trainer] WHERE TrainerID = '{TrainerID}'", con);
                txtUserID.Text = cmdTrainerUID.ExecuteScalar().ToString();

                SqlCommand cmdUsername = new SqlCommand($"SELECT Username FROM [Trainer] WHERE TrainerID = '{TrainerID}'", con);
                txtUsername.Text = cmdUsername.ExecuteScalar().ToString();

                SqlCommand cmdTrainerPassword = new SqlCommand($"SELECT Password FROM [Trainer] WHERE TrainerID = '{TrainerID}'", con);
                txtPassword.Text = cmdTrainerPassword.ExecuteScalar().ToString();

                SqlCommand cmdTrainerName = new SqlCommand($"SELECT FullName FROM [Trainer] WHERE TrainerID = '{TrainerID}'", con);
                txtName.Text = cmdTrainerName.ExecuteScalar().ToString();

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

                txtUserID.Enabled = true;
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
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();

                string Username = txtUsername.Text;
                string Password = txtPassword.Text;
                string Name = txtName.Text;
                string Email = txtEmail.Text;
                string Contact = txtContactNumber.Text;
                string Address = txtAddress.Text;

                if (Username == null || Password == null || Name == null || Email == null || Contact == null || Address == null) { MessageBox.Show("Information Missing!"); }
                SqlCommand cmdInsertIntoUser = new SqlCommand($"INSERT INTO [User] VALUES('{Username}', '{Password}', 'Trainer')", con);
                cmdInsertIntoUser.ExecuteNonQuery();

                SqlCommand cmdUID = new SqlCommand($"SELECT UserID FROM [User] WHERE Username = '{Username}' AND Password = '{Password}'", con);
                string UID = cmdUID.ExecuteScalar().ToString();

                SqlCommand cmdInsertIntoTrainer = new SqlCommand($"INSERT INTO [Trainer] Values('{UID}', '{Username}', '{Password}', '{Name}', '{Email}', '{Contact}', '{Address}')", con);
                cmdInsertIntoTrainer.ExecuteNonQuery();

                MessageBox.Show("Trainer Registered!");
                this.Refresh();
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
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();

                string UID = txtUserID.Text;
                string Username = txtUsername.Text;
                string Password = txtPassword.Text;
                SqlCommand cmdDeleteFromUser = new SqlCommand($"DELETE FROM [User] WHERE UserID = '{UID}' AND Username = '{Username}' AND Password = '{Password}'", con);
                cmdDeleteFromUser.ExecuteNonQuery();
                SqlCommand cmdDeleteFromTrainer = new SqlCommand($"DELETE FROM [Trainer] WHERE UserID = '{UID}' AND Username = '{Username}' AND Password = '{Password}'", con);
                cmdDeleteFromTrainer.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Trainer Deleted");
                this.Refresh();
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
