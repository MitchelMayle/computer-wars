using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Computer_Wars.ArtFiles;
using Computer_Wars.Tasks;

namespace Test_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize art and tasks
            ArtFiles printArt = new ArtFiles();
            Tasks doTask = new Tasks();

            // initialize inventory
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            inventory = doTask.ResetInventory();

            // initialize and randomize parts prices
            Dictionary<string, int> partsList = new Dictionary<string, int>();
            partsList = doTask.ChangePartPrices();

            // initialize variables
            int dayCount = 1;
            int wallet = 500;

            // welcome screens
            printArt.Title();
            doTask.DisplaySplashPage();

            // instructions screen
            printArt.Title();
            doTask.DisplayInstructions();

            //game begins
            while (dayCount < 31)
            {
                //main menu
                Menu:
                Console.Clear();
                printArt.PrintDayGraphic(dayCount);
                Console.WriteLine($" You have {30 - dayCount} days remaining.\n");
                Console.WriteLine($" You have ${wallet} in your wallet.\n");
                Console.WriteLine($" Please make a selection (by number):\n");
                Console.WriteLine(" 1. Check today's prices of parts");
                Console.WriteLine(" 2. Check inventory at your house");
                Console.WriteLine(" 3. Buy parts");
                Console.WriteLine(" 4. Sell parts");
                Console.WriteLine(" 5. Deposit money at bank");
                Console.WriteLine(" 6. Gamble at the casino");
                Console.WriteLine(" 7. Fly to a new city\n");
                Console.WriteLine(" Type \"EXIT\" to end the game\n");
                Console.Write(" Selection #: ");

                string menuInput = Console.ReadLine();

                // exits when exit is typed
                if (menuInput.ToUpper() == "EXIT")
                {
                    break;
                }

                // checks for valid input choice not "exit"
                int menuChoice;
                bool checkInput = int.TryParse(menuInput, out menuChoice);

                // if choice is invalid, go back to Menu
                if (!checkInput)
                {
                    goto Menu;
                }

                // menu options
                switch (menuChoice)
                {
                    case 1: // CHECK PRICES
                        Console.Clear();
                        printArt.Prices();
                        doTask.DisplayParts(partsList);
                        Console.WriteLine("\n ***** PRESS ANY KEY TO RETURN TO THE MENU *****");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2: //CHECK INVENTORY
                        Console.Clear();
                        printArt.Inventory();
                        doTask.DisplayParts(inventory);
                        Console.WriteLine("\n ***** PRESS ANY KEY TO RETURN TO THE MENU *****");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3: //BUY PARTS
                        Console.Clear();
                        printArt.BuyParts();
                        doTask.DisplayParts(partsList);
                        Console.WriteLine("\n\n This function has not been implemented.");
                        Console.WriteLine("\n ***** PRESS ANY KEY TO RETURN TO THE MENU *****");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4: //SELL PARTS
                        Console.Clear();
                        printArt.SellParts();
                        doTask.DisplayParts(partsList);
                        Console.WriteLine("\n\n This function has not been implemented.");
                        Console.WriteLine("\n ***** PRESS ANY KEY TO RETURN TO THE MENU *****");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5: //BANK
                        Console.Clear();
                        printArt.Bank();
                        Console.WriteLine("\n\n This function has not been implemented.");
                        Console.WriteLine("\n ***** PRESS ANY KEY TO RETURN TO THE MENU *****");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 6: //CASINO
                        Console.Clear();
                        printArt.Casino();
                        Console.WriteLine($"\n You currently have ${wallet} in your wallet.");

                        int gambleAmount;
                        while (true)
                        {
                            Console.Write("\n Enter the amount that you would like to gamble: $");
                            gambleAmount = int.Parse(Console.ReadLine());

                            // check for valid gamble amount
                            if (gambleAmount > wallet)
                            {
                                Console.WriteLine($" You do not have ${gambleAmount}, you have ${wallet}.\n");
                            }
                            else
                            {
                                break;
                            }
                        }

                        // new random percentage of chance
                        Random gambleRandom = new Random();
                        int gambleOdds = gambleRandom.Next(1, 101);

                        if (gambleOdds > 60)
                        {
                            int gambleWinnings = gambleRandom.Next(gambleAmount / 2, gambleAmount);
                            wallet += gambleWinnings;
                            Console.WriteLine($" YOU WON! You risked ${gambleAmount} and won ${gambleWinnings}.");

                        }

                        else
                        {
                            Console.WriteLine($" OH NO! You lost ${gambleAmount}.");
                            wallet -= gambleAmount;
                        }


                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 7: //NEW CITY
                        Console.Clear();
                        printArt.Airport();
                        Console.WriteLine("\n\n Flying to a new city...........");
                        Console.ReadKey();

                        // perform tasks after day has ended
                        partsList = doTask.ChangePartPrices();
                        dayCount++;
                        Console.Clear();
                        break;

                    default:
                        goto Menu;
                }

            }//end of while loop of game

            //end of game stuff
            Console.Clear();
            printArt.GameOver();
            Console.WriteLine($"\n\n You ended with ${wallet}.");
            Console.ReadKey();
        }
    }
}
