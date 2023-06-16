using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Admin_
{
    public partial class Trainer_s_Module_Assignment : Form
    {
        public Trainer_s_Module_Assignment()
        {
            InitializeComponent();
        }

        private void cmbTrainerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkBoxPython.Checked = false;
            chkBoxDatabase.Checked = false;
            chkBoxCSharp.Checked = false;
            chkBoxJava.Checked = false;
            cmbLevel.Text = string.Empty;

            string TrainerID = cmbTrainerID.Text;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            //Look for Level of selected trainer
            SqlCommand cmdcount = new SqlCommand($"SELECT COUNT(LEVEL) FROM [TrainerModule] WHERE TrainerID = '{TrainerID}'", con);
            int countLvl = Convert.ToInt32(cmdcount.ExecuteScalar());
            if (countLvl > 0)
            {
                SqlCommand cmdLevel = new SqlCommand($"SELECT TOP 1 Level FROM [TrainerModule] WHERE TrainerID = '{TrainerID}'", con);
                string Level = cmdLevel.ExecuteScalar().ToString();
                if (Level == "Beginner") { cmbLevel.SelectedIndex = cmbLevel.FindString("Beginner"); }
                else if (Level == "Intermediate") { cmbLevel.SelectedIndex = cmbLevel.FindString("Intermediate"); }
                else if (Level == "Advance") { cmbLevel.SelectedIndex = cmbLevel.FindString("Advance"); }
            }
            else { cmbLevel.Text = ""; }

            //Look for modules assigned
            SqlCommand cmdModule = new SqlCommand($"SELECT ModuleName FROM [TrainerModule] WHERE TrainerID = '{TrainerID}'", con);
            using (SqlDataReader reader = cmdModule.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (reader["ModuleName"].ToString() == "Python")    
                    {
                        chkBoxPython.Checked = true;
                    }
                    else if (reader["ModuleName"].ToString() == "C++")
                    {
                        chkBoxDatabase.Checked = true;
                    }
                    else if (reader["ModuleName"].ToString() == "C#")
                    {
                        chkBoxCSharp.Checked = true;
                    }
                    else if (reader["ModuleName"].ToString() == "HTML")
                    {
                        chkBoxJava.Checked = true;
                    }
                }
            }
            con.Close();
        }

        private void Trainer_s_Module_Assignment_Load(object sender, EventArgs e)
        {
            //Open Connection to the database
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            //Query to find total number of trainers in the trainer table
            SqlCommand cmdTrainerID = new SqlCommand($"SELECT TrainerID FROM [Trainer] GROUP BY TrainerID", con);

            //Display all TrainerID into the TrainerID ComboBox
            using (SqlDataReader reader = cmdTrainerID.ExecuteReader())
            {
                while (reader.Read())
                {
                    cmbTrainerID.Items.Add(reader["TrainerID"].ToString());
                }
            }
            con.Close();

            chkBoxPython.Checked = false;
            chkBoxDatabase.Checked = false;
            chkBoxCSharp.Checked = false;
            chkBoxJava.Checked = false;
            cmbLevel.Text = string.Empty;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string TrainerID = cmbTrainerID.Text;
            string Python = chkBoxPython.Checked.ToString();
            string CPlusPlus = chkBoxDatabase.Checked.ToString();
            string CSharp = chkBoxCSharp.Checked.ToString();
            string HTML = chkBoxJava.Checked.ToString();

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            try
            {
                //Check if Trainer been assigned to python
                SqlCommand cmdCheckPython = new SqlCommand($"SELECT COUNT(ModuleName) FROM [TrainerModule] WHERE TrainerID = '{TrainerID}' AND ModuleName = 'Python'", con);
                int PythonCount = Convert.ToInt32(cmdCheckPython.ExecuteScalar());
                //if checkBoxPython is checked, insert a row into database if haven't been inserted
                if (Python == "true")
                {
                    if (PythonCount == 0)
                    {
                        SqlCommand cmdAddPython = new SqlCommand($"INSERT INTO [TrainerModule] VALUES ('{TrainerID}', 'Python'", con);
                        cmdAddPython.ExecuteNonQuery();
                    }
                }
                //if checkBoxPython is not checked, delete a row from database if already been inserted
                else if (Python == "false")
                {
                    if (PythonCount > 0)
                    {
                        SqlCommand cmdDelPython = new SqlCommand($"DELETE FROM [TrainerModule] WHERE TrainerID = '{TrainerID}' AND ModuleNae = 'Python'", con);
                        cmdDelPython.ExecuteNonQuery();
                    }
                }

                //same logic as Python but apply for C++ checkbox
                SqlCommand cmdCheckCPP = new SqlCommand($"SELECT COUNT(ModuleName) FROM [TrainerModule] WHERE TrainerID = '{TrainerID}' AND ModuleName = 'C++'", con);
                int CPPCount = Convert.ToInt32(cmdCheckCPP.ExecuteScalar());
                if (CPlusPlus == "true")
                {
                    if (CPPCount == 0)
                    {
                        SqlCommand cmdAddCPP = new SqlCommand($"INSERT INTO [TrainerModule] VALUES ('{TrainerID}', 'C++'", con);
                        cmdAddCPP.ExecuteNonQuery();
                    }
                }
                else if (CPlusPlus == "false")
                {
                    if (CPPCount > 0)
                    {
                        SqlCommand cmdDelCPP = new SqlCommand($"DELETE FROM [TrainerModule] WHERE TrainerID = '{TrainerID}' AND ModuleNae = 'C++'", con);
                        cmdDelCPP.ExecuteNonQuery();
                    }
                }

                //same logic as Python but apply for C# checkbox
                SqlCommand cmdCheckCSharp = new SqlCommand($"SELECT COUNT(ModuleName) FROM [TrainerModule] WHERE TrainerID = '{TrainerID}' AND ModuleName = 'C#'", con);
                int CSharpCount = Convert.ToInt32(cmdCheckCSharp.ExecuteScalar());
                if (CSharp == "true")
                {
                    if (CSharpCount == 0)
                    {
                        SqlCommand cmdAddCSharp = new SqlCommand($"INSERT INTO [TrainerModule] VALUES ('{TrainerID}', 'C#'", con);
                        cmdAddCSharp.ExecuteNonQuery();
                    }
                }
                else if (CSharp == "false")
                {
                    if (CSharpCount > 0)
                    {
                        SqlCommand cmdDelCSharp = new SqlCommand($"DELETE FROM [TrainerModule] WHERE TrainerID = '{TrainerID}' AND ModuleNae = 'C#'", con);
                        cmdDelCSharp.ExecuteNonQuery();
                    }
                }

                //same logic as Python but apply for HTML checkbox
                SqlCommand cmdCheckHTML = new SqlCommand($"SELECT COUNT(ModuleName) FROM [TrainerModule] WHERE TrainerID = '{TrainerID}' AND ModuleName = 'HTML'", con);
                int HTMLCount = Convert.ToInt32(cmdCheckHTML.ExecuteScalar());
                if (HTML == "true")
                {
                    if (HTMLCount == 0)
                    {
                        SqlCommand cmdAddHTML = new SqlCommand($"INSERT INTO [TrainerModule] VALUES ('{TrainerID}', 'HTML'", con);
                        cmdAddHTML.ExecuteNonQuery();
                    }
                }
                else if (HTML == "false")
                {
                    if (HTMLCount > 0)
                    {
                        SqlCommand cmdDelHTML = new SqlCommand($"DELETE FROM [TrainerModule] WHERE TrainerID = '{TrainerID}' AND ModuleNae = 'HTML'", con);
                        cmdDelHTML.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Update Successfully");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
