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
    public partial class frmViewReq : Form
    {
        public static string name = "";
        public frmViewReq()
        {
            InitializeComponent();
        }

        public frmViewReq(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome home = new frmHome(name);
            home.Show();
        }

        private void frmViewReq_Load(object sender, EventArgs e)
        {
            
            RequestClass rq = new RequestClass(name);
            rq.viewReq(name);

            lblClasses.Text = rq.Module;
            lblLevel.Text = rq.Level;
            lblStatus.Text = rq.Status;
            lblCharges.Text = rq.Charges;

            if (lblClasses.Text == "")
            {
                btnDlt.Enabled = false;
                btnPayment.Enabled = false;
            }
            else if(lblStatus.Text == "pending")
            {
                btnPayment.Enabled = false;
            }
            else
            {
                btnPayment.Enabled=true;
                btnDlt.Enabled=true;
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment(name);
            payment.Show();

            this.Hide();
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            string stat;
            RequestClass rq = new RequestClass(name);
            stat = rq.dltReq(name);
            if (stat != null)
            {
                MessageBox.Show(stat);
            }
            lblClasses.Text = "";
            lblCharges.Text = "";
            lblLevel.Text = "";
            lblStatus.Text = "";

            btnDlt.Enabled = false;
            btnPayment.Enabled = false;

        }

    }
}
