using EmployeeModels;
using System;
using System.Collections.Generic;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            Contractor dzoni = new Contractor("Dzoni", "Dzanak", Role.Other, 8, 40);
            Contractor klimce = new Contractor("Ribarot", "Klimce", Role.Other, 6.8, 60);
            Manager vlado = new Manager("Vlado", "Patkata", Role.Manager, 400, 200);
            Manager sale = new Manager("Sale", "Zajakot", Role.Manager, 375.96, 123.123);
            SalesPerson blazo = new SalesPerson("Blazo", "Razbiras", Role.Sales,300.01, 6000);
            List<Employee> Company = new List<Employee>();
            Company.Add(dzoni);
            Company.Add(klimce);
            Company.Add(vlado);
            Company.Add(sale);
            Company.Add(blazo);

            CEO toso = new CEO("Toso", "Malerot", Role.Other, 1545, 200);
            toso.AddSharesPrice(38);
            toso.Employees = Company;
            toso.PrintInfo();
            toso.PrintEmployees();
            Console.WriteLine(toso.GetSalary());


        }
    }
}
