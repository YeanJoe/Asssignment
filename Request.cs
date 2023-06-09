﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asssignment
{
    public partial class Request : Form
    {
        public static string name = "";
        public Request()
        {
            InitializeComponent();
        }

        public Request(string n)
        {
            InitializeComponent();
            name = n;
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome home = new frmHome();
            home.Show();

        }

        private void lblCharge_Click(object sender, EventArgs e)
        {
    
        }

        public void comboLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboLevel.SelectedIndex == 0)
            {
                lblCharge.Text = "RM100.00";
            }
            else if (comboLevel.SelectedIndex == 1)
            {
                lblCharge.Text = "RM125.00";
            }
            else if (comboLevel.SelectedIndex == 2)
            {
                lblCharge.Text = "RM150.00";
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            
            RequestClass obj1 = new RequestClass(comboModule.Text, comboLevel.Text, lblCharge.Text);
            MessageBox.Show(obj1.reqClass(name));
            comboLevel.Text = "";
            comboModule.Text = "";
            lblCharge.Text = "";
        }

    }
}
