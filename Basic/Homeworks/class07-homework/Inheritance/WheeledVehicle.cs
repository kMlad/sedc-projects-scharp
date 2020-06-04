using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class WheeledVehicle : Vehicle
    {   
        protected int NumberOfWheels { get; set; }
        protected string Type { get; set; }

        public WheeledVehicle(int vehicle, string mfacturer, string model, int wheelNum, string type): base(vehicle, mfacturer, model)
        {
            NumberOfWheels = wheelNum;
            Type = type;
        }

        public virtual void  Repair()
        {
            Console.WriteLine($"Repairing {Model}");
        }
    }
}
