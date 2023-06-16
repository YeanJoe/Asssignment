using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asssignment
{
    public partial class Schedule : Form
    {
        public static string name;
        public Schedule()
        {
            InitializeComponent();
        }

        public Schedule(string n)
        {
            InitializeComponent();
            name = n;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome(name);
            home.Show();

            this.Hide();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            ArrayList sch = new ArrayList();
            Student std = new Student(name);
            sch = std.viewSchedule();
            foreach (var schedule in sch)
            {
                lstSchedule.Items.Add(schedule);
            }
        }

 
    }
}
