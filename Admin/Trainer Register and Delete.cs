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
            txtUserID.Enabled = false;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            txtName.Enabled = false;
            txtEmail.Enabled = false;
            txtContactNumber.Enabled = false;
            txtAddress.Enabled = false;

            cmbTrainerID.Items.Clear();
            Trainer ID = new Trainer();
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

                Trainer read = new Trainer();
                read.ReadTrainerPro(cmbTrainerID.Text);
                txtUserID.Text = read.uid;
                txtUsername.Text = read.username;
                txtPassword.Text = read.password;
                txtName.Text = read.name;
                txtEmail.Text = read.email;
                txtContactNumber.Text = read.phoneNumber;
                txtAddress.Text = read.address;
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

                    cmbTrainerID.Items.Clear();
                    Trainer ID = new Trainer();
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

                    cmbTrainerID.Items.Clear();
                    Trainer ID = new Trainer();
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
        }

        private void btn2Home_Click(object sender, EventArgs e)
        {
            this.Close();
            FormProvider.Admin.Show();
        }
    }
}
