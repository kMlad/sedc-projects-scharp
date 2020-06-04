using System;
using System.ComponentModel;
using System.Linq;

namespace Task1
{
    class Program
    {

        public static void Login(User[] users)
        {
            bool zname = true;

            Console.WriteLine("Welcome to Avenue, the hot new social media app!");
            while (zname)
            {
                Console.WriteLine("Please enter your username:");
                string userUsername = Console.ReadLine();
                Console.WriteLine("Please enter your password:");
                string userPassword = Console.ReadLine();
                Console.Clear();


                foreach (User usr in users)
                {
                    if (String.Equals(usr.Username, userUsername))
                    {
                        if (String.Equals(usr.Password, userPassword))
                        {
                            Console.WriteLine($"Welcome {usr.Username}. Here are your messages:");
                            for (int i = 0; i < usr.Messages.Length; i++)
                            {
                                Console.WriteLine($"{usr.Messages[i]}");
                            }
                            zname = false;
                            break;
                        }

                    }
                    else if (usr.Equals(users.Last()))
                    {
                        Console.WriteLine("Your login information is incorrect. Please try again.");
                    }
                }


            }
        }

        public static User[] Register(User[] users)
        {
            int id = users.Length + 1;
            bool userNameFlag = true;
            string userName = " ";
            Console.WriteLine("In order to create an account, you must enter a new username and password.");       
            
            
            while (userNameFlag)
            {
                Console.WriteLine("Please enter a new username");
                userName = Console.ReadLine();
                foreach (User user in users)
                {
                    if (userName == user.Username)
                    {
                        Console.Clear();
                        Console.WriteLine("Username already taken. Please enter another one:");
                        break;
                    }
                    if (user.Equals(users.Last()) && userName != user.Username)
                    {
                        userNameFlag = false;
                    }
                }
                
            }

            Console.WriteLine("Please enter a new password");
            string pass = Console.ReadLine();

            User newUserToArray = new User(id, userName, pass);
            User[] newUserArray = new User[id];
            Console.Clear();
            Console.WriteLine("The following accounts are registered to Avenue:");
            for(int i=0; i<users.Length+1; i++)
            {
                if(i<users.Length)
                {
                    newUserArray[i] = users[i];
                    Console.WriteLine($"{newUserArray[i].Id}. {newUserArray[i].Username}");
                }
                else
                {
                    newUserArray[i] = newUserToArray;
                    Console.WriteLine($"{newUserArray[i].Id}. {newUserArray[i].Username}");
                }
            }
            return newUserArray;
        }




        static void Main(string[] args)
        {
            #region User init, string setup
            User boki = new User(1, "Boki", "kontejner123", new string[] {"Sho ima", "Aren li si bakiiii" });
            User riki = new User(2, "RistoKaratisto", "RiKiENaJjAkh3h3",new string[] { "Kaj si be coek", "Eve ma ti kaj si" });
            User maca = new User(3, "marijaaaaaaa", "trebadaoslabamedno12kilaAmanvise", new string[] {"Macoooo iam konjopoj vecer za u avenue zemi obleci stikli ke pieme"});

            User[] users = new User[3];
            users[0] = boki;
            users[1] = riki;
            users[2] = maca;
            #endregion

            Login(users);

            Console.ReadKey();
            Console.Clear();

            User[] registeredUserArray = Register(users);

            Console.ReadKey();
        }
    }
}
