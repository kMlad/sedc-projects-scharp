using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        //speed is measured on a scale of 1-10
        public Driver Driver { get; set; }

        public Car (string model, int speed, Driver driver)
        {
            Model = model;
            Speed = speed;
            Driver = driver;
        }

        public Car (string model, int speed)
        {
            Model = model;
            Speed = speed;
            Driver = null;
        }
        public int CalculateSpeed()
        {
            return Speed * Driver.Skill;
        }
    }
}
