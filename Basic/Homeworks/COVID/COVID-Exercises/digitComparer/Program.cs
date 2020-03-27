using System;

namespace digitComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstDigit, secondDigit;

            for (int i=10; i<100; i++)
            {
                firstDigit = i / 10;
                secondDigit = i % 10;

                if(firstDigit>secondDigit)
                {
                    Console.WriteLine(i);
                }
            }
            
            
            Console.ReadKey();
        }
    }
}
