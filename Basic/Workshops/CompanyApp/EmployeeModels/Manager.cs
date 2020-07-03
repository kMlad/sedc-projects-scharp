using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeModels
{
    public class Manager: Employee
    {
        private double Bonus { get; set; }

        public Manager(string firstName, string lastName, Role role, double salary, double bonus) :base(firstName, lastName, role, salary)
        {
            Bonus = bonus;
        }

        public override double GetSalary()
        {
            return Salary + Bonus;
        }

    }
}
