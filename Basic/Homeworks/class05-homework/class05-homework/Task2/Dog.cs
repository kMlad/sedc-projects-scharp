using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Dog
    {
        public string Name { get; set; }
        private string race;
        private string color;

        public Dog(string name, string race, string color)
        {
            this.Name = name;
            this.race = race;
            this.color = color;
            Console.WriteLine($"Hello {name}, the {color} {race}!");
        }

        public string Race 
        { 
            get
            {
                return this.race; 
            } 
            set
            {
                this.race = value;
            }
        }
        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        public string Eat()
        {
            return "The dog is now eating";
        }
        public string Play()
        {
            return "The dog is now playing";
        }
        public string ChaseTail()
        {
            return "The dog is now chasing its tail";
        }
    }
}
