using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = { "Darko", "Marko", "Sharko", "Zharko", "Narko"};
            string[] studentsG2 = { "Kenko", "Menko", "Stamenko", "Zdenko", "Venko" };
            Console.WriteLine("Which student group would you like to access (enter 1 for G1 and 2 for G2)?");
            bool isNum = int.TryParse(Console.ReadLine(), out int selection);
            if(isNum==false || selection <1 || selection>2)
            {
                Console.WriteLine("Please enter a valid number");
                return;
            }
            if(selection==1)
            {
                Console.WriteLine("The students in G1 are:");
                for(int i=0; i<studentsG1.Length; i++)
                {
                    Console.WriteLine(studentsG1[i]);
                }
            }
            if(selection==2)
            {
                Console.WriteLine("The students in G2 are:");
                foreach(string name in studentsG2)
                {
                    Console.WriteLine(name);
                }
            }

            Console.ReadKey();
        }
    }
}
