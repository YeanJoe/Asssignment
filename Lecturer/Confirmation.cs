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
    public partial class Confirmation : Form
    {
        int studentID;
        int classID;
        public Confirmation(int studentID, int classID)
        {
            InitializeComponent();
            this.studentID = studentID;
            this.classID = classID;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Confirmation_Load(object sender, EventArgs e)
        {

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {

            Enrollment enrollment = new Enrollment(studentID, classID);
            MessageBox.Show(enrollment.DeleteRow());
            this.Dispose();
        }
    }
}
