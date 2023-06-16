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
    }
}
