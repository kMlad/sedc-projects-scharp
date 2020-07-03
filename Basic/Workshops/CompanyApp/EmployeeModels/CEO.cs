using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeModels
{
    public class CEO: Employee
    {
        public List<Employee> Employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; }

        public CEO(string fname, string lname, Role role, double salary, int shares) : base(fname, lname, role, salary) 
        {
            Shares = shares;
        }

        public void AddSharesPrice(double price)
        {
            SharesPrice = price;
        }

        public void PrintEmployees()
        {
            foreach (Employee emp in Employees)
            {
                emp.PrintInfo();
            }
        }

        public override double GetSalary()
        {
            return Salary + Shares * SharesPrice;
        }
    }
}
