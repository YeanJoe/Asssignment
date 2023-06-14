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
        string username;
        public LecturerDashboard(string username)
        {
            InitializeComponent();
            this.username = username;

        }
        public LecturerDashboard()
        {
            InitializeComponent();
        }

        private void LecturerDashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterStudent next =new RegisterStudent();
            next.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ApproveRequest next =new ApproveRequest();
            next.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Profile next = new Profile();
            next.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login next =new Login();
            next.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSubjectEnrollment next =new UpdateSubjectEnrollment();
            next.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCompletedStudent next =new DeleteCompletedStudent();
            next.Show();
            this.Hide();
        }
    }
}
