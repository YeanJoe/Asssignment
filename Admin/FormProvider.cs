using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Admin_
{
    public class FormProvider
    {

        public static AdminHomePage Admin
        {
            get
            {
                if (_admin == null)
                {
                    _admin = new AdminHomePage();
                }
                return _admin;
            }
        }
        private static AdminHomePage _admin;
    }
}
