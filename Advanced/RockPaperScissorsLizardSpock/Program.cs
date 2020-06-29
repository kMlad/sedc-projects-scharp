using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            CPUPlayer CPU = new CPUPlayer();
            UserPlayer Player = new UserPlayer();
            CPU.Name = "CPU";
            Player.Name = "Player";
            
            Game rockPaperScissorsLizardSpock = new Game(Player, CPU);
            
            bool getOut = true;
            while(getOut)
            {
                PrintMenuText();
                
                while(true)
                {
                    bool isMenuOption = int.TryParse(Console.ReadLine(), out int menuOption);
                    if(isMenuOption && ((menuOption>0 && menuOption<4)))
                    {
                        if (menuOption == 1)
                        {
                            rockPaperScissorsLizardSpock.Play();                            
                        }
                        else if (menuOption == 2)
                        {
                            rockPaperScissorsLizardSpock.ShowStats();                            
                        }
                        else
                        {
                            getOut = false;
                            Console.Clear();
                            Console.WriteLine("Press any key to exit...");
                            
                            
                        }
                        break;
                    }
                    else Console.WriteLine("Please select a valid option.");
                }

                
                
            }
            Console.ReadKey();
        }

        static void PrintMenuText()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Rock-Paper-Scissors-Lizard-Spock");
            Console.WriteLine("Please select one of the options in the menu:");
            Console.WriteLine("1) Play");
            Console.WriteLine("2) Show stats");
            Console.WriteLine("3) Exit");
        }

    }
}
