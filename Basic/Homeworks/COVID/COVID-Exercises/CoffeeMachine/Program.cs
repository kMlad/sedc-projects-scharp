using System;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double drinkPrice;
            double priceDiff;
            Console.WriteLine("Welcome dearu customero! Please select a drinko:");
            Console.WriteLine("1. Espresso...........2$");
            Console.WriteLine("2. Macchiato........3.5$");
            Console.WriteLine("3. Latte..............4$");
            Console.WriteLine("4. Cappuccino.........6$");
            Console.WriteLine("5. Tea..............1.5$");


            bool isDrink = int.TryParse(Console.ReadLine(), out int drinkNum);
            if(isDrink==false || (drinkNum<1 || drinkNum>5))
            {
                Console.WriteLine("Please select a valid number.");
                Console.ReadKey();
                return;
            }
            
            switch(drinkNum)
            {
                case 1: drinkPrice = 2;
                    break;
                case 2: drinkPrice = 3.5;
                    break;
                case 3: drinkPrice = 4;
                    break;
                case 4: drinkPrice = 6;
                    break;
                case 5: drinkPrice = 1.5;
                    break;
                default: drinkPrice = 0;
                    break;
            }


            Console.WriteLine("The drink costs "+ drinkPrice + "$. Please insert the money.");
            bool isMoney = double.TryParse(Console.ReadLine(), out double userMoney);
            if(isMoney==false)
            {
                Console.WriteLine("That's not money, that's bubblegum!");
                Console.ReadKey();
                return;
            }
            priceDiff = userMoney - drinkPrice;
            if(priceDiff>0)
            {
                Console.WriteLine("You played yourself! We do not return change :P");
            }
            if(priceDiff<0)
            {
                priceDiff = priceDiff * (-1);
                Console.WriteLine("You're "+ priceDiff + "short! Please insert the money...");
                bool isMoney2 = double.TryParse(Console.ReadLine(), out double additionalUserMoney);
                if(isMoney2==false)
                {
                    Console.WriteLine("That's not money, that's bubblegum!");
                    Console.ReadKey();
                    return;
                }
                if(additionalUserMoney<priceDiff)
                {
                    Console.WriteLine("You're short again! You deserve no coffee.");
                    Console.ReadKey();
                    return;
                }
                if(additionalUserMoney==priceDiff)
                {
                    Console.WriteLine("Spot on!");
                }
                else
                {
                    Console.WriteLine("You played yourself! We do not return change :P");                    
                }
            }


            Console.WriteLine("Please select sweatness level:");
            bool isSweet = int.TryParse(Console.ReadLine(), out int sweetNum);
            if(isSweet==false || (sweetNum<1 || sweetNum>5))
            {
                Console.WriteLine("Invalid option entered. We'll put in 1kg of sugar for you.");
                Console.WriteLine("Enjoy your coffee!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Sweetening...");
                Console.WriteLine("Your coffee is ready! Enjoy ^_^");
                Console.ReadKey();
            }
                
        }
    }
}
