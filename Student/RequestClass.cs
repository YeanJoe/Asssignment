using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asssignment
{
    internal class RequestClass
    {
        private string module;
        private string level;
        private string charges;
        private string status;
        private string username;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string Module
        {
            get { return module; }
            set { module = value; }
        }

        public string Level
        {
            get { return level; }
            set { level = value; }
        }

        public string Charges
        {
            get { return charges; }
            set { charges = value; }
        }

        public RequestClass(string aModule, string aLevel, string aCharges)
        {
            module = aModule;
            level = aLevel;
            charges = aCharges;
            status = "pending";
        }

        public RequestClass(string aUsername)
        {
            username = aUsername;
            module = "";
            level = "";
            charges = "";
            status = "";
        }



        public string reqClass(string n) 
        {
            string status;
            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("Insert into Request(Module, Level, Charges, Status, Username)values(@module, @level, @charges, 'pending', @name)", con);
            cmd.Parameters.AddWithValue("@module", module);
            cmd.Parameters.AddWithValue("@level", level);
            cmd.Parameters.AddWithValue("@charges", charges);
            cmd.Parameters.AddWithValue("@name", n);
            int i = cmd.ExecuteNonQuery();

            if (i != 0) 
            {
                status = "Successfully Request";

            }
            else
            {
                status = "Unsuccessfully Request";
            }

            con.Close();
            
            return status;
        }

        public void viewReq(string n)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Request WHERE Username = '" + n + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                module = reader.GetString(1);
                level = reader.GetString(2);
                status = reader.GetString(4);
                charges = reader.GetString(3);
            }

            con.Close();
        }

        public string dltReq(string n)
        {
            string stat;
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete From Request WHERE Username ='"+n+"'", con);
            int i = cmd.ExecuteNonQuery();

            if (i != 0)
            {
                stat = "Delete Successfully";
            }
            else
            {
                stat = "";
            }
            con.Close();
            return stat;
        }

        public void Pay(string n)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Request WHERE Username = '" + n + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                module = reader.GetString(1);
                level = reader.GetString(2);
                charges = reader.GetString(3);
            }

            con.Close();
        }

        public string ProceedPay(string n)
        {
            string stat;
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert INTO Invoice(Username, Module, Level, Fee) values(@name, @module, @level, @fee)", con);
            cmd.Parameters.AddWithValue("@name", n);
            cmd.Parameters.AddWithValue("@module", module);
            cmd.Parameters.AddWithValue("@level", level);
            cmd.Parameters.AddWithValue("@fee", charges);
            int count = cmd.ExecuteNonQuery();

            if (count != 0)
            {
                stat = "Payment Successful!!";
            }
            else
                stat = null;
            con.Close();
            return stat;
        }

        public ArrayList addModule()
        {
            ArrayList mod = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT ModuleName FROM Module", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                mod.Add(rd.GetString(0));
            }

            con.Close() ;
            return mod;
        }

        public ArrayList chargesChange()
        {
            ArrayList chg = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select DISTINCT Charges From CoachingClass", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                chg.Add(rd.GetString(0));
            }
            con.Close() ;
            return chg;

        }

       
    }
}
