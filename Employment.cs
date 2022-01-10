using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_projet
{
    class Employee
    {

        private double _tax;
        private double _monthlySalary;
        private string _name;



        public Employee(string name, double salary  = 710, double tax = 0.14)
        {
            this._tax = tax;
            this._monthlySalary = salary;
            this._name = name;

        }

        public double NetSalary () {

            return _monthlySalary - _tax;
        }


        public override string ToString() => "Employee: " + _name.ToUpper() + ",€ " + NetSalary().ToString("F2", CultureInfo.InvariantCulture) + "  ";

        /// <summary>
        /// increase net salary

        /// </summary>
        /// <returns></returns>
        public double IncreaseSalary(int percentage)
        {
            _monthlySalary = _monthlySalary + (_monthlySalary * percentage / 100.0);
            Console.WriteLine($" Salario atualizado em  ({percentage}%) => {_monthlySalary }€");
            return _monthlySalary ;
        }

      
       
    }
}
