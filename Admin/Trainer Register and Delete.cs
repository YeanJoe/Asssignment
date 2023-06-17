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
using Asssignment.Trainer;
using System.Collections;

namespace Assignment_Admin_
{

    public partial class Trainer_Register_and_Delete : Form
    {
        public static string name;

        public Trainer_Register_and_Delete(string n)
        {
            InitializeComponent();
            Name = n;
        }

        private void Trainer_Register_and_Delete_Load(object sender, EventArgs e)
        {
            txtUserID.Enabled = false;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            txtName.Enabled = false;
            txtEmail.Enabled = false;
            txtContactNumber.Enabled = false;
            txtAddress.Enabled = false;

            cmbTrainerID.Items.Clear();
            ArrayList TrainerID = new Trainer().GetAllTrainerID();
            TrainerID.Add("New Trainer");
            foreach (string id in TrainerID)
            {
                cmbTrainerID.Items.Add(id);
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

                Trainer read = new Trainer();
                read.ReadTrainerPro(cmbTrainerID.Text);
                txtUserID.Text = read.UserID.ToString();
                txtUsername.Text = read.Username;
                txtPassword.Text = read.Password;
                txtName.Text = read.FullName;
                txtEmail.Text = read.Email;
                txtContactNumber.Text = read.ContactNumber;
                txtAddress.Text = read.Address;
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
                    try
                    {
                        Trainer Register = new Trainer(Username, Password, Name, Email, Contact, Address);
                        Register.RegisterTrainer();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }


                    //Refresh cmbTrainerID after registeration
                    cmbTrainerID.Items.Clear();
                    ArrayList TrainerID = new Trainer().GetAllTrainerID();
                    TrainerID.Add("New Trainer");
                    foreach (string id in TrainerID)
                    {
                        cmbTrainerID.Items.Add(id);
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
            AlertForm Alert = new AlertForm("delete");
            Alert.ShowDialog();
            if (Alert.confirm == true)
            {
                if (cmbTrainerID.Text != "New Trainer")
                {
                    MessageBox.Show("ALERT! You are trying to delete a trainer");

                    string UID = txtUserID.Text;
                    string Username = txtUsername.Text;
                    string Password = txtPassword.Text;

                    try
                    {
                        Trainer Delete = new Trainer(UID, Username, Password);
                        Delete.DeleteTrainer();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }


                    //refresh cmbTrainerID after delete
                    cmbTrainerID.Items.Clear();
                    ArrayList TrainerID = new Trainer().GetAllTrainerID();
                    TrainerID.Add("New Trainer");
                    foreach (string id in TrainerID)
                    {
                        cmbTrainerID.Items.Add(id);
                    }
                }
                else
                {
                    MessageBox.Show("Cannot delete a trainer that is not existing!");
                }
            }
        }

        private void btn2Home_Click(object sender, EventArgs e)
        {
            AdminHomePage adminHomePage = new AdminHomePage();
            adminHomePage.Show();
            this.Hide();
        }
    }
}
