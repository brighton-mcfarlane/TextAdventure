using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace TextAdventure
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player();
            MainMenu();
            CharacterSelect(newPlayer);
            Backstory(newPlayer);
        }

        //A method to type out strings by character
        public static void TypeWrite(string message)
        {
            Random rdm = new Random();
            for(int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(rdm.Next(10,100));
            }
        }
        
        //A method to center menus and other string items
        public static string CenterTextInConsole(string message)
        {
            message = String.Format("{0," + ((Console.WindowWidth /2) + (message.Length /2 )) + "}", message);
            return message;
        }

        //The main menu
        public static void MainMenu()
        {
            //Error handling loop that validates user entry and starts game
            while (true)
            {
                Console.WriteLine(CenterTextInConsole("WELCOME TO THE WORLD BENEATH"));
                Console.WriteLine(CenterTextInConsole("                            "));
                Console.WriteLine(CenterTextInConsole("  #######################   "));
                Console.WriteLine(CenterTextInConsole("  #######################   "));
                Console.WriteLine(CenterTextInConsole("  #####   1.Start   #####   "));
                Console.WriteLine(CenterTextInConsole("  #####   2.Quit    #####   "));
                Console.WriteLine(CenterTextInConsole("  #######################   "));
                Console.WriteLine(CenterTextInConsole("  #######################   "));
                Console.WriteLine(CenterTextInConsole("                            "));
                Console.WriteLine(CenterTextInConsole("     ENTER IF YOU DARE      "));

                //User entry
                string userEntry = Console.ReadLine();

                //Validate user entry and check what choice they made
                //Start game and call the character selection method
                if (userEntry == "1")
                {
                    Console.Clear();
                    break;
                }
                //Quit game
                else if (userEntry == "2")
                {
                    Environment.Exit(1);
                }
                //Invalid entry
                else
                {
                    TypeWrite("Invalid Entry...Press Enter to try again\n");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
            }

        }

        //The character class selection screen
        public static void CharacterSelect(Player player)
        {
            while (true)
            {
                Console.WriteLine(CenterTextInConsole("                                  CHOOSE A CLASS                                "));
                Console.WriteLine(CenterTextInConsole("                                                                                "));
                Console.WriteLine(CenterTextInConsole("################################################################################"));
                Console.WriteLine(CenterTextInConsole("################################################################################"));
                Console.WriteLine(CenterTextInConsole("#####   1.Knight (+20 base attack, chance to block attack with shield)     #####"));
                Console.WriteLine(CenterTextInConsole("#####   2.Wizard (+15 base attack, fireball that adds +2 damage per turn)  #####"));
                Console.WriteLine(CenterTextInConsole("#####   3.Thief  (+10 base attack, higher chance to sneak by enemy)        #####"));
                Console.WriteLine(CenterTextInConsole("################################################################################"));
                Console.WriteLine(CenterTextInConsole("################################################################################"));

                //User entry
                string userEntry = Console.ReadLine();
                //Knight
                if (userEntry == "1")
                {
                    TypeWrite("I see...so you are a mighty warrior...\n");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    player.Class = "Knight";
                    player.DamageBooster = 0;
                    Console.Clear();
                    break;
                }
                //Wizard
                else if (userEntry == "2")
                {
                    TypeWrite("I see...so you are a powerful magician...\n");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    player.Class = "Wizard";
                    player.DamageBooster = 2;
                    Console.Clear();
                    break;
                }
                //Thief
                else if (userEntry == "3")
                {
                    TypeWrite("I see...so you are a shadow dweller...\n");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    player.Class = "Thief";
                    player.DamageBooster = 0;
                    Console.Clear();
                    break;
                }
                //Invalid entry
                else
                {
                    TypeWrite("Invalid Entry...Press Enter to try again\n");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

            }
            //Accept character/player name entry
            TypeWrite("And what is your name, brave soul?\n");
            string userName = Console.ReadLine();
            player.Name = userName;
            TypeWrite(String.Format("{0}, was it?\nI see...well, {0}. My name is Arteris, some refer to me as an elven spirit.\nI wish I " +
                "could save you from the dark tale ahead of you, but alas, I am just a remnant of what I was before.\nI will do my best to guide" +
                " you through your journey, but first allow me to tell you how the world beneath came to be...\n", player.Name));

            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Backstory(Player player)
        {
            TypeWrite("It started 1000 years ago. The world wasn't always ravaged as it is now...\nIt consisted of three mighty kingdoms, united against the dark influence of the Sulfuris.\n" +
                "The Kingdom of Grendul, renowned for it's purity of heart and it's fearsome Golden Knights.\n" +
                "The Kingdom of Aerenthal, renowned for it's gracefulness and home to the winged Diamond Dragons.\n" +
                "And finally, the Kingdom of Fenrethinal, renowned for it's kind leadership and it's fearsome Giant Silver Wolves.\n" +
                "");
        }
    }
}
