using Asssignment.Trainer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asssignment.Lecturer
{
    public partial class UpdateSubjectEnrollment : Form
    {
        Lecturer lecturer;
        Enrollment enrollment;
        public UpdateSubjectEnrollment(Lecturer lecturer)
        {
            InitializeComponent();
            this.lecturer = lecturer;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LecturerDashboard next= new LecturerDashboard();
            next.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lblLevel.Text != "" && lblModule.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Please enter the correct values");
            }
        }

        private void UpdateSubjectEnrollment_Load(object sender, EventArgs e)
        {

        }

        private void comboStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboClass.Items.Clear();
            comboClass.Text = "";
            lblLevel.Text = "";
            lblModule.Text = "";
            if(comboStudent.SelectedValue != null )
            {
                Student student = new Student(comboStudent.SelectedValue.ToString());
                int studentID = student.GetStudentID();
                enrollment = new Enrollment(studentID);
                List<int> classIDs = enrollment.GetClassIDsByStudent();
                foreach (int classID in classIDs)
                {
                    comboClass.Items.Add(classID);
                }
            }
            
        }



        private void UpdateSubjectEnrollment_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataBaseDataSet.Module' table. You can move, or remove it, as needed.
            this.moduleTableAdapter.Fill(this.myDataBaseDataSet.Module);
            // TODO: This line of code loads data into the 'myDataBaseDataSet.StudentTable' table. You can move, or remove it, as needed.
            this.studentTableTableAdapter.Fill(this.myDataBaseDataSet.StudentTable);

            
            //Makes the comboboxes select nothing at start
            comboStudent.SelectedIndex = -1;
            comboNewModule.SelectedIndex = -1;
        }

        private void comboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            int classID = Convert.ToInt32(comboClass.SelectedItem);
            CoachingClass coachingClass = new CoachingClass(classID);
            coachingClass.GetAllOtherColumnValues();
            lblLevel.Text = coachingClass.Level;
            lblModule.Text = Module.GetModuleName(coachingClass.ModuleID);
        }
    }
}
