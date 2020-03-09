using System;

namespace task2
{
    class Program
        //"AVERAGE NUMBER"
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates the average of 4 numbers.");
            Console.WriteLine("Enter 4 numbers:");
            int num1, num2, num3, num4, res;
            bool isValid1 = int.TryParse(Console.ReadLine(), out num1);
            bool isValid2 = int.TryParse(Console.ReadLine(), out num2);
            bool isValid3 = int.TryParse(Console.ReadLine(), out num3);
            bool isValid4 = int.TryParse(Console.ReadLine(), out num4);

            if (isValid1 == false || isValid2 == false || isValid3 == false || isValid4 == false)
            {
                Console.WriteLine("Values entered are invalid.");
            }
            else
            {
                res = (num1 + num2 + num3 + num4) / 4;
                Console.WriteLine("The average of the numbers is: "+res);
            }

        }
    }
}
