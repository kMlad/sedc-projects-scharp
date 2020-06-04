using System;
using System.Globalization;

namespace Task3
{
    class Program
    {
        static public void RaceCars(Car c1, Car c2)
        {
            int speed1 = c1.CalculateSpeed();
            int speed2 = c2.CalculateSpeed();

            Console.WriteLine(speed1>speed2?$"{c1.Model}, driven by {c1.Driver.Name} is faster, with speed of {speed1}":(speed2==speed1?"Both cars are equally fast":
                $"{c2.Model}, driven by {c2.Driver.Name} is faster, with speed of {speed2}"));
        }

        static void Main(string[] args)
        {
            #region Drivers and Cars
            Driver lec = new Driver("Charles LeClerc", 9);
            Driver ver = new Driver("Max Verstappen", 10);
            Driver nor = new Driver("Lando Norris", 7);
            Driver gro = new Driver("Romain Grosjean", 0);

            Car merc = new Car("Mercedes AMG Petronas", 10);
            Car fer = new Car("Scuderia Ferrari", 8);
            Car mcl = new Car("McLaren", 6);
            Car wil = new Car("ROKiT Williams Racing", 4);
            #endregion

            
            //global while starts here
            while(true)
            {
                

                #region Other Inits          
                    Car[] cars = { merc, fer, mcl, wil };
                    Driver[] drivers = { lec, ver, nor, gro };
                    Car[] cars2 = new Car[3];
                    Driver[] drivers2 = new Driver[3];
                    Car[] raceCars = new Car[2];
                    int carOne, carTwo;
                    int driverOne, driverTwo;
                    int ctr;
                #endregion
                Console.WriteLine("Welcome to Racing Simulator, the game where you can 100% realistically see which car/driver combination will dominate the F1.");
                #region Choosing Car and Driver no.1
                Console.WriteLine("Choose a car no.1");
                foreach (Car car in cars)
                {
                    Console.WriteLine($"{Array.IndexOf(cars, car) + 1}. {car.Model}");
                }
                while (true)
                {
                    bool isCarOne = int.TryParse(Console.ReadLine(), out carOne);
                    if (isCarOne == false || (carOne < 1 || carOne > 4))
                    {
                        Console.WriteLine("Please enter a valid number in order to choose the car you want to race with.");
                    }
                    else
                    {
                        carOne--;
                        break;
                    }
                }
                Console.Clear();
                raceCars[0] = cars[carOne];
                ctr = 0;
                foreach (Car car in cars)
                {
                    if (Array.IndexOf(cars, car) != carOne)
                    {
                        cars2[ctr] = car;
                        ctr++;
                    }
                }


                Console.WriteLine("Choose a driver no.1");
                foreach (Driver driver in drivers)
                {
                    Console.WriteLine($"{Array.IndexOf(drivers, driver) + 1}. {driver.Name}");
                }
                while (true)
                {
                    bool isDriverOne = int.TryParse(Console.ReadLine(), out driverOne);
                    if (isDriverOne == false || (driverOne < 1 || driverOne > 4))
                    {
                        Console.WriteLine("Please enter a valid number in order to choose the driver you want to race with.");
                    }
                    else
                    {
                        driverOne--;
                        break;
                    }
                }
                Console.Clear();
                raceCars[0].Driver = drivers[driverOne];
                ctr = 0;
                foreach (Driver driver in drivers)
                {
                    if (Array.IndexOf(drivers, driver) != driverOne)
                    {
                        drivers2[ctr] = driver;
                        ctr++;
                    }
                }
                #endregion

                #region Choosing Car and Driver no.2
                Console.WriteLine("Choose a car no.2");
                foreach (Car car in cars2)
                {
                    Console.WriteLine($"{Array.IndexOf(cars2, car) + 1}. {car.Model}");
                }
                while (true)
                {
                    bool isCarTwo = int.TryParse(Console.ReadLine(), out carTwo);
                    if (isCarTwo == false || (carTwo < 1 || carTwo > 4))
                    {
                        Console.WriteLine("Please enter a valid number in order to choose the car you want to race with.");
                    }
                    else
                    {
                        carTwo--;
                        break;
                    }
                }
                Console.Clear();
                raceCars[1] = cars2[carTwo];



                Console.WriteLine("Choose a driver no.2");
                foreach (Driver driver in drivers2)
                {
                    Console.WriteLine($"{Array.IndexOf(drivers2, driver) + 1}. {driver.Name}");
                }
                while (true)
                {
                    bool isDriverTwo = int.TryParse(Console.ReadLine(), out driverTwo);
                    if (isDriverTwo == false || (driverTwo < 1 || driverTwo > 4))
                    {
                        Console.WriteLine("Please enter a valid number in order to choose the driver you want to race with.");
                    }
                    else
                    {
                        driverTwo--;
                        break;
                    }
                }
                Console.Clear();
                raceCars[1].Driver = drivers[driverTwo];
                #endregion
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($"{raceCars[0].Model}, {raceCars[0].Driver.Name} vs {raceCars[1].Model}, {raceCars[1].Driver.Name}");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||");
                RaceCars(raceCars[0], raceCars[1]);
                Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||");
                Console.ReadKey();
                Console.Clear();


                Console.WriteLine("Do you want to race again? Type \"Yes\" if you would like to. Type anything else if not.");
                string again = Console.ReadLine();
                if(again!="Yes")
                {
                    break;
                }
                Console.Clear();
            }



            Console.WriteLine("Thank you for playing Racing Simulator! Press any key to exit.");

            Console.ReadKey();
        }

    }
}
