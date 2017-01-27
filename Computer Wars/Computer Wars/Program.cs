using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerWars.ArtFiles;
using ComputerWars.Tasks;

namespace Computer_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize inventory
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            inventory = Tasks.ResetInventory();

            // initialize and randomize parts prices
            Dictionary<string, int> partsList = new Dictionary<string, int>();
            partsList = Tasks.ChangePartPrices();

            // initialize variables
            int dayCount = 1;
            int wallet = 1000;

            // welcome screen
            ArtFiles.Title();
            Tasks.DisplaySplashPage();

            // instructions screen
            ArtFiles.Title();
            Tasks.DisplayInstructions();

            while(true)
            {
                if (dayCount > 30)
                {
                    break;
                }

                // main menu
                // TODO - Turn menu into method
                Console.Clear();
                ArtFiles.PrintDayGraphic(dayCount);
                Console.WriteLine($" You have {30 - dayCount} days remaining.\n");
                Console.WriteLine($" You have {wallet.ToString("C")} in your wallet.\n");
                Console.WriteLine($" Please make a selection (by number):\n");
                Console.WriteLine(" 1. Check today's prices of parts");
                Console.WriteLine(" 2. Check inventory");
                Console.WriteLine(" 3. Buy parts");
                Console.WriteLine(" 4. Sell parts");
                Console.WriteLine(" 5. Deposit money at bank");
                Console.WriteLine(" 6. Gamble at the casino");
                Console.WriteLine(" 7. Fly to a new city\n");
                Console.WriteLine(" Type \"EXIT\" to end the game\n");
                Console.Write(" Selection #: ");

                string menuInput = Console.ReadLine();

                // exits menu when exit is typed
                if (menuInput.ToUpper() == "EXIT")
                {
                    break;
                }

                // menu options

                // display part prices
                if (menuInput == "1")
                {
                    Console.Clear();
                    ArtFiles.Prices();
                    Tasks.DisplayPrices(partsList);
                    Console.WriteLine("\n\n ***** PRESS ANY KEY TO RETURN TO THE MENU *****");
                    Console.ReadKey();
                    Console.Clear();
                }

                // check inventory
                if (menuInput == "2")
                {
                    Console.Clear();
                    ArtFiles.Inventory();
                    Tasks.DisplayInventory(inventory);
                    Console.WriteLine("\n ***** PRESS ANY KEY TO RETURN TO THE MENU *****");
                    Console.ReadKey();
                    Console.Clear();
                }

                // buy parts
                // TODO - turn buy parts action into method
                if (menuInput == "3")
                {
                    Console.Clear();
                    ArtFiles.BuyParts();
                    Tasks.DisplayPrices(partsList);

                    Console.Write("\n Enter the number for the part you wish to purchase: ");
                    string buyPartChoice = Console.ReadLine();

                    Console.Write(" How many do you want to purchase? ");
                    int buyNumberOfParts = int.Parse(Console.ReadLine());

                    // buy processors
                    if (buyPartChoice == "1")
                    {
                        int partCost = partsList["Processors"];

                        if (buyNumberOfParts * partCost > wallet)
                        {
                            Tasks.NotEnoughMoney();
                        }
                        else
                        {
                            int totalCost = partCost * buyNumberOfParts;
                            inventory["Processors"] += buyNumberOfParts;
                            wallet -= totalCost;
                            Console.WriteLine($"\n You purchased {buyNumberOfParts} processors for {totalCost.ToString("C")}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }

                    // buy GPU
                    if (buyPartChoice == "2")
                    {
                        int partCost = partsList["Graphics Cards"];

                        if (buyNumberOfParts * partCost > wallet)
                        {
                            Tasks.NotEnoughMoney();
                        }
                        else
                        {
                            int totalCost = partCost * buyNumberOfParts;
                            inventory["Graphics Cards"] += buyNumberOfParts;
                            wallet -= totalCost;
                            Console.WriteLine($"\n You purchased {buyNumberOfParts} graphics cards for {totalCost.ToString("C")}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }

                    // buy hard drives
                    if (buyPartChoice == "3")
                    {
                        int partCost = partsList["Hard Drives"];

                        if (buyNumberOfParts * partCost > wallet)
                        {
                            Tasks.NotEnoughMoney();
                        }
                        else
                        {
                            int totalCost = partCost * buyNumberOfParts;
                            inventory["Hard Drives"] += buyNumberOfParts;
                            wallet -= totalCost;
                            Console.WriteLine($"\n You purchased {buyNumberOfParts} hard drives for {totalCost.ToString("C")}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }

                    // buy ram sticks
                    if (buyPartChoice == "4")
                    {
                        int partCost = partsList["RAM Sticks"];

                        if (buyNumberOfParts * partCost > wallet)
                        {
                            Tasks.NotEnoughMoney();
                        }
                        else
                        {
                            int totalCost = partCost * buyNumberOfParts;
                            inventory["RAM Sticks"] += buyNumberOfParts;
                            wallet -= totalCost;
                            Console.WriteLine($"\n You purchased {buyNumberOfParts} RAM sticks for {totalCost.ToString("C")}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }

                    // buy flash drives
                    if (buyPartChoice == "5")
                    {
                        int partCost = partsList["Flash Drives"];

                        if (buyNumberOfParts * partCost > wallet)
                        {
                            Tasks.NotEnoughMoney();
                        }
                        else
                        {
                            int totalCost = partCost * buyNumberOfParts;
                            inventory["Flash Drives"] += buyNumberOfParts;
                            wallet -= totalCost;
                            Console.WriteLine($"\n You purchased {buyNumberOfParts} flash drives for {totalCost.ToString("C")}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                }

                // sell parts
                // TODO - show current inventory beside part prices
                // TODO - turn sell parts action into method
                if (menuInput == "4")
                {
                    Console.Clear();
                    ArtFiles.SellParts();
                    Tasks.DisplayPrices(partsList);

                    Console.Write("\n Enter the number for the part you wish to sell: ");
                    string buyPartChoice = Console.ReadLine();

                    Console.Write(" How many do you want to sell? ");
                    int sellNumberOfParts = int.Parse(Console.ReadLine());

                    // sell processors
                    if (buyPartChoice == "1")
                    {
                        int partCost = partsList["Processors"];

                        if (sellNumberOfParts > inventory["Processors"])
                        {
                            Tasks.NotEnoughInInventory("Processors");
                        }
                        else
                        {
                            int totalRevenue = sellNumberOfParts * partCost;
                            inventory["Processors"] -= sellNumberOfParts;
                            wallet += totalRevenue;
                            Console.WriteLine($"\n You sold {sellNumberOfParts} processors for {totalRevenue.ToString("C")}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }

                    // sell graphics cards
                    if (buyPartChoice == "2")
                    {
                        int partCost = partsList["Graphics Cards"];

                        if (sellNumberOfParts > inventory["Graphics Cards"])
                        {
                            Tasks.NotEnoughInInventory("Graphics Cards");
                        }
                        else
                        {
                            int totalRevenue = sellNumberOfParts * partCost;
                            inventory["Graphics Cards"] -= sellNumberOfParts;
                            wallet += totalRevenue;
                            Console.WriteLine($"\n You sold {sellNumberOfParts} graphics cards for {totalRevenue.ToString("C")}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }

                    // sell hard drives
                    if (buyPartChoice == "3")
                    {
                        int partCost = partsList["Hard Drives"];

                        if (sellNumberOfParts > inventory["Hard Drives"])
                        {
                            Tasks.NotEnoughInInventory("Hard Drives");
                        }
                        else
                        {
                            int totalRevenue = sellNumberOfParts * partCost;
                            inventory["Hard Drives"] -= sellNumberOfParts;
                            wallet += totalRevenue;
                            Console.WriteLine($"\n You sold {sellNumberOfParts} hard drives for {totalRevenue.ToString("C")}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }

                    // sell ram sticks
                    if (buyPartChoice == "4")
                    {
                        int partCost = partsList["RAM Sticks"];

                        if (sellNumberOfParts > inventory["RAM Sticks"])
                        {
                            Tasks.NotEnoughInInventory("RAM Sticks");
                        }
                        else
                        {
                            int totalRevenue = sellNumberOfParts * partCost;
                            inventory["RAM Sticks"] -= sellNumberOfParts;
                            wallet += totalRevenue;
                            Console.WriteLine($"\n You sold {sellNumberOfParts} ram sticks for {totalRevenue.ToString("C")}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }

                    // sell flash drives
                    if (buyPartChoice == "5")
                    {
                        int partCost = partsList["Flash Drives"];

                        if (sellNumberOfParts > inventory["Flash Drives"])
                        {
                            Tasks.NotEnoughInInventory("Flash Drives");
                        }
                        else
                        {
                            int totalRevenue = sellNumberOfParts * partCost;
                            inventory["Flash Drives"] -= sellNumberOfParts;
                            wallet += totalRevenue;
                            Console.WriteLine($"\n You sold {sellNumberOfParts} flash drives for {totalRevenue.ToString("C")}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }

                } // end of selling

                // bank
                // TODO - create deposit and interest logic
                // TODO - turn bank action into method
                if (menuInput == "5")
                {
                    Console.Clear();
                    ArtFiles.Bank();
                    Console.WriteLine("\n\n This function has not been implemented.");
                    Console.WriteLine("\n ***** PRESS ANY KEY TO RETURN TO THE MENU *****");
                    Console.ReadKey();
                    Console.Clear();
                }

                // casino
                // TODO - turn casino into method
                if (menuInput == "6")
                {
                    Console.Clear();
                    ArtFiles.Casino();
                    Console.WriteLine($"\n You currently have {wallet.ToString("C")} in your wallet.");
                    int gambleAmount;

                    while (true)
                    {
                        Console.Write("\n Enter the amount that you would like to gamble: $");

                        gambleAmount = int.Parse(Console.ReadLine());
                        
                        // check for valid gamble amount
                        if (gambleAmount > wallet / 2)
                        {
                            Console.WriteLine(" You can only gamble half of the amount in your wallet.\n");
                        }
                        else
                        {
                            break;
                        }
                    }

                    // new random percentage of chance
                    Random gambleRandom = new Random();
                    int gambleOdds = gambleRandom.Next(1, 101);

                    // if won
                    if (gambleOdds > 55)
                    {
                        int gambleWinnings = gambleRandom.Next(gambleAmount / 2, gambleAmount * 2);
                        wallet += gambleWinnings;
                        Console.WriteLine($" YOU WON! You risked {gambleAmount.ToString("C")} and won {gambleWinnings.ToString("C")}.");
                    }

                    else
                    {
                        Console.WriteLine($" OH NO! You lost {gambleAmount.ToString("C")}.");
                        wallet -= gambleAmount;
                    }

                    Console.ReadKey();
                    Console.Clear();
                }

                // new city
                if (menuInput == "7")
                {
                    Console.Clear();
                    ArtFiles.Airport();
                    Console.WriteLine("\n\n Flying to a new city...........");
                    Console.ReadKey();

                    // perform tasks after day has ended
                    partsList = Tasks.ChangePartPrices();
                    dayCount++;
                    Console.Clear();
                }


            } // end of game while loops

            Console.Clear();
            ArtFiles.GameOver();
            Console.WriteLine($"\n\n You ended with {wallet.ToString("C")} and the following parts:\n\n");
            Tasks.DisplayInventory(inventory);
            Console.WriteLine("\n\n\n\n");
            Console.ReadKey();
        }
    }
}