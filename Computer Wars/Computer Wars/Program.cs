using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>()
            {
                {"Concert Tickets", 0},
                {"KMFDM T-Shirts", 0},
                {"Vinyl Records",0},
                {"Nintendo Cartridges",0},
                {"Video Game Consoles", 0}
            };

            int bankAccount = 500;
            int dayCount = 1;

            //beginning of game
            Console.WriteLine();
            Console.WriteLine(" ███╗   ███╗██╗████████╗ ██████╗██╗  ██╗███████╗██╗         ██╗    ██╗ █████╗ ██████╗ ███████╗██╗");
            Console.WriteLine(" ████╗ ████║██║╚══██╔══╝██╔════╝██║  ██║██╔════╝██║         ██║    ██║██╔══██╗██╔══██╗██╔════╝██║");
            Console.WriteLine(" ██╔████╔██║██║   ██║   ██║     ███████║█████╗  ██║         ██║ █╗ ██║███████║██████╔╝███████╗██║");
            Console.WriteLine(" ██║╚██╔╝██║██║   ██║   ██║     ██╔══██║██╔══╝  ██║         ██║███╗██║██╔══██║██╔══██╗╚════██║╚═╝");
            Console.WriteLine(" ██║ ╚═╝ ██║██║   ██║   ╚██████╗██║  ██║███████╗███████╗    ╚███╔███╔╝██║  ██║██║  ██║███████║██╗");
            Console.WriteLine(" ╚═╝     ╚═╝╚═╝   ╚═╝    ╚═════╝╚═╝  ╚═╝╚══════╝╚══════╝     ╚══╝╚══╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝ \n");

            Console.WriteLine("Press any key to begin.");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine();
            Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗     ██╗");
            Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ███║");
            Console.WriteLine(" ██║  ██║███████║ ╚████╔╝     ╚██║");
            Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝       ██║");
            Console.WriteLine(" ██████╔╝██║  ██║   ██║        ██║");
            Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝        ╚═╝ \n");


            // create method to hold this information to begin new day
            Console.WriteLine($"Weclome to day {dayCount}! \n");
            Console.WriteLine($"Your balance is ${bankAccount} \n");
            Console.WriteLine($"Please make a selection:\n");

            // create method to display choices
            Console.WriteLine("1. Check prices of items");
            Console.WriteLine("2. Check inventory");
            Console.WriteLine("3. Buy items");
            Console.WriteLine("4. Sell items");
            Console.WriteLine("5. Travel to a new city");
            Console.WriteLine("6. Apply for a loan");
            Console.WriteLine("7. Go to the bank");

            // create method to generate price values
            Random changePrice = new Random();

        }
    }
}
