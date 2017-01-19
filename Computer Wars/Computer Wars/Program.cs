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
                    -- neighbors stealing items
                    -- neighbors stealing identity
                    -- prices for items going up/down
                    -- bank returning high interest
                    -- killed in plane crash
                    -- flight delayed, lose a day
                    -- specific city events?
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
            int bankAccount = 500;
            int depositAccount = 0;
            int dayCount = 1;
            string currentCity = "Cleveland";
            bool hasGambled = false;

            //method to display title?
            Console.WriteLine();
            Console.WriteLine("  ██████╗ ██████╗ ███╗   ███╗██████╗ ██╗   ██╗████████╗███████╗██████╗     ██╗    ██╗ █████╗ ██████╗ ███████╗██╗");
            Console.WriteLine(" ██╔════╝██╔═══██╗████╗ ████║██╔══██╗██║   ██║╚══██╔══╝██╔════╝██╔══██╗    ██║    ██║██╔══██╗██╔══██╗██╔════╝██║");
            Console.WriteLine(" ██║     ██║   ██║██╔████╔██║██████╔╝██║   ██║   ██║   █████╗  ██████╔╝    ██║ █╗ ██║███████║██████╔╝███████╗██║");
            Console.WriteLine(" ██║     ██║   ██║██║╚██╔╝██║██╔═══╝ ██║   ██║   ██║   ██╔══╝  ██╔══██╗    ██║███╗██║██╔══██║██╔══██╗╚════██║╚═╝");
            Console.WriteLine(" ╚██████╗╚██████╔╝██║ ╚═╝ ██║██║     ╚██████╔╝   ██║   ███████╗██║  ██║    ╚███╔███╔╝██║  ██║██║  ██║███████║██╗");
            Console.WriteLine("  ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚═╝      ╚═════╝    ╚═╝   ╚══════╝╚═╝  ╚═╝     ╚══╝╚══╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝\n");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***** PRESS ANY KEY TO START *****");
            Console.ReadKey();
            Console.Clear();

            // introduction, add more description and hazards
            Console.WriteLine();
            Console.WriteLine("  ██████╗ ██████╗ ███╗   ███╗██████╗ ██╗   ██╗████████╗███████╗██████╗     ██╗    ██╗ █████╗ ██████╗ ███████╗██╗");
            Console.WriteLine(" ██╔════╝██╔═══██╗████╗ ████║██╔══██╗██║   ██║╚══██╔══╝██╔════╝██╔══██╗    ██║    ██║██╔══██╗██╔══██╗██╔════╝██║");
            Console.WriteLine(" ██║     ██║   ██║██╔████╔██║██████╔╝██║   ██║   ██║   █████╗  ██████╔╝    ██║ █╗ ██║███████║██████╔╝███████╗██║");
            Console.WriteLine(" ██║     ██║   ██║██║╚██╔╝██║██╔═══╝ ██║   ██║   ██║   ██╔══╝  ██╔══██╗    ██║███╗██║██╔══██║██╔══██╗╚════██║╚═╝");
            Console.WriteLine(" ╚██████╗╚██████╔╝██║ ╚═╝ ██║██║     ╚██████╔╝   ██║   ███████╗██║  ██║    ╚███╔███╔╝██║  ██║██║  ██║███████║██╗");
            Console.WriteLine("  ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚═╝      ╚═════╝    ╚═╝   ╚══════╝╚═╝  ╚═╝     ╚══╝╚══╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝\n");

            Console.WriteLine();
            Console.WriteLine("Your will be given 30 days to buy and sell computer parts to accumulate as much money as you can.\n");
            Console.WriteLine("When you travel to a new location, one day will pass, and current prices of parts will change.");
            Console.WriteLine("When you purchase parts, they will be magically transported to your house......");
            Console.WriteLine("But BEWARE! Your neighbors are theives and can steal all of your parts from your house at any time during your travels.\n");

            Console.WriteLine("Every city has a casino where you can gamble once a day after Day 1 to try to win more money.\n");

            Console.WriteLine("You can also visit the bank to deposit money starting on Day 3 to attempt to gain interest on your deposit......");
            Console.WriteLine("But BEWARE! If your theiving neighbors steal your identity, you could lose all of your money in your account.\n");
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
            Console.WriteLine($"Your balance is ${bankAccount}.\n");
            Console.WriteLine($"Your bank account contains ${depositAccount}.\n");
            Console.WriteLine($"Please make a selection:\n");

            // create method to display choices
            Console.WriteLine("1. Check today's prices of parts");
            Console.WriteLine("2. Check inventory at your house");
            Console.WriteLine("3. Buy parts");
            Console.WriteLine("4. Sell parts");
            Console.WriteLine("5. Deposit money at bank");
            Console.WriteLine("6. Gamble at the casino");
            Console.WriteLine("7. Fly to a new city");

            //pause
            Console.ReadKey();
            Console.Clear();

            // create method to display prices
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
            Console.Clear();

            Console.WriteLine("You currently have the following parts at your house:\n");

            foreach (KeyValuePair<string, int> kvp in inventory)
            {
                Console.WriteLine($"{kvp.Key.PadRight(17)}-{kvp.Value.ToString().PadLeft(5)}");
            }

            Console.WriteLine("\n***** PRESS ANY KEY TO RETURN TO THE MENU *****");

            //pause
            Console.ReadKey();
            Console.Clear();

            // create method to display cities
            Console.WriteLine("Select a new city in which to travel:\n");
            Console.WriteLine("1. Cleveland");
            Console.WriteLine("2. Pittsburgh");
            Console.WriteLine("3. Chicago");
            Console.WriteLine("4. Atlanta");
            Console.WriteLine("5. Seattle");
            Console.WriteLine("6. Las Vegas");
            Console.WriteLine("7. Los Angeles");
        }
    }
}
