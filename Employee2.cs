using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_projet
{
    class Employee2 : User
    {
        private string _name = "FirstName, LastName";
        private readonly double _salary = 100.0;

        private int _age;

        public Employee2(int age, string password)
        {
            this._age = age;
            this._password = password;
        }

        public Employee2( string name, int age, string password) : this(age, password)
        {
            _name = name;
        }


        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }


        public string Name
        {
            get {return _name; }

            set
            {
                if (value != null && value.Length > 3)
                {
                    this._name = value; 
                }
             }    

        }

    

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

       /* public override string ToString()
        {
            return "Employee2(" + _name + ", "+ _salary+", "+ Age +" )";
        }*/





        public double Salary
        {
            get { return _salary; }
        }



   
    }
}
