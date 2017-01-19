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
            /* TO DO
               - Develop system for random events in between days
                    -- neighbors stealing half of items (10%)
                    -- neighbors stealing identity (5%)
                    -- prices for items going up/down (90%)
                    -- bank returning high interest (10%)
                    -- wallet stolen at the airport (5%)
                    -- killed in plane crash (3%)
                    -- flight delayed, lose a day (10%)

               - Specific city events
                    -- traffic risk in LA (50%)
                    -- part prices low in LA chance (25%)
                    -- gambling in vegas lower odds

               - Day change tasks
                    -- set current city
                    -- increase dayCount
                    -- change prices
                    -- calculate bank interest
                    -- reset hasGambled
            */

            Dictionary<string, int> inventory = new Dictionary<string, int>()
            {
                {"Processors", 0},
                {"Graphics Cards", 0},
                {"Hard Drives",0},
                {"RAM Cards",0},
                {"Flash Drives", 0}
            };

            // create method to generate price values and class to hold current price values
            Random changePrice = new Random();
            int cpuPrice = changePrice.Next(1500, 4001);
            int gpuPrice = changePrice.Next(601, 1601);
            int hddPrice = changePrice.Next(201, 701);
            int ramPrice = changePrice.Next(80, 301);
            int fshPrice = changePrice.Next(10, 101);

            Dictionary<string, int> partsList = new Dictionary<string, int>()
            {
                {"Processors", cpuPrice},
                {"Graphics Cards", gpuPrice},
                {"Hard Drives",hddPrice},
                {"RAM Cards",ramPrice},
                {"Flash Drives", fshPrice}
            };

            //variable declaration
            int wallet = 500;
            int depositAccount = 0;
            int dayCount = 1;
            string currentCity = "Cleveland";
            bool hasGambled = false;

            //method to display title?
            Console.WriteLine();
            Console.WriteLine("  ██████╗ ██████╗ ███╗   ███╗██████╗ ██╗   ██╗████████╗███████╗██████╗     ██╗    ██╗ █████╗ ██████╗ ███████╗ ██╗");
            Console.WriteLine(" ██╔════╝██╔═══██╗████╗ ████║██╔══██╗██║   ██║╚══██╔══╝██╔════╝██╔══██╗    ██║    ██║██╔══██╗██╔══██╗██╔════╝ ██║");
            Console.WriteLine(" ██║     ██║   ██║██╔████╔██║██████╔╝██║   ██║   ██║   █████╗  ██████╔╝    ██║ █╗ ██║███████║██████╔╝███████╗ ██║");
            Console.WriteLine(" ██║     ██║   ██║██║╚██╔╝██║██╔═══╝ ██║   ██║   ██║   ██╔══╝  ██╔══██╗    ██║███╗██║██╔══██║██╔══██╗╚════██║ ╚═╝");
            Console.WriteLine(" ╚██████╗╚██████╔╝██║ ╚═╝ ██║██║     ╚██████╔╝   ██║   ███████╗██║  ██║    ╚███╔███╔╝██║  ██║██║  ██║███████║ ██╗");
            Console.WriteLine("  ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚═╝      ╚═════╝    ╚═╝   ╚══════╝╚═╝  ╚═╝     ╚══╝╚══╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝ ╚═╝\n");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***** PRESS ANY KEY TO START *****");
            Console.ReadKey();
            Console.Clear();

            // introduction, add more description and hazards
            Console.WriteLine();
            Console.WriteLine("  ██████╗ ██████╗ ███╗   ███╗██████╗ ██╗   ██╗████████╗███████╗██████╗     ██╗    ██╗ █████╗ ██████╗ ███████╗ ██╗");
            Console.WriteLine(" ██╔════╝██╔═══██╗████╗ ████║██╔══██╗██║   ██║╚══██╔══╝██╔════╝██╔══██╗    ██║    ██║██╔══██╗██╔══██╗██╔════╝ ██║");
            Console.WriteLine(" ██║     ██║   ██║██╔████╔██║██████╔╝██║   ██║   ██║   █████╗  ██████╔╝    ██║ █╗ ██║███████║██████╔╝███████╗ ██║");
            Console.WriteLine(" ██║     ██║   ██║██║╚██╔╝██║██╔═══╝ ██║   ██║   ██║   ██╔══╝  ██╔══██╗    ██║███╗██║██╔══██║██╔══██╗╚════██║ ╚═╝");
            Console.WriteLine(" ╚██████╗╚██████╔╝██║ ╚═╝ ██║██║     ╚██████╔╝   ██║   ███████╗██║  ██║    ╚███╔███╔╝██║  ██║██║  ██║███████║ ██╗");
            Console.WriteLine("  ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚═╝      ╚═════╝    ╚═╝   ╚══════╝╚═╝  ╚═╝     ╚══╝╚══╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝ ╚═╝\n");

            Console.WriteLine();
            Console.WriteLine("Your will be given 30 days to buy and sell computer parts to accumulate as much money as you can.\n");
            Console.WriteLine("You can travel to a new location, which will take one day, and the current prices of parts will change.\n");
            Console.WriteLine("When you purchase parts, they will be magically transported to your house......");
            Console.WriteLine("But BEWARE! Your neighbors are theives and can steal some of your parts from your house at any time during your travels.\n");

            Console.WriteLine("Starting on Day 2, you can visit the casino in each city to try and win more money.\n");

            Console.WriteLine("Starting on Day 3, you can deposit money into your bank account to attempt to gain interest on your deposit......");
            Console.WriteLine("But BEWARE! Your theiving neighbors may steal your identity and drain your bank account.\n");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***** PRESS ANY KEY TO BEGIN DAY 1 *****");

            //pause
            Console.ReadKey();
            Console.Clear();

            // method to display graphic for each day?
            Console.WriteLine();
            Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗     ██╗");
            Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ███║");
            Console.WriteLine(" ██║  ██║███████║ ╚████╔╝     ╚██║");
            Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝       ██║");
            Console.WriteLine(" ██████╔╝██║  ██║   ██║        ██║");
            Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝        ╚═╝ \n");


            // create method to hold this information to begin new day, calculate interest at beginning of day, set bools back
            Console.WriteLine($"Welcome to {currentCity}! You are currently on Day {dayCount} of 30.\n");
            Console.WriteLine($"You have ${wallet} in your wallet.\n");
            Console.WriteLine($"Your bank account has a balance of ${depositAccount}.\n");
            Console.WriteLine($"Please make a selection (by number):\n");

            // create method to display choices
            Console.WriteLine("1. Check today's prices of parts");
            Console.WriteLine("2. Check inventory at your house");
            Console.WriteLine("3. Buy parts");
            Console.WriteLine("4. Sell parts online");
            Console.WriteLine("5. Deposit money at bank");
            Console.WriteLine("6. Gamble at the casino");
            Console.WriteLine("7. Fly to a new city\n");
            Console.Write("Selection #: ");

            //pause
            Console.ReadKey();
            Console.Clear();

            // create method to display prices
            Console.WriteLine();
            Console.WriteLine(" ██████╗ ██████╗ ██╗ ██████╗███████╗███████╗");
            Console.WriteLine(" ██╔══██╗██╔══██╗██║██╔════╝██╔════╝██╔════╝");
            Console.WriteLine(" ██████╔╝██████╔╝██║██║     █████╗  ███████╗");
            Console.WriteLine(" ██╔═══╝ ██╔══██╗██║██║     ██╔══╝  ╚════██║");
            Console.WriteLine(" ██║     ██║  ██║██║╚██████╗███████╗███████║");
            Console.WriteLine(" ╚═╝     ╚═╝  ╚═╝╚═╝ ╚═════╝╚══════╝╚══════╝");
            Console.WriteLine();
            Console.WriteLine("Current part prices:\n");

            foreach (KeyValuePair<string, int> kvp in partsList)
            {
                Console.WriteLine($"{kvp.Key.PadRight(17)}-{kvp.Value.ToString().PadLeft(5)}");
            }

            Console.WriteLine("\n***** PRESS ANY KEY TO RETURN TO THE MENU *****");

            //pause
            Console.ReadKey();
            Console.Clear();

            // create method to display inventory
            Console.WriteLine();
            Console.WriteLine(" ██╗███╗   ██╗██╗   ██╗███████╗███╗   ██╗████████╗ ██████╗ ██████╗ ██╗   ██╗");
            Console.WriteLine(" ██║████╗  ██║██║   ██║██╔════╝████╗  ██║╚══██╔══╝██╔═══██╗██╔══██╗╚██╗ ██╔╝");
            Console.WriteLine(" ██║██╔██╗ ██║██║   ██║█████╗  ██╔██╗ ██║   ██║   ██║   ██║██████╔╝ ╚████╔╝ ");
            Console.WriteLine(" ██║██║╚██╗██║╚██╗ ██╔╝██╔══╝  ██║╚██╗██║   ██║   ██║   ██║██╔══██╗  ╚██╔╝  ");
            Console.WriteLine(" ██║██║ ╚████║ ╚████╔╝ ███████╗██║ ╚████║   ██║   ╚██████╔╝██║  ██║   ██║   ");
            Console.WriteLine(" ╚═╝╚═╝  ╚═══╝  ╚═══╝  ╚══════╝╚═╝  ╚═══╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝   ╚═╝   ");
            Console.WriteLine();

            Console.WriteLine("You currently have the following parts at your house:\n");

            foreach (KeyValuePair<string, int> kvp in inventory)
            {
                Console.WriteLine($"{kvp.Key.PadRight(17)}-{kvp.Value.ToString().PadLeft(5)}");
            }

            Console.WriteLine("\n***** PRESS ANY KEY TO RETURN TO THE MENU *****");

            //pause
            Console.ReadKey();
            Console.Clear();

            // create method to display cities, check for current city
            Console.WriteLine();
            Console.WriteLine("  █████╗ ██╗██████╗ ██████╗  ██████╗ ██████╗ ████████╗");
            Console.WriteLine(" ██╔══██╗██║██╔══██╗██╔══██╗██╔═══██╗██╔══██╗╚══██╔══╝");
            Console.WriteLine(" ███████║██║██████╔╝██████╔╝██║   ██║██████╔╝   ██║   ");
            Console.WriteLine(" ██╔══██║██║██╔══██╗██╔═══╝ ██║   ██║██╔══██╗   ██║   ");
            Console.WriteLine(" ██║  ██║██║██║  ██║██║     ╚██████╔╝██║  ██║   ██║   ");
            Console.WriteLine(" ╚═╝  ╚═╝╚═╝╚═╝  ╚═╝╚═╝      ╚═════╝ ╚═╝  ╚═╝   ╚═╝   ");
            Console.WriteLine();
            Console.WriteLine("Select the city (by number) that you want to fly to: (This will end your current day and change part prices)\n");
            Console.WriteLine("1. Cleveland");
            Console.WriteLine("2. Pittsburgh");
            Console.WriteLine("3. Chicago");
            Console.WriteLine("4. Atlanta");
            Console.WriteLine("5. Seattle");
            Console.WriteLine("6. Las Vegas");
            Console.WriteLine("7. Los Angeles\n");
            Console.Write("City Choice #: ");
            string cityChoice = Console.ReadLine();

            //pause
            Console.ReadKey();
            Console.Clear();

            // create method to go to bank, deposit, withdraw
            Console.WriteLine();
            Console.WriteLine("  ██████╗     ██████╗   ██╗   ██╗   ");
            Console.WriteLine(" ██╔════╝    ██╔════╝   ██║   ██║   ");
            Console.WriteLine(" ██║  ███╗   ██║        ██║   ██║   ");
            Console.WriteLine(" ██║   ██║   ██║        ██║   ██║   ");
            Console.WriteLine(" ╚██████╔╝██╗╚██████╗██╗╚██████╔╝██╗");
            Console.WriteLine("  ╚═════╝ ╚═╝ ╚═════╝╚═╝ ╚═════╝ ╚═╝");
            Console.WriteLine();
            Console.WriteLine("Welcome to Generic Credit Union.\n");
            Console.WriteLine($"You have ${wallet} in your wallet.");
            Console.WriteLine($"Your bank account contains ${depositAccount}.\n");
            Console.WriteLine();
            Console.Write("Would you like to make a (D)eposit, (W)ithdraw, or (E)xit?: ");
            string bankChoice = Console.ReadLine();

            //pause
            Console.ReadKey();
            Console.Clear();

            // create method for casino
            Console.WriteLine();
            Console.WriteLine("  ██████╗ █████╗ ███████╗██╗███╗   ██╗ ██████╗ ");
            Console.WriteLine(" ██╔════╝██╔══██╗██╔════╝██║████╗  ██║██╔═══██╗");
            Console.WriteLine(" ██║     ███████║███████╗██║██╔██╗ ██║██║   ██║");
            Console.WriteLine(" ██║     ██╔══██║╚════██║██║██║╚██╗██║██║   ██║");
            Console.WriteLine(" ╚██████╗██║  ██║███████║██║██║ ╚████║╚██████╔╝");
            Console.WriteLine("  ╚═════╝╚═╝  ╚═╝╚══════╝╚═╝╚═╝  ╚═══╝ ╚═════╝ ");
            Console.WriteLine();
            Console.WriteLine($"Welcome to the {currentCity} casino!\n");

            Console.WriteLine("You are only permitted to gamble once per day. Choose your amount to gamble wiseley.\n");

            Console.Write("Please enter a dollar amount that you would like to gamble, or press \"E\" to exit the casino: $");
            string casinoChoice = Console.ReadLine();

            //pause
            Console.ReadKey();
            Console.Clear();

            //create method for selling items
            Console.WriteLine();
            Console.WriteLine(" ███████╗███████╗██╗     ██╗         ██████╗  █████╗ ██████╗ ████████╗███████╗");
            Console.WriteLine(" ██╔════╝██╔════╝██║     ██║         ██╔══██╗██╔══██╗██╔══██╗╚══██╔══╝██╔════╝");
            Console.WriteLine(" ███████╗█████╗  ██║     ██║         ██████╔╝███████║██████╔╝   ██║   ███████╗");
            Console.WriteLine(" ╚════██║██╔══╝  ██║     ██║         ██╔═══╝ ██╔══██║██╔══██╗   ██║   ╚════██║");
            Console.WriteLine(" ███████║███████╗███████╗███████╗    ██║     ██║  ██║██║  ██║   ██║   ███████║");
            Console.WriteLine(" ╚══════╝╚══════╝╚══════╝╚══════╝    ╚═╝     ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   ╚══════╝");
            Console.WriteLine();

            Console.WriteLine("Current part prices:\n");

            foreach (KeyValuePair<string, int> kvp in partsList)
            {
                Console.WriteLine($"{kvp.Key.PadRight(17)}-{kvp.Value.ToString().PadLeft(5)}");
            }

            //pause
            Console.ReadKey();
            Console.Clear();
        }
    }
}
