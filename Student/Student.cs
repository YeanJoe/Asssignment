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
        private int stdID;
        private int userID;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());



        public Student(string aName)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From [User] WHERE Username = '" + aName + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                userID = rd.GetInt32(0);
            }
            rd.Close();
            cmd = new SqlCommand("Select StudentID, FullName, Email, ContactNum, TPNumber, Address FROM StudentTable WHERE UserID = '" + userID + "'", con);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                stdID = rd.GetInt32(0);
                stdname = rd.GetString(1);
                phoneNum = rd.GetString(3);
                email = rd.GetString(2);
                TPnumber = rd.GetString(4);
                address = rd.GetString(5);
            }
            con.Close();

        }

        public Student(int studentID)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From [StudentTable] WHERE StudentID = '" + studentID + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                stdID = rd.GetInt32(0);
                userID = rd.GetInt32(1);
                stdname = rd.GetString(2);
                email = rd.GetString(3);
                phoneNum = rd.GetString(4);
                TPnumber = rd.GetString(5);
                address = rd.GetString(6);
            }
            con.Close();

        }

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public int StdID
        {
            get { return stdID; }
            set { stdID = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
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


        public ArrayList viewSchedule()
        {
            int module = 0;
            int trainer = 0;
            string mod = "";
            string train = "";
            string schedule = "";
            ArrayList sc = new ArrayList();
            List<int> classIDs = new List<int>();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select ClassID From [Enrollment] WHERE StudentID = '" + stdID + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                classIDs.Add(rd.GetInt32(0));
            }
            rd.Close();
            foreach(int classID in classIDs)
            {
                SqlCommand cmd2 = new SqlCommand("Select * FROM [CoachingClass] WHERE ClassID = '" + classID + "'", con);
                SqlDataReader rd2 = cmd2.ExecuteReader();
                while (rd2.Read())
                {
                    schedule = rd2.GetString(5);
                    module = rd2.GetInt32(1);
                    trainer = rd2.GetInt32(3);
                }
                rd2.Close();

                SqlCommand cmd3 = new SqlCommand("Select ModuleName From [Module] WHERE ModuleID = '" + module + "'", con);
                SqlDataReader rd3 = cmd3.ExecuteReader();
                while (rd3.Read())
                {
                    mod = rd3.GetString(0);
                }
                rd3.Close();

                SqlCommand cmd4 = new SqlCommand("Select Fullname From [Trainer] WHERE TrainerID = '" + trainer + "'", con);
                SqlDataReader rd4 = cmd4.ExecuteReader();
                while (rd4.Read())
                {
                    train = rd4.GetString(0);
                }
                rd4.Close();

                if(train == null || train == "")
                {
                    train = "No Trainer";
                }

                string info = mod + " || " + train + " || " + schedule;
                sc.Add(info);
            }
          
            con.Close();
            return sc;
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
