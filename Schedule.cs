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

        private void Schedule_Load(object sender, EventArgs e)
        {
            comboDate.Items.Clear();
            Student std = new Student(name);
            string date = std.Date(name);
            comboDate.Items.Add(date);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstSchedule.Items.Clear();
            ArrayList sch = new ArrayList();
            sch = Student.viewSchedule(name); 
            foreach(var schedule in sch)
            {
                lstSchedule.Items.Add(schedule);
            }
        }
    }
}
