using System;

namespace Task2
{
    class Program
    {
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            if (a > b)
            {
                return a - b;
            }
            else return b - a;
        }
        
        static void Main(string[] args)
        {
            int result=0;
            Console.Write("Enter + or -: ");
            string operation = Console.ReadLine();
            if(operation!="+" && operation!="-")
            {
                Console.WriteLine("Invalid operator entered. Exiting application...");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Now enter 2 numbers:");
            bool isValid1 = int.TryParse(Console.ReadLine(), out int num1);
            bool isValid2 = int.TryParse(Console.ReadLine(), out int num2);

            if (isValid1 == false || isValid2==false)
            {
                Console.WriteLine("Input entered is invalid. Exiting application...");
                Console.ReadKey();
                return;
            }
            if(operation=="+")
            {
                result = Sum(num1, num2);
            }
            if(operation=="-")
            {
                result = Subtract(num1, num2);
            }

            Console.WriteLine($"The result is: {result}");
            Console.ReadKey();

        }
    }
}
