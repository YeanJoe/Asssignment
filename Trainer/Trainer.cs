using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssignment.Trainer
{
    public class Trainer
    {
        private string trainerID;
        private string userID;
        private string fullName;
        private string email;
        private string contactNumer;
        private string address;

        public string TrainerID
        {
            get { return trainerID; }
            set { trainerID = value; }
        }

        public string UserID
        {
            get { return userID; }
            set { userID = value; }

        }
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }  
        }
        public string ContactNumer
        {
            get { return contactNumer; }
            set { contactNumer = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public Trainer() 
        {
            
        }
    }
}
