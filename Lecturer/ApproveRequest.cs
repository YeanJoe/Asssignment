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
using System.Configuration;

namespace Asssignment.Lecturer
{
    public partial class ApproveRequest : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public ApproveRequest()
        {
            InitializeComponent();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LecturerDashboard next = new LecturerDashboard();
            next.Show();
            this.Hide();
        }

        private void ApproveRequest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataBaseDataSet.Request' table. You can move, or remove it, as needed.
            this.requestTableAdapter.Fill(this.myDataBaseDataSet.Request);

        }

        private void listRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = listRequest.SelectedValue.ToString();
            lblModule.Text = GetValueFromTableColumn("Request", selectedName, "Module", "Username");
            lblLevel.Text = GetValueFromTableColumn("Request", selectedName, "Level", "Username");
            string UserID = GetValueFromTableColumn("User", selectedName, "UserID", "Username");
            lblName.Text = GetValueFromTableColumn("StudentTable", UserID, "FullName", "UserID");
            lblTP.Text = GetValueFromTableColumn("StudentTable", UserID, "TPNumber", "UserID");
            lblStatus.Text = GetValueFromTableColumn("Request", selectedName, "Status", "Username");
        }
        
        private string GetValueFromTableColumn(string tableName, string conditionValue, string columnName, string condition)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT " + columnName + " FROM [" + tableName + "] WHERE " + condition + "= @" + condition,con);
            cmd.Parameters.AddWithValue("@"+condition, conditionValue);
            string value="";
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                value = cmd.ExecuteScalar().ToString();
            }
            else
            {
                MessageBox.Show("An exception occurred: Result is null");
            }
            con.Close();
            return value;
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkApprove_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox clickedCheckbox = (CheckBox)sender;

            if (clickedCheckbox.Checked)
            {
                foreach (Control control in groupBox1.Controls)
                {
                    if (control is CheckBox checkbox && checkbox != clickedCheckbox)
                    {
                        checkbox.Checked = false;
                    }
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
