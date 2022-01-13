using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOldOnes.GameLibrary
{
    public class GameOpening
    {
        public void GameTitle()
        {
            Console.WriteLine(@"
    
    ░██████╗░██████╗░███████╗░█████╗░████████╗  ░█████╗░██╗░░░░░██████╗░  ░█████╗░███╗░░██╗███████╗░██████╗
    ██╔════╝░██╔══██╗██╔════╝██╔══██╗╚══██╔══╝  ██╔══██╗██║░░░░░██╔══██╗  ██╔══██╗████╗░██║██╔════╝██╔════╝
    ██║░░██╗░██████╔╝█████╗░░███████║░░░██║░░░  ██║░░██║██║░░░░░██║░░██║  ██║░░██║██╔██╗██║█████╗░░╚█████╗░
    ██║░░╚██╗██╔══██╗██╔══╝░░██╔══██║░░░██║░░░  ██║░░██║██║░░░░░██║░░██║  ██║░░██║██║╚████║██╔══╝░░░╚═══██╗
    ╚██████╔╝██║░░██║███████╗██║░░██║░░░██║░░░  ╚█████╔╝███████╗██████╔╝  ╚█████╔╝██║░╚███║███████╗██████╔╝
    ░╚═════╝░╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝░░░╚═╝░░░  ░╚════╝░╚══════╝╚═════╝░  ░╚════╝░╚═╝░░╚══╝╚══════╝╚═════╝░

");
            Console.WriteLine("\n\n\n\t\t\t\t\t\t1. Start Game\n\n" +
                "\t\t\t\t\t\t2. Laws of Tera\n\n" +
                "\t\t\t\t\t\t3. Quit");


            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "1":
                    // StartGame
                    break;
                case "2":
                    // DisplayRules
                    break;
                case "3":
                    // Exit
                    //                    keepRunning = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\n\tPlease enter a valid option.\n" +
                        "\n" +
                        "\tPress any key to continue...");
                    Console.ReadKey();
                    break;
            }


        }


    }
}
