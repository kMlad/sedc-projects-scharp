using System;

namespace task1
{
    class Program
        //"REAL CALCULATOR"
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is a very rudimentary calculator. Enter 2 numbers and an operator (+, -, * and /).");
            float num1, num2, res;
            char opr;
            Console.WriteLine("Enter the 1st number:");
            bool valid1 = float.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("Enter the 2nd number:");
            bool valid2 = float.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine("Enter the operator:");
            bool validOpr = char.TryParse(Console.ReadLine(), out opr);

            if(valid1==false || valid2==false || validOpr==false)
            {
                Console.WriteLine("Entered values are invalid.");


            }
            else
            {
                switch(opr)
                {
                    case '+': res = num1 + num2;
                        break;
                    case '-': res = num1 - num2;
                        break;
                    case '*': res = num1 * num2;
                        break;
                    case '/': res = num1 / num2;
                        break;
                    default: res = 0;
                        break;

                }
                if(res==0)
                {
                    Console.WriteLine("Invalid operator.");
                }
                else
                Console.WriteLine("The result is: " + res);

            }

            Console.ReadKey();

        }
    }
}
