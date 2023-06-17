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
    public partial class DeleteCompletedStudent : Form
    {
        Lecturer lecturer;
        Enrollment enrollment;
        public DeleteCompletedStudent(Lecturer lecturer)
        {
            InitializeComponent();
            this.lecturer = lecturer;
        }

        private void DeleteCompletedStudent_Load(object sender, EventArgs e)
        {
            enrollment = new Enrollment();
            enrollment.GetStudentsCompletedClasses();
            foreach(int studentID in enrollment.StudentList)
            {
                Student student = new Student(studentID);
                listCompleted.Items.Add(student.Stdname);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LecturerDashboard next= new LecturerDashboard(lecturer);
            next.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = listCompleted.SelectedIndex;
            int studentID = enrollment.StudentList[index];
            int classID = enrollment.ClassList[index];
            if (studentID != 0l && classID != 0)
            {
                Confirmation next = new Confirmation(studentID, classID);
                next.Show();
            }
            else
            {
                MessageBox.Show("Please Select a Student");
            }
        }

        private void listCompleted_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listCompleted.SelectedIndex;
            string studentName = listCompleted.SelectedItem.ToString();
            Student student = new Student(studentName);
            lblName.Text = studentName;
            lblTP.Text = student.Tpnum;
            CoachingClass coachingClass = new CoachingClass(enrollment.ClassList[index]);
            coachingClass.GetAllOtherColumnValues();
            lblModule.Text = Module.GetModuleName(coachingClass.ModuleID);
            lblLevel.Text = coachingClass.Level;
        }
    }
}
