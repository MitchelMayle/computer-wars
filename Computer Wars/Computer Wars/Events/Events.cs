using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Computer_Wars.Events
{
    class Events
    {
        //public void BeginNextDay()
        //{
        //    --set current city, do this after city selection?
        //    --increase dayCount
        //   -- change prices
        //    --calculate bank interest
        //    --reset hasGambled
        //}

        //prints instructions
        public void PrintInstructions()
        {
            Console.WriteLine();
            Console.WriteLine("You have 30 days to travel between cities to buy and sell computer parts to accumulate as much money as you can.\n");
            Console.WriteLine("When you travel between cities, one day will pass, and the price rate for each part will change for that day.\n");
            Console.WriteLine("When you purchase parts, they will be magically transported to your house......");
            Console.WriteLine("But BEWARE! Your neighbor is a thief and can steal some of your parts from your house at any time during your travels.\n");

            Console.WriteLine("Starting on Day 2, you can visit the casino in each city to try and win more money.\n");

            Console.WriteLine("Starting on Day 3, you can deposit money into your bank account to attempt to gain interest on your deposit......");
            Console.WriteLine("But BEWARE! Your thieving neighbor may steal your identity and empty your bank account.\n");
            Console.WriteLine("You have a chance to encounter both good events and bad events at the start of every new day.\n");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("***** PRESS ANY KEY TO BEGIN DAY 1 *****");
        }

        
        // creates/reset inventory
        public Dictionary<string, int> ResetInvetory()
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>()
            {
                {"Processors", 0},
                {"Graphics Cards", 0},
                {"Hard Drives",0},
                {"RAM Cards",0},
                {"Flash Drives", 0}
            };

            return inventory;
        }

        // randomize parts list
        public Dictionary<string, int> ChangePartPrices()
        {
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

            return partsList;
        }
        
        // print parts list
        public Dictionary<string, int> PartList(Dictionary<string, int> partsList)
        {
            foreach (KeyValuePair<string, int> kvp in partsList)
            {
                Console.WriteLine($"{kvp.Key.PadRight(17)}-{kvp.Value.ToString().PadLeft(5)}");
            }
            return partsList;
        }

        // print inventory
        public Dictionary<string, int> Inventory(Dictionary<string, int> inventory)
        {
            foreach (KeyValuePair<string, int> kvp in inventory)
            {
                Console.WriteLine($"{kvp.Key.PadRight(17)}-{kvp.Value.ToString().PadLeft(5)}");
            }
        }



    }
}
