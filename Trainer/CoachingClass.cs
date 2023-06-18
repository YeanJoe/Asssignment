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
        private string level;
        private int trainerID;
        private int charges;
        private string schedule;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

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

        public string Level
        {
            get { return level; }
            set { level = value; }
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

        public CoachingClass()
        {

        }

        public CoachingClass(Trainer trainer)
        {
            trainerID = trainer.TrainerID;
        }

        public CoachingClass(int classID)
        {
            this.classID = classID;
        }

        public CoachingClass(int classID, int moduleID, string level, int trainerID, int charges, string schedule)
        {
            this.classID = classID;
            this.moduleID = moduleID;
            this.level = level; 
            this.trainerID = trainerID;
            this.charges = charges;
            this.schedule = schedule;
            
        }

        public string InsertRow()
        {
                string stat = "Failed to Insert";
           
                con.Open();
                string cmdString = "INSERT INTO [CoachingClass] (ModuleID, Level, TrainerID, Charges, Schedule) ";
                cmdString += ("VALUES({0}, '{1}', {2}, {3}, '{4}')");
                cmdString = string.Format(cmdString, moduleID, level, trainerID, charges, schedule);
                SqlCommand cmd = new SqlCommand(cmdString, con);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    stat = "Insert table row success!";
                }
                con.Close();

            return stat;

        }

        public void RemoveTrainerFromOriClass(string ClassID)
        {
            con.Open();
            SqlCommand cmdRemove = new SqlCommand($"UPDATE [CoachingClass] SET TrainerID = null WHERE ClassID = '{ClassID}'", con);
            cmdRemove.ExecuteNonQuery();
            con.Close();
        }

        //Updates the current values in the current field to reflect on the database
        public string UpdateRow(string moduleName)
        {
            SqlCommand cmd;
            int i = 0;
            string stat = "Failed to Update";
            //Check if the edited module doesn't exist, if it doesn't then update it in the moduleTable 
            if (moduleID == 0)
            {
                int originalModuleID = GetModuleIDFromClassID(classID);
                con.Open();
                cmd = new SqlCommand("UPDATE [Module] SET ModuleName = '" + moduleName + "' WHERE ModuleID = " + originalModuleID , con);
                i = cmd.ExecuteNonQuery();
                con.Close();
                if (i != 0)
                {
                    moduleID = Module.GetModuleID(moduleName);
                }
            }
           
            con.Open();
            string cmdString = "UPDATE [CoachingClass] SET ModuleID = {0}, Level = '{1}', TrainerID = {2}, Charges = {3}, Schedule = '{4}' WHERE ClassID = {5} ";
            cmdString = string.Format(cmdString, moduleID, level, trainerID, charges, schedule, classID);
            cmd = new SqlCommand(cmdString, con);
            i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                stat = "Update table row success!";
            }
            con.Close();

            
            return stat;
        }

        public static int GetModuleIDFromClassID(int classID)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ModuleID FROM [CoachingClass] WHERE ClassID = " + classID, con);
            SqlDataReader rd = cmd.ExecuteReader();
            int moduleID = 0;
            while(rd.Read())
            {
                moduleID = rd.GetInt32(0);
            }
            con.Close();
            return moduleID;
        }

 

        public void GetAllOtherColumnValues()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ModuleID, Level, Charges, Schedule FROM [CoachingClass] WHERE ClassID = '" + classID + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                moduleID = rd.GetInt32(0);
                level = rd.GetString(1);
                charges = rd.GetInt32(2);
                schedule = rd.GetString(3);
            }
            rd.Close();
            con.Close();
        }

        public static List<string> GetAllAdminUsername()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT FullName FROM [Admin]", con);
            SqlDataReader rd = cmd.ExecuteReader();
            List<string> AdminList = new List<string>();
            while (rd.Read())
            {
                AdminList.Add(rd.GetString(0));
            }
            rd.Close();
            con.Close();
            return AdminList;
        }

    }
}
