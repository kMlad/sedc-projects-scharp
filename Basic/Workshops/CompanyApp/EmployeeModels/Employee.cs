using System;
using System.Runtime.Versioning;

namespace EmployeeModels
{
    public enum Role { Sales, Manager, Other };

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role EmployeeRole { get; set; }
        protected double Salary { get; set; }

        public Employee(string firstName,string lastName,Role role,double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            EmployeeRole = role;
            Salary = salary;
        }
        public Employee(string firstName, string lastName, Role role)
        {
            FirstName = firstName;
            LastName = lastName;
            EmployeeRole = role;
            
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} - ${GetSalary()}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }

        

    }
}
