using System;
using System.Collections.Generic;
using ComputerWars.ArtFiles;
using ComputerWars.Tasks;
using ComputerWars.Player;

namespace Computer_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize player
            Player player = new Player();
            player.Wallet = 1000;

            // initialize and randomize parts prices
            Dictionary<string, int> partsList = new Dictionary<string, int>();
            partsList = Tasks.ChangePartPrices();

            // initialize day
            int dayCount = 1;

            // welcome screen
            ArtFiles.Title();
            Tasks.DisplaySplashPage();

            // instructions screen
            ArtFiles.Title();
            Tasks.DisplayInstructions();

            while (true)
            {
                // exits game after day 30 is over
                if (dayCount > 30)
                {
                    break;
                }

                // main menu
                // TODO - Turn menu into method
                Console.Clear();
                ArtFiles.PrintDayGraphic(dayCount);

                Console.WriteLine($" You have {30 - dayCount} days remaining.\n");
                Console.WriteLine($" You have {player.Wallet.ToString("C0")} in your wallet.\n");
                Tasks.PrintMenu();

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
                    Tasks.DisplayInventory(player.inventory);
                    Console.WriteLine("\n ***** PRESS ANY KEY TO RETURN TO THE MENU *****");
                    Console.ReadKey();
                    Console.Clear();
                }

                // buy parts
                // TODO - turn buy parts action into player method
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

                        if (buyNumberOfParts * partCost > player.Wallet)
                        {
                            Tasks.NotEnoughMoney();
                        }
                        else
                        {
                            int totalCost = partCost * buyNumberOfParts;
                            player.inventory["Processors"] += buyNumberOfParts;
                            player.Wallet -= totalCost;
                            Console.WriteLine($"\n You purchased {buyNumberOfParts} processors for {totalCost.ToString("C0")}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }

                    // buy GPU
                    if (buyPartChoice == "2")
                    {
                        int partCost = partsList["Graphics Cards"];

                        if (buyNumberOfParts * partCost > player.Wallet)
                        {
                            Tasks.NotEnoughMoney();
                        }
                        else
                        {
                            int totalCost = partCost * buyNumberOfParts;
                            player.inventory["Graphics Cards"] += buyNumberOfParts;
                            player.Wallet -= totalCost;
                            Console.WriteLine($"\n You purchased {buyNumberOfParts} graphics cards for {totalCost.ToString("C0")}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }

                    // buy hard drives
                    if (buyPartChoice == "3")
                    {
                        int partCost = partsList["Hard Drives"];

                        if (buyNumberOfParts * partCost > player.Wallet)
                        {
                            Tasks.NotEnoughMoney();
                        }
                        else
                        {
                            int totalCost = partCost * buyNumberOfParts;
                            player.inventory["Hard Drives"] += buyNumberOfParts;
                            player.Wallet -= totalCost;
                            Console.WriteLine($"\n You purchased {buyNumberOfParts} hard drives for {totalCost.ToString("C0")}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }

                    // buy ram sticks
                    if (buyPartChoice == "4")
                    {
                        int partCost = partsList["RAM Sticks"];

                        if (buyNumberOfParts * partCost > player.Wallet)
                        {
                            Tasks.NotEnoughMoney();
                        }
                        else
                        {
                            int totalCost = partCost * buyNumberOfParts;
                            player.inventory["RAM Sticks"] += buyNumberOfParts;
                            player.Wallet -= totalCost;
                            Console.WriteLine($"\n You purchased {buyNumberOfParts} RAM sticks for {totalCost.ToString("C0")}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }

                    // buy flash drives
                    if (buyPartChoice == "5")
                    {
                        int partCost = partsList["Flash Drives"];

                        if (buyNumberOfParts * partCost > player.Wallet)
                        {
                            Tasks.NotEnoughMoney();
                        }
                        else
                        {
                            int totalCost = partCost * buyNumberOfParts;
                            player.inventory["Flash Drives"] += buyNumberOfParts;
                            player.Wallet -= totalCost;
                            Console.WriteLine($"\n You purchased {buyNumberOfParts} flash drives for {totalCost.ToString("C0")}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                }

                // sell parts
                // TODO - show current inventory beside part prices
                // TODO - turn sell parts action into player method
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

                        if (sellNumberOfParts > player.inventory["Processors"])
                        {
                            Tasks.NotEnoughInInventory("Processors");
                        }
                        else
                        {
                            int totalRevenue = sellNumberOfParts * partCost;
                            player.inventory["Processors"] -= sellNumberOfParts;
                            player.Wallet += totalRevenue;
                            Console.WriteLine($"\n You sold {sellNumberOfParts} processors for {totalRevenue.ToString("C0")}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }

                    // sell graphics cards
                    if (buyPartChoice == "2")
                    {
                        int partCost = partsList["Graphics Cards"];

                        if (sellNumberOfParts > player.inventory["Graphics Cards"])
                        {
                            Tasks.NotEnoughInInventory("Graphics Cards");
                        }
                        else
                        {
                            int totalRevenue = sellNumberOfParts * partCost;
                            player.inventory["Graphics Cards"] -= sellNumberOfParts;
                            player.Wallet += totalRevenue;
                            Console.WriteLine($"\n You sold {sellNumberOfParts} graphics cards for {totalRevenue.ToString("C0")}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }

                    // sell hard drives
                    if (buyPartChoice == "3")
                    {
                        int partCost = partsList["Hard Drives"];

                        if (sellNumberOfParts > player.inventory["Hard Drives"])
                        {
                            Tasks.NotEnoughInInventory("Hard Drives");
                        }
                        else
                        {
                            int totalRevenue = sellNumberOfParts * partCost;
                            player.inventory["Hard Drives"] -= sellNumberOfParts;
                            player.Wallet += totalRevenue;
                            Console.WriteLine($"\n You sold {sellNumberOfParts} hard drives for {totalRevenue.ToString("C0")}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }

                    // sell ram sticks
                    if (buyPartChoice == "4")
                    {
                        int partCost = partsList["RAM Sticks"];

                        if (sellNumberOfParts > player.inventory["RAM Sticks"])
                        {
                            Tasks.NotEnoughInInventory("RAM Sticks");
                        }
                        else
                        {
                            int totalRevenue = sellNumberOfParts * partCost;
                            player.inventory["RAM Sticks"] -= sellNumberOfParts;
                            player.Wallet += totalRevenue;
                            Console.WriteLine($"\n You sold {sellNumberOfParts} ram sticks for {totalRevenue.ToString("C0")}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }

                    // sell flash drives
                    if (buyPartChoice == "5")
                    {
                        int partCost = partsList["Flash Drives"];

                        if (sellNumberOfParts > player.inventory["Flash Drives"])
                        {
                            Tasks.NotEnoughInInventory("Flash Drives");
                        }
                        else
                        {
                            int totalRevenue = sellNumberOfParts * partCost;
                            player.inventory["Flash Drives"] -= sellNumberOfParts;
                            player.Wallet += totalRevenue;
                            Console.WriteLine($"\n You sold {sellNumberOfParts} flash drives for {totalRevenue.ToString("C0")}.");
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
                    Console.WriteLine($"\n You currently have {player.Wallet.ToString("C0")} in your wallet.");
                    int gambleAmount;

                    while (true)
                    {
                        Console.Write("\n Enter the amount that you would like to gamble: $");

                        gambleAmount = int.Parse(Console.ReadLine());

                        // check for valid gamble amount
                        if (gambleAmount > player.Wallet / 2)
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
                        player.Wallet += gambleWinnings;
                        Console.WriteLine($" YOU WON! You risked {gambleAmount.ToString("C0")} and won {gambleWinnings.ToString("C0")}.");
                    }

                    else
                    {
                        Console.WriteLine($" OH NO! You lost {gambleAmount.ToString("C0")}.");
                        player.Wallet -= gambleAmount;
                    }

                    Console.ReadKey();
                    Console.Clear();
                }

                // new city, end day
                if (menuInput == "7")
                {
                    Console.Clear();
                    ArtFiles.Airport();
                    Console.WriteLine("\n\n Flying to a new city...........");
                    Console.ReadKey();

                    // perform tasks after day has ended
                    partsList = Tasks.ChangePartPrices();
                    dayCount++;

                    // random events
                    partsList = player.RandomPriceEvent(partsList);
                    player.RandomWalletEvents();

                    Console.Clear();
                }
            } // end of game while loops

            Console.Clear();
            ArtFiles.GameOver();
            Console.WriteLine($"\n\n You ended with {player.Wallet.ToString("C0")} and the following parts:\n\n");
            Tasks.DisplayInventory(player.inventory);
            Console.WriteLine("\n\n\n\n");
            Console.ReadKey();
        }
    }
}