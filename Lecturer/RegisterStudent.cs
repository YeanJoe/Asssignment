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
            // TODO: This line of code loads data into the 'myDataBaseDataSet.Module' table. You can move, or remove it, as needed.
            this.moduleTableAdapter.Fill(this.myDataBaseDataSet.Module);

            //Makes the comboboxes select nothing at start
            comboModule.SelectedIndex = -1;

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
            if (txtUsername.Text != "" && txtPassword.Text != "" && txtName.Text != "" && txtTP.Text != "" && txtEmail.Text != "" && txtNumber.Text != "" && txtAddress.Text != "" && comboLevel.Text != "" && comboModule.Text != "" && comboMonth.Text != "")
            {
                
                Student student = new Student(txtUsername.Text);
                student.Stdname = txtName.Text;
                student.Email = txtEmail.Text;
                student.Tpnum = txtTP.Text;
                student.PhoneNum= txtNumber.Text;
                student.Address = txtAddress.Text;


                string stat = Lecturer.RegisterStudent(txtUsername.Text, txtPassword.Text, student);
                MessageBox.Show(stat);
                if(stat != "Username already exists")
                {
                    Enrollment.InsertRow(comboModule.Text, comboLevel.Text, txtUsername.Text, comboMonth.Text);
                }
            }
            else
            {
                MessageBox.Show("Please Fill all the values");
            }
        }
    }
}
