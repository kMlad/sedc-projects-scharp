using System;

namespace task3
{
    class Program
        //"SWAP NUMBERS"
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program swaps the values of the 2 entered numbers.");
            int num1, num2, tmp;
            Console.WriteLine("Enter 2 numbers");
            bool isValid1 = int.TryParse(Console.ReadLine(), out num1);
            bool isValid2 = int.TryParse(Console.ReadLine(), out num2);

            if(isValid1==false || isValid2==false)
            {
                Console.WriteLine("Values entered are invalid.");
            }
            else
            {
                tmp = num1;
                num1 = num2;
                num2 = tmp;

                Console.WriteLine("Numbers swapped. Num 1 is "+ num1 + " and num 2 is "+ num2);
            }

            Console.ReadKey();


        }
    }
}
