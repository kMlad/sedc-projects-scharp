using Microsoft.VisualBasic;
using System;
using System.Collections;

namespace Inheritance
{
    class Program
    {
        Car Audi = new Car(4, "Porsche", "GT2RS", 4, "supercar", EngineType.StraightSix, 20.4, 2, 300);
        Car Tesla = new ElectricCar(3, "Tesla", "Model S", 4, "sedan", EngineType.ElectricEngine, 0, 5, 300, 4654, 90);
        Bicycle Bike = new Bicycle(1, "Shimano", "Doberman", 4, "bike", 21, false);
        Vehicle Hi = new Vehicle(1, "Pagani", "Huayra");  

        

        

    }
}
