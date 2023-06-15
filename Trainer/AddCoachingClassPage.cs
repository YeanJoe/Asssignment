﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU_Programming_Cafe_Management_System
{
    public partial class AddCoachingClassPage : Form
    {
        string username;
        public AddCoachingClassPage(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            TrainerDashboardPage trainerDashboardPage = new TrainerDashboardPage(username);
            trainerDashboardPage.Show();

            // Close Form1
            this.Close();
        }

        private void AddCoachingClassPage_Load(object sender, EventArgs e)
        {

        }
    }
}