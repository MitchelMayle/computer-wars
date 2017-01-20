using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Wars.Tasks
{
    class Tasks
    {
        // initialize/reset inventory
        public Dictionary<string, int> ResetInventory()
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>()
            {
                { "Processors", 1},
                { "Graphics Cards", 0},
                { "Hard Drives",0},
                { "RAM Cards",0},
                { "Flash Drives", 0}
            };
            return inventory;
        }


        // randomize part list
        public Dictionary<string, int> ChangePartPrices()
        {
            Random changePrice = new Random();
            int cpuPrice = changePrice.Next(1500, 4001);
            int gpuPrice = changePrice.Next(601, 1601);
            int hddPrice = changePrice.Next(201, 701);
            int ramPrice = changePrice.Next(80, 301);
            int fshPrice = changePrice.Next(10, 101);

            Dictionary<string, int> list = new Dictionary<string, int>()
            {
                {"Processors", cpuPrice},
                {"Graphics Cards", gpuPrice},
                {"Hard Drives",hddPrice},
                {"RAM Cards",ramPrice},
                {"Flash Drives", fshPrice}
            };

            return list;
        }

        // version and name first page
        public void DisplaySplashPage()
        {
            Console.WriteLine("v0.2A");
            Console.WriteLine("Created by Mitchel Mayle III");
            Console.WriteLine("\n\n\n\n\n\n");
            Console.Write("***** PRESS ANY KEY TO START *****");
            Console.ReadKey();
            Console.Clear();
        }

        // instructions
        public void DisplayInstructions()
        {
            Console.WriteLine();
            Console.WriteLine("You have 30 days to travel between cities to buy and sell computer parts to accumulate as much money as you can.\n");
            Console.WriteLine("When you travel to a different city, one day will pass, and the price rate for each part will change for that day.\n");
            Console.WriteLine("When you purchase parts, they will be magically transported to your house......");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("***** PRESS ANY KEY TO BEGIN DAY 1 *****");
            Console.ReadKey();
            Console.Clear();
        }



        // print parts list
        public void DisplayParts(Dictionary<string, int> partsList)
        {
            foreach (KeyValuePair<string, int> kvp in partsList)
            {
                Console.WriteLine($"{kvp.Key.PadRight(17)}-{kvp.Value.ToString().PadLeft(5)}");
            }
        }

    }
}
