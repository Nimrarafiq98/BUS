using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
namespace WcfService1
{
    public class myuser
    { //myuser class with all of its attributes 
        private string username;

        public string Username   // func user name
        {
            get { return username; }
            set { username = value; }
        }
        private string password;   //func password

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string type;

        public string Type          //func type
        {
            get { return type; }
            set { type = value; }
        }

        private string ConfirmPassword; //confirm password

        public string ConfirmPassword1
        {
            get { return ConfirmPassword; }
            set { ConfirmPassword = value; }
        }

      


    }
}