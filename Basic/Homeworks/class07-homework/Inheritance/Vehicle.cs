using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Vehicle
    {
        protected int ID { get; set; }
        protected string Manufacturer { get; set; }
        protected string Model { get; set; }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"I'm a {Manufacturer} {Model}");
        }
         public Vehicle()
        {
            ID = 0;
            Manufacturer = "N/A";
            Model = "N/A";
        }
        public Vehicle(int vehicle, string mfacturer, string model)
        {
            ID = vehicle;
            Manufacturer = mfacturer;
            Model = model;
        }
    }
}
