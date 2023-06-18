using Asssignment;
using Asssignment.Trainer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU_Programming_Cafe_Management_System
{
    public partial class ViewStudentsPage : Form
    {
        Trainer trainer;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public ViewStudentsPage(Trainer trainer)
        {
            InitializeComponent();
            this.trainer = trainer;
        }

        private void ViewStudentsPage_Load(object sender, EventArgs e)
        {
            //Insert the possile modules into the combo box from the module table
            List<string> modules = trainer.GetTrainerExistingModules();
            foreach(string module in modules)
            {
                cboModule.Items.Add(module);
            }
           

            
            
        }


        private void BtnBack_Click(object sender, EventArgs e)
        {
            TrainerDashboardPage trainerDashboardPage = new TrainerDashboardPage(trainer);
            trainerDashboardPage.Show();

            this.Close();
        }

        private void cboModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboStudent.Items.Clear();
            cboStudent.Text = "";
            List<string>studentNames = trainer.GetTrainerStudentList(cboModule.Text);
            foreach (string studentName in studentNames)
            {
                cboStudent.Items.Add(studentName);
            }
        }

        private void cboStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string studentName = cboStudent.Text;
            Student selectedStudent = new Student(studentName);
            selectedStudent.ViewPro(studentName);
            lblName.Text = studentName;
            lblTPNumber.Text = selectedStudent.Tpnum;
            lblEmail.Text = selectedStudent.Email;
            lblAddress.Text = selectedStudent.Address;
            lblContactNumber.Text = selectedStudent.PhoneNum;

            int classID = trainer.GetTrainerClassIDList(cboModule.Text)[0];
            int studentID = selectedStudent.GetStudentID();

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Level, Month FROM [Enrollment] WHERE StudentID = '" + studentID + "' AND ClassID = '" + classID + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            string level = "";
            string month = "";
            while (rd.Read())
            {
                level = rd.GetString(0);
                month = rd.GetString(1);
            }
            lblLevel.Text = level;
            lblMonthofEnrollment.Text = month;

            con.Close();
        }


    }
}
