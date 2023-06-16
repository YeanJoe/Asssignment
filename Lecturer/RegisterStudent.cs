using System;
using System.Windows.Forms;

namespace Asssignment.Lecturer
{
    public partial class RegisterStudent : Form
    {
        Lecturer lecturer;
        public RegisterStudent(Lecturer lecturer)
        {
            InitializeComponent();
            this.lecturer = lecturer;
        }

        private void RegisterStudent_Load(object sender, EventArgs e)
        {

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LecturerDashboard next = new LecturerDashboard();
            next.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtTP.Text != "" && txtEmail.Text != "" && txtNumber.Text != "" && txtAddress.Text != "" && comboLevel.Text != "" && comboModule.Text != "" && comboMonth.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Please Fill all the values");
            }
        }
    }
}
