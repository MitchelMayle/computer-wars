using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWars.Tasks
{
    public static class Tasks
    {
        // initialize/reset inventory
        public static Dictionary<string, int> ResetInventory()
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>()
            {
                { "Processors", 0},
                { "Graphics Cards", 0},
                { "Hard Drives",0},
                { "RAM Sticks",0},
                { "Flash Drives", 0}
            };
            return inventory;
        }

        // randomize part list
        public static Dictionary<string, int> ChangePartPrices()
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
                {"RAM Sticks",ramPrice},
                {"Flash Drives", fshPrice}
            };

            return list;
        }

        // version and name first page
        public static void DisplaySplashPage()
        {
            Console.WriteLine(" v0.9B");
            Console.WriteLine(" Created by Mitchel Mayle III");
            Console.WriteLine("\n\n\n\n\n\n");
            Console.Write(" ***** PRESS ANY KEY TO START *****");
            Console.ReadKey();
            Console.Clear();
        }

        // instructions
        public static void DisplayInstructions()
        {
            Console.WriteLine();
            Console.WriteLine(" You have 30 days to travel between cities to buy and sell computer parts to accumulate as much money as you can.\n");
            Console.WriteLine(" When you travel to a different city, one day will pass, and the price rate for each part will change for that day.\n");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(" ***** PRESS ANY KEY TO BEGIN DAY 1 *****");
            Console.ReadKey();
            Console.Clear();
        }

        // print parts prices
        public static void DisplayPrices(Dictionary<string, int> partsList)
        {
            int i = 1;

            foreach (KeyValuePair<string, int> kvp in partsList)
            {
                Console.WriteLine($" [{i}] {kvp.Key.PadRight(17)} -   {kvp.Value.ToString("C").PadLeft(4)}");
                i++;
            }
        }

        // print inventory
        public static void DisplayInventory(Dictionary<string, int> partsList)
        {
            int i = 1;

            foreach (KeyValuePair<string, int> kvp in partsList)
            {
                Console.WriteLine($" [{i}] {kvp.Key.PadRight(17)} -   {kvp.Value.ToString().PadLeft(4)}");
                i++;
            }
        }

        // not enough money
        public static void NotEnoughMoney()
        {
            Console.WriteLine(" You do not have enough money.");
            Console.WriteLine("\n ***** PRESS ANY KEY TO RETURN TO THE MENU *****");
            Console.ReadKey();
            Console.Clear();
        }

        public static void NotEnoughInInventory(string partName)
        {
            Console.WriteLine($" You do not have this many {partName}.");
            Console.WriteLine("\n ***** PRESS ANY KEY TO RETURN TO THE MENU *****");
            Console.ReadKey();
            Console.Clear();
        }


    }
}
