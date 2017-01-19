using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Computer_Wars.Events;
using Computer_Wars.Graphics;


namespace Computer_Wars
{
    class Program
    {
        static void Main(string[] args)
        {



            /* TO DO
             * 
             * -Create choice class to use method on choice given
             * 
               - Develop system for random events in between days
                    -- neighbor stealing half of items (10%)
                    -- neighbor stealing identity (5%)
                    -- prices for items going up/down (90%)
                        -- should all prices change every day?
                    -- bank returning high interest (10%)
                    -- wallet stolen at the airport (5%)
                    -- killed in plane crash (3%)
                    -- flight delayed, lose a day (10%)
                    -- recover stolen money from neighbor
                    -- gain random amount of parts for free (10%)

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

            // variables for methods
            Graphics.Graphics graphicPrint = new Graphics.Graphics();
            Events.Events eventAction = new Events.Events();

            //create empty inventory
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            inventory = eventAction.ResetInvetory();

            //randomize parts
            Dictionary<string, int> partsList = new Dictionary<string, int>();
            partsList = eventAction.ChangePartPrices();


            //variable declaration
            int wallet = 500;
            int depositAccount = 0;
            int dayCount = 1;
            string currentCity = "Cleveland";
            bool hasGambled = false;
            bool stolenIdentity = false;
            int stolenMoney = 0;

            //method to display title?
            graphicPrint.PrintTitle();
            Console.WriteLine("v0.1A");
            Console.WriteLine("Created by Mitchel Mayle III");
            Console.WriteLine("\n\n\n\n\n\n");
            Console.Write("***** PRESS ANY KEY TO START *****");
            Console.ReadKey();
            Console.Clear();

            // introduction, add more description and hazards
            graphicPrint.PrintTitle();

            eventAction.PrintInstructions();

            //pause
            Console.ReadKey();
            Console.Clear();

            // method to display graphic for each day?
            graphicPrint.PrintDayGraphic(dayCount);

            // create method to hold this information to begin new day, calculate interest at beginning of day, set bools back to false
            Console.WriteLine($"Welcome to {currentCity}! You have {30 - dayCount} days remaining.\n");
            Console.WriteLine($"You have ${wallet} in your wallet.\n");
            Console.WriteLine($"Your bank account has a balance of ${depositAccount}.\n");
            Console.WriteLine($"Please make a selection (by number):\n");

            // create method to display choices
            Console.WriteLine("1. Check today's prices of parts");
            Console.WriteLine("2. Check inventory at your house");
            Console.WriteLine("3. Buy parts");
            Console.WriteLine("4. Sell parts");
            Console.WriteLine("5. Deposit money at bank");
            Console.WriteLine($"6. Gamble at the {currentCity} casino");
            Console.WriteLine("7. Fly to a new city\n");
            Console.WriteLine("Type \"EXIT\" to end the game");

            Console.Write("Selection #: ");
            string daySelect = Console.ReadLine();

            //pause
            Console.ReadKey();
            Console.Clear();

            // create method to display prices
            graphicPrint.PartPrices();
            Console.WriteLine($"Today's part prices in {currentCity}:\n");

            foreach (KeyValuePair<string, int> kvp in partsList)
            {
                Console.WriteLine($"{kvp.Key.PadRight(17)}-{kvp.Value.ToString().PadLeft(5)}");
            }

            Console.WriteLine("\n***** PRESS ANY KEY TO RETURN TO THE MENU *****");

            //pause
            Console.ReadKey();
            Console.Clear();

            // create method to display inventory
            eventAction.Inventory();
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
            Console.WriteLine($"Welcome to the {currentCity} airport!");
            Console.WriteLine("Select the city (by number) that you want to fly to: (This will end your current day and change part prices)\n");
            Console.WriteLine("1. Cleveland");
            Console.WriteLine("2. Pittsburgh");
            Console.WriteLine("3. Chicago");
            Console.WriteLine("4. Atlanta");
            Console.WriteLine("5. Seattle");
            Console.WriteLine("6. Las Vegas");
            Console.WriteLine("7. Los Angeles\n");
            Console.WriteLine("Type \"EXIT\" to return to the menu.");
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
            Console.WriteLine($"Welcome to Generic Credit Union of {currentCity}.\n");
            Console.WriteLine($"You have ${wallet} in your wallet.");
            Console.WriteLine($"Your bank account contains ${depositAccount}.\n");
            Console.WriteLine();
            Console.Write("Would you like to make a (D)eposit, (W)ithdraw? (Type \"EXIT\" to return to the menu: ");
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

            Console.Write("Please enter a dollar amount that you would like to gamble. (Type \"EXIT\" to return to the menu): $");
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

            Console.WriteLine($"Today's part prices in {currentCity}:\n");

            foreach (KeyValuePair<string, int> kvp in partsList)
            {
                Console.WriteLine($"{kvp.Key.PadRight(17)}-{kvp.Value.ToString().PadLeft(5)}");
            }

            Console.WriteLine();
            Console.Write("Select a part you would like to sell: (Type \"EXIT\" to return to the menu: ");
            string sellInput = Console.ReadLine();
            Console.Write($"Enter the number of {sellInput}s you would like to sell: ");
            int sellNumber = int.Parse(Console.ReadLine());

            //pause
            Console.ReadKey();
            Console.Clear();

            // create method for buying items
            Console.WriteLine();
            Console.WriteLine(" ██████╗ ██╗   ██╗██╗   ██╗    ██████╗  █████╗ ██████╗ ████████╗███████╗");
            Console.WriteLine(" ██╔══██╗██║   ██║╚██╗ ██╔╝    ██╔══██╗██╔══██╗██╔══██╗╚══██╔══╝██╔════╝");
            Console.WriteLine(" ██████╔╝██║   ██║ ╚████╔╝     ██████╔╝███████║██████╔╝   ██║   ███████╗");
            Console.WriteLine(" ██╔══██╗██║   ██║  ╚██╔╝      ██╔═══╝ ██╔══██║██╔══██╗   ██║   ╚════██║");
            Console.WriteLine(" ██████╔╝╚██████╔╝   ██║       ██║     ██║  ██║██║  ██║   ██║   ███████║");
            Console.WriteLine(" ╚═════╝  ╚═════╝    ╚═╝       ╚═╝     ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   ╚══════╝");
            Console.WriteLine();

            Console.WriteLine($"Today's part prices in {currentCity}:\n");

            foreach (KeyValuePair<string, int> kvp in partsList)
            {
                Console.WriteLine($"{kvp.Key.PadRight(17)}-{kvp.Value.ToString().PadLeft(5)}");
            }

            Console.WriteLine();
            Console.Write("Select a part you would like to purchase: (Type \"EXIT\" to return to the menu: ");
            string buyInput = Console.ReadLine();
            Console.Write($"Enter the number of {buyInput}s you would like to purchase: ");
            int buyNumber = int.Parse(Console.ReadLine());


            //pause
            Console.ReadKey();
            Console.Clear();
        }
    }
}
