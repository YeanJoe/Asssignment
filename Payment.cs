using System;
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
    public partial class Payment : Form
    {
        public static string name = "";
        public Payment()
        {
            InitializeComponent();
        }

        public Payment(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmViewReq view = new frmViewReq(name);
            view.Show();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            RequestClass req = new RequestClass(name);
            req.Pay(name);

            lblModule.Text = req.Module;
            lblLevel.Text = req.Level;
            lblCharges.Text = req.Charges;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if(radioYes.Checked)
            {
                RequestClass obj1 = new RequestClass(lblModule.Text, lblLevel.Text, lblCharges.Text);
                MessageBox.Show(obj1.ProceedPay(name));

                lblModule.Text = "";
                lblLevel.Text = "";
                lblCharges.Text = "";

                RequestClass obj2 = new RequestClass(name);
                obj2.dltReq(name);
                
            }
            else if(radioNo.Checked)
            {
                MessageBox.Show("Payment Failed");
            }
            frmViewReq view = new frmViewReq(name);

            view.Show();

            this.Hide();
        }
    }
}
