using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Asssignment
{
    public partial class test : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public test()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string name = textBox1.Text;
            SqlCommand cmd = new SqlCommand("INSERT INTO [Table] (name) VALUES(@name)", con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
