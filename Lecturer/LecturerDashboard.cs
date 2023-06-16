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
    public partial class LecturerDashboard : Form
    {
        Lecturer lecturer;
        public LecturerDashboard(Lecturer lecturer)
        {
            InitializeComponent();
            this.lecturer = lecturer;

        }
        public LecturerDashboard()
        {
            InitializeComponent();
        }

        private void LecturerDashboard_Load(object sender, EventArgs e)
        {
            
        }

       



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSubjectEnrollment next =new UpdateSubjectEnrollment(lecturer);
            next.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCompletedStudent next =new DeleteCompletedStudent(lecturer);
            next.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
