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
        public DeleteCompletedStudent()
        {
            InitializeComponent();
        }

        private void DeleteCompletedStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LecturerDashboard next= new LecturerDashboard();
            next.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Confirmation next= new Confirmation();
            next.Show();
            this.Hide();
        }
    }
}
