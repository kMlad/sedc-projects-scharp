using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{

    class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }
        public int BatteryPercentage { get; set; }

       

        public void Recharge()
        {
            Console.WriteLine("Car is charging... ");
        }
        public ElectricCar(int vehicle, string mfacturer, string model, int wheelNum, string type, EngineType engType, double fuelConsumption, int doorNum, int maxSpeed, int batCap, int batPerc)
            : base(vehicle, mfacturer, model, wheelNum, type, engType, fuelConsumption, doorNum, maxSpeed)
        {
            EngType = EngineType.ElectricEngine;
            BatteryCapacity = batCap;
            BatteryPercentage = batPerc;
        }
        public void SetMaxSpeedOnBattery()
        {
            MaxSpeed = MaxSpeed * 2;
        }

        public override void Drive()
        {
            Console.WriteLine($"Driving electric car with maximum speed:{MaxSpeed}");
        }
    }
}
