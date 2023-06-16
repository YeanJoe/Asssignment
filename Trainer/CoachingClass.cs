using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssignment.Trainer
{
    internal class CoachingClass
    {
        private int classID;
        private int moduleID;
        private int trainerID;
        private int charges;
        private string schedule;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public int ClassID
        {
            get { return classID; }
            set { classID = value; }
        }
        public int ModuleID
        {
            get { return moduleID; }
            set { moduleID = value; }   
        }
        public int TrainerID
        {
            get { return trainerID; }
            set { trainerID = value; }
        }

        public int Charges
        {
            get { return charges; }
            set { charges = value; }
        }
        public string Schedule
        {
            get { return schedule; }
            set { schedule = value; }
        }

        public CoachingClass( Trainer trainer)
        {
            trainerID = trainer.TrainerID;
        }

        public CoachingClass(int classID)
        {
            this.classID = classID;
        }

        public CoachingClass(int classID, int moduleID, int trainerID, int charges, string schedule)
        {
            this.classID = classID;
            this.moduleID = moduleID;
            this.trainerID = trainerID;
            this.charges = charges;
            this.schedule = schedule;
            
        }

        public string InsertRow(string moduleName, int charges, string schedule)
        {
            string stat = "Failed to Insert";
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [Module] (ModuleName) VALUES('" + moduleName + "')", con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if(i!=0)
            {
                Module module = new Module(moduleName);
                con.Open();
                string cmdString = "INSERT INTO [CoachingClass] (ModuleID, TrainerID, Charges, Schedule) ";
                cmdString += ("VALUES({0}, {1}, {2}, '{3}')");
                cmdString = string.Format(cmdString, module.ModuleID, trainerID, charges, schedule);
                cmd = new SqlCommand(cmdString, con);
                i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    stat = "Insert table row success!";
                }
                con.Close();
            }

            return stat;

        }

        public string UpdateRow(string moduleName)
        {
            SqlCommand cmd;
            int i = 0;
            string stat = "Failed to Update";
            if (moduleID == 0)
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO [Module] (ModuleName) VALUES('" + moduleName + "')", con);
                i = cmd.ExecuteNonQuery();
                con.Close();
                if (i != 0)
                {
                    Module module = new Module(moduleName);
                    moduleID = module.ModuleID;
                }
            }
           
            con.Open();
            string cmdString = "UPDATE [CoachingClass] SET ModuleID = {0}, TrainerID = {1}, Charges = {2}, Schedule = '{3}' WHERE ClassID = {4} ";
            cmdString = string.Format(cmdString, moduleID, trainerID, charges, schedule, classID);
            cmd = new SqlCommand(cmdString, con);
            i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                stat = "Update table row success!";
            }
            con.Close();

            
            return stat;
        }

        public List<string> GetAllOtherColumnValues()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ModuleID, Charges, Schedule FROM [CoachingClass] WHERE ClassID = '" + classID + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            List<string> result = new List<string>();
            while (rd.Read())
            {
                result.Add(rd.GetInt32(0).ToString());
                result.Add(rd.GetInt32(1).ToString());
                result.Add(rd.GetString(2));
            }
            rd.Close();
            con.Close();
            return result;
        }

    }
}
