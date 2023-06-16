using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asssignment.Admin
{
    public partial class AlertForm : Form
    {

        private bool Confirm;

        public bool confirm
        {
            get { return Confirm; }
            set { Confirm = value; }
        }

        public AlertForm()
        {
            InitializeComponent();
        }

        public void Delete()
        {
            lblAlertText.Text = "You are trying to delete a trainer! Press Confirm if you want to continue.";
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            confirm = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            confirm = false;
        }
    }
}
