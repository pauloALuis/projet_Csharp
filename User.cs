using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_projet
{
    public class User
    {
        private string _username;
        protected string _password;
        private bool _flagTypeUser;

        public User()
        {
        }

        public User(string username = "", string password = "", bool flagTypeUser = false)
        {
            _username = username;
            _password = password;
            _flagTypeUser = flagTypeUser;
        }

        public string Password {

            get
            {
                if (this._password != null || _password.Length < 2) return Util.RandomNumber() + "" + Util.RandomString(4);
                return _password;} 
            }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString() + ": " + _username +  "," + _password + ", " + _flagTypeUser;
        }
    }
}
