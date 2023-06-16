﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssignment.Trainer
{
    internal class Module
    {
        private int moduleID;
        private string moduleName;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());


        public int ModuleID
        {
            get { return moduleID; }
            set { moduleID = value; }
        }
        public string ModuleName
        {
            get { return moduleName; }
            set { moduleName = value; }
        }

        public Module(int moduleID, string moduleName)
        {
            ModuleID = moduleID;
            ModuleName = moduleName;
        }

        public Module(int moduleID)
        {
            ModuleName = GetModuleName(moduleID);
        }

        public Module(string moduleName)
        {
            ModuleID = GetModuleID(moduleName);
        }

        private int GetModuleID(string moduleName)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ModuleID FROM [Module] WHERE ModuleName = '" + moduleName + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            int moduleID = 0;
            while (rd.Read())
            {
                moduleID = rd.GetInt32(0);

            }
            con.Close();
            return moduleID;

        }

        private string GetModuleName(int moduleID)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ModuleName FROM [Module] WHERE ModuleID = '" + moduleID + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            string moduleName = "";
            while (rd.Read())
            {
                moduleName = rd.GetString(0);

            }
            con.Close();
            return moduleName;
        }
    }
}
