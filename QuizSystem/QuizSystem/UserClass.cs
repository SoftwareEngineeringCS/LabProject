using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSystem
{
    class UserClass
    {
        private string username;
        private string password;
        private string cnic;
        private string contactNumber;
        private string role;
        //public List<Mycontact> contacts = new List<Mycontact>();

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Cnic
        {
            get
            {
                return cnic;
            }

            set
            {
                cnic = value;
            }
        }

        public string ContactNumber
        {
            get
            {
                return contactNumber;
            }

            set
            {
                contactNumber = value;
            }
        }

        public string Role
        {
            get
            {
                return role;
            }

            set
            {
                role = value;
            }
        }
    }
}
