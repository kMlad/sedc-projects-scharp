using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Congratulations on buying a new dog! ^_^");
            Console.WriteLine("What's the dog's name?");
            string dogName = Console.ReadLine();
            Console.WriteLine("What race is it?");
            string dogRace = Console.ReadLine();
            Console.WriteLine("What color is it?");
            string dogColor = Console.ReadLine();


            Dog doggo1 = new Dog(dogName, dogRace, dogColor);
            Console.WriteLine("___________________________");
            Console.WriteLine("What do you want the dog to do?");
            Console.WriteLine($"Type in 'A' to make {doggo1.Name} eat.");
            Console.WriteLine($"Type in 'B' to make {doggo1.Name} play.");
            Console.WriteLine($"Type in 'C' to make {doggo1.Name} chase its tail.");
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "A":
                    Console.WriteLine(doggo1.Eat());
                    break;
                case "B":
                    Console.WriteLine(doggo1.Play());
                    break;
                case "C":
                    Console.WriteLine(doggo1.ChaseTail());
                    break;
                default:
                    Console.WriteLine("The dog is looking at you all confused...");
                    break;
            }






            Console.ReadKey();
        }
    }
}
