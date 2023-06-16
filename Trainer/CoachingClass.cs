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
            ClassID = classID; 
            trainerID = trainer.TrainerID;
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
                con.Open();
                string cmdString = "INSERT INTO [CoachingClass] (ClassID, ModuleID, TrainerID, Charges, Schedule) ";
                cmdString += ("VALUES('', {0}, {1}, {2}, '{3}')");
                cmdString = string.Format(cmdString, moduleID, trainerID, charges, schedule);
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
    }
}
