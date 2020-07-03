using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeModels
{
    public class Contractor:Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }
        public Contractor(string firstName, string lastName, Role role, double workHours, int ppHour):base(firstName, lastName, role)
        {
            WorkHours = workHours;
            PayPerHour = ppHour;
            
        }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }
    }
}
