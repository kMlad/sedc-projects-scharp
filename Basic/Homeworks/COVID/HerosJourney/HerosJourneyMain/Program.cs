using System;

namespace HerosJourneyMain
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Log-In

            string[] emails = { "covid19@mail.com", "aca@lukas.com" };
            string[] passwords = { "covid19", "vanilici" };
            bool logInWall = false;


            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter email: ");
                string emailFromInput = Console.ReadLine();
                Console.Write("Enter password: ");
                string passFromInput = Console.ReadLine();

                int checkAt = emailFromInput.IndexOf('@');
                int checkDot = emailFromInput.IndexOf('.');

                if (emailFromInput == "" || checkAt == -1 || checkDot == -1)
                {
                    Console.WriteLine("Email is nod valid. Press enter to try again...");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                else
                {
                    for (int j = 0; j < emails.Length; j
                        ++)
                    {
                        if (emailFromInput == emails[j] && passFromInput == passwords[j])
                        {
                            logInWall = true;
                            break;
                        }
                        if (j == emails.Length - 1)
                        {
                            if (emailFromInput != emails[j] || emailFromInput != passwords[j])
                            {
                                if (i != 4) Console.WriteLine("Email or password did not match. Press enter to try again");
                                if (i == 4) Console.WriteLine("Application closing...");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                    }
                    if (logInWall == true)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Log-in successful. Press enter to start with character creation!");
                        break;
                    }
                    if (i == 4) return;
                }

            }


            #endregion

            bool wannaPlay = true;

            while(wannaPlay)
            {
                #region Character-Creation
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter a name: ");
                string charName = Console.ReadLine();
                string charRace = "";
                string charClass = "";
                int charStr = 0;
                int charHP = 0;
                int charAgi = 0;


                int raceNumber = 0;
                bool isValidRace = false;
                while (isValidRace == false || (raceNumber < 1 || raceNumber > 3))
                {
                    Console.Clear();
                    Console.WriteLine("Choose a race:");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("1) Dwarf");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("2) Elf");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("3) Human");
                    Console.ForegroundColor = ConsoleColor.White;
                    isValidRace = int.TryParse(Console.ReadLine(), out raceNumber);
                    if (isValidRace == false || (raceNumber < 1 || raceNumber > 3))
                    {
                        Console.WriteLine("Please enter a valid number from the options. Press enter to try again...");
                        Console.ReadLine();
                    }
                    if (raceNumber == 1)
                    {
                        charHP = 100;
                        charStr = 6;
                        charAgi = 2;
                        charRace = "Dwarf";
                    }
                    if (raceNumber == 2)
                    {
                        charHP = 60;
                        charStr = 4;
                        charAgi = 6;
                        charRace = "Elf";
                    }
                    if (raceNumber == 3)
                    {
                        charHP = 80;
                        charStr = 5;
                        charAgi = 4;
                        charRace = "Human";
                    }
                }
                int classNumber = 0;
                bool isValidClass = false;
                while (isValidClass == false || (classNumber < 1 || classNumber > 3))
                {
                    Console.Clear();
                    Console.WriteLine("Choose a class:");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("1) Warrior");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("2) Rogue");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("3) Mage");
                    Console.ForegroundColor = ConsoleColor.White;
                    isValidClass = int.TryParse(Console.ReadLine(), out classNumber);
                    if (isValidClass == false || (classNumber < 1 || classNumber > 3))
                    {
                        Console.WriteLine("Please enter a valid number from the options. Press enter to try again...");
                        Console.ReadLine();
                    }
                    if (classNumber == 1)
                    {
                        charHP += 20;
                        charAgi -= 1;
                        charClass = "Warrior";
                    }
                    if (classNumber == 2)
                    {
                        charHP -= 20;
                        charAgi += 1;
                        charClass = "Rogue";
                    }
                    if (classNumber == 3)
                    {
                        charHP += 20;
                        charStr -= 1;
                        charClass = "Mage";
                    }
                }
                Console.Clear();
                Console.WriteLine("Character successfully created!");
                Console.WriteLine($"{charName}({charRace}) the {charClass}.");
                Console.WriteLine($"Status: {charHP}HP, {charStr}STR, {charAgi}AGI");
                Console.WriteLine("Press enter to start playing...");
                Console.ReadLine();




                #endregion

                #region Gameplay

                Console.Clear();
                Random rnd = new Random();

                for (int i = 1; i <= 5; i++)
                {

                    bool isValidAction = false;
                    int actionNumber = 0;
                    int randEvent = rnd.Next(1, 6);
                    //Console.WriteLine("Random Event number: " + randEvent);
                    int randOutcome = rnd.Next(1, 11);
                    //Console.WriteLine("Random Outcome number: " + randOutcome);

                    if (randEvent == 1)
                    {
                        Console.WriteLine("Bandits attack out of nowhere. They seem very dangerous...");
                        Console.WriteLine($"Health: {charHP}");
                        Console.WriteLine("1) Fight");
                        Console.WriteLine("2) Run");
                        while (isValidAction == false || actionNumber < 1 || actionNumber > 2)
                        {
                            isValidAction = int.TryParse(Console.ReadLine(), out actionNumber);
                            if (isValidAction == false || actionNumber < 1 || actionNumber > 2)
                            {
                                Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                            }
                        }
                        if (actionNumber == 1)
                        {
                            if (randOutcome > charStr)
                            {
                                charHP -= 20;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You lost the fight!");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You won the fight!");
                            }
                        }
                        if (actionNumber == 2)
                        {
                            if (randOutcome > charAgi)
                            {
                                charHP -= 20;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You didn't manage to escape!");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You escaped!");
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                    }
                    if (randEvent == 2)
                    {
                        Console.WriteLine("You bump into one of the guards of the nearby village. They attack you without warning...");
                        Console.WriteLine($"Health: {charHP}");
                        Console.WriteLine("1) Fight");
                        Console.WriteLine("2) Run");
                        while (isValidAction == false || actionNumber < 1 || actionNumber > 2)
                        {
                            isValidAction = int.TryParse(Console.ReadLine(), out actionNumber);
                            if (isValidAction == false || actionNumber < 1 || actionNumber > 2)
                            {
                                Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                            }
                        }
                        if (actionNumber == 1)
                        {
                            if (randOutcome > charStr)
                            {
                                charHP -= 30;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You lost the fight!");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You won the fight!");
                            }
                        }
                        if (actionNumber == 2)
                        {
                            if (randOutcome > charAgi)
                            {
                                charHP -= 30;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You didn't manage to escape!");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You escaped!");
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                    }
                    if (randEvent == 3)
                    {
                        Console.WriteLine("A Land Shark appears. It starts chasing you down to eat you.");
                        Console.WriteLine($"Health: {charHP}");
                        Console.WriteLine("1) Fight");
                        Console.WriteLine("2) Run");
                        while (isValidAction == false || actionNumber < 1 || actionNumber > 2)
                        {
                            isValidAction = int.TryParse(Console.ReadLine(), out actionNumber);
                            if (isValidAction == false || actionNumber < 1 || actionNumber > 2)
                            {
                                Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                            }
                        }
                        if (actionNumber == 1)
                        {
                            if (randOutcome > charStr)
                            {
                                charHP -= 50;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You lost the fight!");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You won the fight!");
                            }
                        }
                        if (actionNumber == 2)
                        {
                            if (randOutcome > charAgi)
                            {
                                charHP -= 50;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You didn't manage to escape!");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You escaped!");
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                    }
                    if (randEvent == 4)
                    {
                        Console.WriteLine("You accidentally step on a rat. His friends are not happy. They attack...");
                        Console.WriteLine($"Health: {charHP}");
                        Console.WriteLine("1) Fight");
                        Console.WriteLine("2) Run");
                        while (isValidAction == false || actionNumber < 1 || actionNumber > 2)
                        {
                            isValidAction = int.TryParse(Console.ReadLine(), out actionNumber);
                            if (isValidAction == false || actionNumber < 1 || actionNumber > 2)
                            {
                                Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                            }
                        }
                        if (actionNumber == 1)
                        {
                            if (randOutcome > charStr)
                            {
                                charHP -= 10;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You lost the fight!");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You won the fight!");
                            }
                        }
                        if (actionNumber == 2)
                        {
                            if (randOutcome > charAgi)
                            {
                                charHP -= 10;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You didn't manage to escape!");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You escaped!");
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                    }
                    if (randEvent == 5)
                    {
                        Console.WriteLine("You find a huge rock. It comes alive somehow and tries to smash you...");
                        Console.WriteLine($"Health: {charHP}");
                        Console.WriteLine("1) Fight");
                        Console.WriteLine("2) Run");
                        while (isValidAction == false || actionNumber < 1 || actionNumber > 2)
                        {
                            isValidAction = int.TryParse(Console.ReadLine(), out actionNumber);
                            if (isValidAction == false || actionNumber < 1 || actionNumber > 2)
                            {
                                Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                            }
                        }
                        if (actionNumber == 1)
                        {
                            if (randOutcome > charStr)
                            {
                                charHP -= 30;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You lost the fight!");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You won the fight!");
                            }
                        }
                        if (actionNumber == 2)
                        {
                            if (randOutcome > charAgi)
                            {
                                charHP -= 30;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You didn't manage to escape!");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You escaped!");
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                    }
                    if (i == 5 || charHP <= 0) break;
                }
                Console.Clear();
                if (charHP > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congratulations! You are our new victor!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lost.");
                }

                Console.ResetColor();
                Console.WriteLine("Want to play again?");
                Console.WriteLine("1) Yes");
                Console.WriteLine("2) No");

                bool isValidPlayAgain = false;
                int numPlayAgain = 0;

                while (isValidPlayAgain == false || numPlayAgain < 1 || numPlayAgain > 2)
                {
                    isValidPlayAgain = int.TryParse(Console.ReadLine(), out numPlayAgain);
                    if (isValidPlayAgain == false || numPlayAgain < 1 || numPlayAgain > 2)
                    {
                        Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                    }
                }
                if(numPlayAgain == 2)
                {
                    wannaPlay = false;
                    Console.WriteLine("Thank you very much for playing!");
                }


                #endregion
            }


            Console.ReadKey();
        }
    }
}
