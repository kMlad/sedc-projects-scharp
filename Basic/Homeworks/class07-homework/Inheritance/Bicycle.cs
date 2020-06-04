using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Inheritance
{
    class Bicycle : WheeledVehicle
    {
        private int NumberOfSpeedLevels { get; set; }
        private bool IsElectric { get; set; }

        public Bicycle(int vehicle, string mfacturer, string model, int wheelNum, string type,int lvlNum, bool isElectric): base(vehicle, mfacturer, model, wheelNum, type)
        {
            NumberOfSpeedLevels = lvlNum;
            IsElectric = isElectric;
            Type = type;
            NumberOfWheels = 2;
            if(IsElectric)
            {
                Console.WriteLine($"I'm an electric bike with {NumberOfSpeedLevels} speed levels.");
            }
            else
            {
                Console.WriteLine($"I'm a bike with {NumberOfSpeedLevels} speed levels.");
            }
        }

        

        public override void Repair()
        {
            Console.WriteLine($"Repairing bike {Manufacturer}-{Model}...");
        }

        
        public void Ride()
        {
            Console.WriteLine($"Riding bike...");
        }
    }
}
