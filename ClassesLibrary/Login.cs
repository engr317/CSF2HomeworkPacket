using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Login
    {
        //FIELDS
        private string _username;
        private string _password;

        //PROPERTIES
        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public Login(string UserName, string Password)
        {
            UserName = _username;
            Password = _password;
        }

        public Login() { }

        public override string ToString()
        {
            return string.Format("Your Username is:\n " + UserName + "\n and your Password is " + Password + ".");
        }
    }
}
