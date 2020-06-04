using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            string date1 = DateTime.Now.AddDays(3).ToLongDateString();
            string date2 = DateTime.Now.AddMonths(1).ToLongDateString();
            string date3 = DateTime.Now.AddMonths(1).AddDays(3).ToString("dd.MM.yy");
            string date4 = DateTime.Now.AddYears(-1).AddMonths(2).ToString("yyyy/MM/dd");
            string date5 = DateTime.Now.ToString("MMMM");
            string date6 = DateTime.Now.ToString("yyyy");

            Console.WriteLine(date1);
            Console.WriteLine(date2);
            Console.WriteLine(date3);
            Console.WriteLine(date4);
            Console.WriteLine(date5);
            Console.WriteLine(date6);

            Console.ReadKey();

        }
    }
}
