using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 6 numbers:");

            int[] arr = new int[6];
            int sum = 0;
            bool isNum;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Number " + (i+1) + ":");
                isNum = int.TryParse(Console.ReadLine(), out arr[i]);
                if (isNum == false)
                {
                    Console.WriteLine("Invalid value entered.");
                    sum = 0;
                    break;
                }
                if(arr[i]%2==0)
                sum += arr[i];
            }

            Console.WriteLine("The result is: " + sum);

            Console.ReadKey();
        }
    
    }
}
