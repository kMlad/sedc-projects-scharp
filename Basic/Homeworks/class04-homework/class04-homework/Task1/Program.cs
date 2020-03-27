using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string hi = "Hello from SEDC Codeacademy v7.0";
            Console.WriteLine(hi);
            Console.Write("Please enter a number: ");

            bool isNumber;
            int n;
            isNumber = int.TryParse(Console.ReadLine(), out n);
            if(isNumber==false || n>hi.Length)
            {
                Console.WriteLine("Invalid information entered. Exiting application...");
                Console.ReadKey();
                return;
            }
            string newHi = hi.Substring(0, n);
            Console.WriteLine(newHi);
            Console.WriteLine("The length of the new string is: " + newHi.Length);
            Console.ReadKey();
        }
    }
}
