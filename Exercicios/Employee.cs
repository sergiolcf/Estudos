using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicios {
    class Employee {

        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int _id, string _name, double _salary) {

            ID = _id;
            Name = _name;
            Salary = _salary;
        }


        public void IncreaseSalary(double percentage) {

            Salary += Salary * percentage / 100.0;
        }

        public override string ToString() {
            return "Employee #"
                + ID
                + ", Name.: "
                + Name
                + ", Salary.: "
                + Salary.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
