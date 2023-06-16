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
        public DeleteCompletedStudent(Lecturer lecturer)
        {
            InitializeComponent();
            this.lecturer = lecturer;
        }

        private void DeleteCompletedStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataBaseDataSet.CompletedStudent' table. You can move, or remove it, as needed.
            this.completedStudentTableAdapter.Fill(this.myDataBaseDataSet.CompletedStudent);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LecturerDashboard next= new LecturerDashboard(lecturer);
            next.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Confirmation next= new Confirmation(lecturer);
            next.Show();
            this.Hide();
        }
    }
}
