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
using Asssignment.Trainer;
using static System.Windows.Forms.AxHost;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Asssignment.Lecturer
{
    public partial class ApproveRequest : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        Lecturer lecturer;

        public ApproveRequest(Lecturer lecturer)
        {
            InitializeComponent();
            this.lecturer = lecturer;

        }
        

        private void btnBack_Click(object sender, EventArgs e)
        {
            LecturerDashboard next = new LecturerDashboard();
            next.Show();
            this.Close();
        }

        private void ApproveRequest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataBaseDataSet.Request' table. You can move, or remove it, as needed.
            this.requestTableAdapter.Fill(this.myDataBaseDataSet.Request);

            //Makes the listBox select nothing at start
            listRequest.SelectedIndex = -1;
        }

        private void listRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listRequest.SelectedValue != null)
            {
                string selectedName = listRequest.SelectedValue.ToString();
                lblModule.Text = GetValueFromTableColumn("Request", selectedName, "Module", "Username");
                lblLevel.Text = GetValueFromTableColumn("Request", selectedName, "Level", "Username");
                string UserID = GetValueFromTableColumn("User", selectedName, "UserID", "Username");
                lblName.Text = GetValueFromTableColumn("StudentTable", UserID, "FullName", "UserID");
                lblTP.Text = GetValueFromTableColumn("StudentTable", UserID, "TPNumber", "UserID");
                lblStatus.Text = GetValueFromTableColumn("Request", selectedName, "Status", "Username");

            }
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
            string username = listRequest.SelectedValue.ToString();
            if (checkApprove.Checked)
            {
                RequestClass request = new RequestClass(username);
                request.dltReq(username);
                Enrollment.InsertRow(lblModule.Text, lblLevel.Text, username);
            }
            else if (checkReject.Checked)
            {
                RequestClass request = new RequestClass(username);
                MessageBox.Show(request.dltReq(username));
            }
            else
            {
                MessageBox.Show("Please select an option");
            }

            LecturerDashboard next = new LecturerDashboard();
            next.Show();
            this.Close();
        }

    }
}
