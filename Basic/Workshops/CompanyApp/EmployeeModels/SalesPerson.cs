using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeModels
{
    public class SalesPerson: Employee
    {
        public double SuccessSaleRevenue { get; set; }
        new double Salary { get; set; } = 500;


        public SalesPerson(string firstName, string lastName, Role role, double salary, double successSaleRevenue) : base(firstName, lastName, role, salary)
        {
            SuccessSaleRevenue = successSaleRevenue;
        }

        public void ExtendSuccessRevenue(double number)
        {
            SuccessSaleRevenue = number;
        }

        public override double GetSalary()
        {
            if (SuccessSaleRevenue <= 2000)
                return Salary + 500;
            else if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
                return Salary + 800;
            else if (SuccessSaleRevenue > 5000)
                return Salary + 2000;
            else throw new ApplicationException("You get no pay this month.");
        }



    }
}
