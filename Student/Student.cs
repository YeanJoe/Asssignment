using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asssignment
{
    internal class Student
    {
        private string stdname;
        private string phoneNum;
        private string email;
        private string address;
        private string TPnumber;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());



        public Student(string aName)
        {
            stdname = aName;
            phoneNum = "";
            email = "";
            address = "";
            TPnumber = "";
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public Student(string aContact, string aEmail, string aAdress)
        {
            phoneNum = aContact;
            email = aEmail;
            address = aAdress;
            stdname = "";
            TPnumber = "";
        }

        public string Tpnum
        {
            get { return TPnumber; }
            set { TPnumber = value; }
        } 

        public string Stdname
        {
            get { return stdname; }
            set { stdname = value; }
        }

        public string PhoneNum
        { 
            get { return phoneNum; }
            set { phoneNum = value; }  
        }

        public string Email 
        {
            get { return  email; }
            set { email = value; }
        }

        public string ViewPro(string n)
        {
            string stat = null;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM StudentTable WHERE Fullname = '"+n+"'", con);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read()) 
            {
                stdname = rd.GetString(2);
                phoneNum = rd.GetString(4);
                email = rd.GetString(3);
                TPnumber = rd.GetString(5);
                address = rd.GetString(6);
            }

            con.Close();
            return stat;
        }

        public string Update(string em, string num, string add)
        {
            string stat;
            email = em;
            phoneNum = num;
            address = add;
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE StudentTable SET Email = '" + em + "', ContactNum = '" + num + "', Address = '" + add + "' WHERE Fullname = '"+Stdname+"'", con);
            int i = cmd.ExecuteNonQuery();

            if (i != 0)
            {
                stat = "Update Successfully";
            }
            else
            {
                stat = "Failed to update";
            }

            con.Close();
            return stat;
        }


        public ArrayList viewSchedule(string date)
        {
            ArrayList sc = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Schedule WHERE StudentName = @StudentName AND Date = @date", con);
            cmd.Parameters.AddWithValue("@StudentName", stdname);
            cmd.Parameters.AddWithValue("@date", date);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read()) 
            {
                /*sc.Add(rd.GetString(2));
                sc.Add(rd.GetString(3));
                sc.Add(rd.GetString(4));
                sc.Add(" ");*/
                
                string info = rd.GetString(2) + "  ||  " + rd.GetString(3) + "  ||  " + rd.GetString(4);
                sc.Add(info);
                 
            }
            con.Close();
            return sc;
        }

        public ArrayList Date()
        {
            ArrayList dt = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select DISTINCT Date FROM Schedule WHERE StudentName = '" + stdname + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                dt.Add(rd.GetString(0));
            }
            con.Close();
            return dt;
        }

        public int GetStudentID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select StudentID FROM StudentTable WHERE FullName = '" + stdname + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            int studentID = 0;
            while (rd.Read())
            {
                studentID = rd.GetInt32(0);
            }
            con.Close();
            return studentID;
        }

    }
}
