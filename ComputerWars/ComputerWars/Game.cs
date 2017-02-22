using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWars
{
    public class Game
    {
        const string Command_ViewInventory = "1";
        const string Command_ViewPrices = "2";
        const string Command_BuyParts = "3";
        const string Command_SellParts = "4";
        const string Command_Casino = "5";
        const string Command_Airport = "6";
        const string Command_EndGame = "EXIT";
        const int ThirtyDays = 30;

        Player player = new Player();
        Dictionary<string, int> partsList;

        public void Run()
        {
            Graphics.DisplaySplashPage();

            Graphics.DisplayInstructions();

            partsList = RandomizePrices();

            while (player.CurrentDay <= ThirtyDays)
            {                
                DisplayMenu();

                Console.Write(" Enter your selection: ");
                string command = Console.ReadLine();

                switch (command.ToUpper())
                {
                    case Command_ViewInventory:
                        ViewInventory();
                        break;
                    case Command_ViewPrices:
                        ViewPrices();
                        break;
                    case Command_BuyParts:
                        BuyParts();
                        break;
                    case Command_SellParts:
                        SellParts();
                        break;
                    case Command_Casino:
                        Casino();
                        break;
                    case Command_Airport:
                        Airport();
                        break;
                    case Command_EndGame:
                        EndGame();
                        return;
                }
            }
            EndGame();
        }

        private void DisplayMenu()
        {
            Graphics.Day(player.CurrentDay);

            Console.WriteLine($" {ThirtyDays - player.CurrentDay} days remaining.");
            Console.WriteLine();
            Console.WriteLine($" You have {player.Money.ToString("C0")}.");
            Console.WriteLine();
            Console.WriteLine(" [1] - View Inventory");
            Console.WriteLine(" [2] - View Prices");
            Console.WriteLine(" [3] - Buy Parts");
            Console.WriteLine(" [4] - Sell Parts");
            Console.WriteLine(" [5] - Casino");
            Console.WriteLine(" [6] - Airport");
            Console.WriteLine();
            Console.WriteLine(" Type \"EXIT\" to end the game");
            Console.WriteLine();
        }

        private void ViewInventory()
        {
            Graphics.Inventory();

            string[] itemNames = player.GetItemName();

            for (int i = 0; i < itemNames.Length; i++)
            {
                Console.WriteLine(" " + itemNames[i].PadRight(20) + "-".PadRight(7) + player.GetItemQuantity(itemNames[i]));
            }
            PressAnyKey();
        }

        private void ViewPrices()
        {
            Graphics.Prices();

            foreach (KeyValuePair<string, int> part in partsList)
            {
                Console.WriteLine(" " + part.Key.PadRight(20) + "-".PadRight(7) + part.Value.ToString("C0"));
            }

            PressAnyKey();
        }

        private void BuyParts()
        {
            Graphics.BuyParts();

            Console.WriteLine($" You have {player.Money.ToString("C0")}.");
            Console.WriteLine();

            foreach (KeyValuePair<string, int> part in partsList)
            {
                Console.WriteLine(" " + part.Key.PadRight(20) + "-".PadRight(7) + part.Value.ToString("C0"));
            }

            Console.WriteLine();

            string buyPartName = CheckInput.GetString(" Enter the name of the part to purchase (case sensitive):");
            int buyPartQuantity = CheckInput.GetInteger(" How many do you want to purchase?");

            if (partsList.ContainsKey(buyPartName))
            {
                if (player.Money >= (buyPartQuantity * partsList[buyPartName]))
                {
                    player.IncreaseQuantity(buyPartName, buyPartQuantity);
                    int purchaseCost = buyPartQuantity * partsList[buyPartName];
                    player.Money -= purchaseCost;

                    Console.WriteLine();
                    Console.WriteLine($" You purchased {buyPartQuantity} {buyPartName.ToLower()} for {purchaseCost.ToString("C0")}.");
                    PressAnyKey();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(" You do not have enough money to complete this purchase.");
                    PressAnyKey();
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($" {buyPartName} is not a valid part name. Please try again.");
                PressAnyKey();
            }
        }

        private void SellParts()
        {
            Graphics.SellParts();

            Console.WriteLine(" [YOUR INVENTORY]");
            string[] itemNames = player.GetItemName();

            for (int i = 0; i < itemNames.Length; i++)
            {
                Console.WriteLine(" " + itemNames[i].PadRight(20) + "-".PadRight(7) + player.GetItemQuantity(itemNames[i]));
            }

            Console.WriteLine();

            Console.WriteLine(" [CURRENT PRICES]");
            foreach (KeyValuePair<string, int> part in partsList)
            {
                Console.WriteLine(" " + part.Key.PadRight(20) + "-".PadRight(7) + part.Value.ToString("C0"));
            }

            Console.WriteLine();

            string sellPartName = CheckInput.GetString("Enter the name of the part to sell (case sensitive):");
            int sellPartQuantity = CheckInput.GetInteger(" How many do you want to sell?");

            if (partsList.ContainsKey(sellPartName))
            {
                if (player.GetItemQuantity(sellPartName) >= sellPartQuantity)
                {
                    player.DecreaseQuantity(sellPartName, sellPartQuantity);
                    int totalSale = sellPartQuantity * partsList[sellPartName];
                    player.Money += totalSale;

                    Console.WriteLine();
                    Console.WriteLine($" You sold {sellPartQuantity} {sellPartName.ToLower()} for {totalSale.ToString("C0")}.");
                    PressAnyKey();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($" You do not have {sellPartQuantity} {sellPartName.ToLower()} to sell.");
                    PressAnyKey();
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($" {sellPartName} is not a valid part name. Please try again.");
                PressAnyKey();
            }
        }

        private void Casino()
        {
            Graphics.Casino();

            Console.WriteLine($" You have {player.Money.ToString("C0")}.");
            Console.WriteLine();
            int gambleAmount = CheckInput.GetInteger(" Enter an amount to gamble:");

            Random r = new Random();

            if (r.Next(1, 101) > 60)
            {
                Console.WriteLine();
                Console.WriteLine(" YOU WON " + (gambleAmount).ToString("C0") + "!");
                player.Money += gambleAmount;
                PressAnyKey();

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(" OH NO! You lost " + gambleAmount.ToString("C0") + ".");
                player.Money -= gambleAmount;
                PressAnyKey();
            }
        }

        private void Airport()
        {
            Graphics.Airport();

            Console.WriteLine(" Traveling to a new city ... ");
            PressAnyKey();
            partsList = RandomizePrices();
            player.CurrentDay++;
        }

        private Dictionary<string, int> RandomizePrices()
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
                {"RAM Sticks",ramPrice},
                {"Flash Drives", fshPrice}
            };

            return partsList;
        }

        private void PressAnyKey()
        {
            Console.WriteLine();
            Console.Write(" *** PRESS ANY KEY TO CONTINUE *** ");
            Console.ReadKey();
        }

        private void EndGame()
        {
            Graphics.GameOver();

            Console.WriteLine($" You ended the game with {player.Money.ToString("C0")}.  ");

            Console.ReadKey();
        }
    }
}