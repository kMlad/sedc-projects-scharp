using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    enum EngineType { ThreeCylinder, FourCylinder, StraightSix, V6, V8, V10, V12, W12, ElectricEngine };
    class Car : WheeledVehicle
    {
        protected EngineType EngType { get; set; }
        protected double FuelConsumption { get; set; }
        protected int NumberOfDoors { get; set; }
        protected int MaxSpeed { get; set; }

        public Car(int vehicle, string mfacturer, string model, int wheelNum, string type, EngineType engType, double fuelConsumption, int doorNum, int maxSpeed)
            :base (vehicle, mfacturer, model, wheelNum, type)
        {
            EngType = engType;
            FuelConsumption = fuelConsumption;
            NumberOfDoors = doorNum;
            MaxSpeed = maxSpeed;
            Type = type;
        }

       
        public virtual void Drive()
        {
            Console.WriteLine($"{Model} is driving...");
        }
        public override void Repair()
        {
            Console.WriteLine($"{Manufacturer} {Model} (car) is being repaired.");
        }

    }
}
