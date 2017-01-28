using System;
using System.Collections.Generic;
using ComputerWars.ArtFiles;
using ComputerWars.Tasks;

namespace ComputerWars.Player
{
    public class Player
    {
        public int Wallet { get; set; }

        public Dictionary<string, int> inventory = new Dictionary<string, int>()
            {
                { "Processors", 0},
                { "Graphics Cards", 0},
                { "Hard Drives",0},
                { "RAM Sticks",0},
                { "Flash Drives", 0}
            };

        // price change events
        public Dictionary<string, int> RandomPriceEvent(Dictionary<string, int> partsList)
        {
            Random r = new Random();
            int eventChance = r.Next(1, 101);

            // processors price low
            if (eventChance < 11)
            {
                Console.Clear();
                ArtFiles.ArtFiles.GetEvent("good");

                Random p = new Random();
                int processorLowPrice = p.Next(800, 1001);
                partsList["Processors"] = processorLowPrice;

                Console.WriteLine($" Processor prices dropped dramatically overnight to {processorLowPrice.ToString("C0")} each!");
                Console.WriteLine("\n\n\n ***** PRESS ANY KEY TO CONTINUE *****");

                Console.ReadKey();
                Console.Clear();
                return partsList;
            }

            // part prices doubled
            if (eventChance < 21)
            {
                Console.Clear();
                ArtFiles.ArtFiles.GetEvent("good");

                partsList["Processors"] *= 2;
                partsList["Graphics Cards"] *= 2;
                partsList["Hard Drives"] *= 2;
                partsList["RAM Sticks"] *= 2;
                partsList["Flash Drives"] *= 2;

                Console.WriteLine(" All prices of parts skyrocketed overnight to twice their normal values.");
                Console.WriteLine("\n\n\n ***** PRESS ANY KEY TO CONTINUE *****");
                Console.ReadKey();
                Console.Clear();
                return partsList;
            }

            return partsList;
        } // end of price change events

        // wallet events
        public void RandomWalletEvents()
        {
            Random r = new Random();
            int eventChance = r.Next(1, 101);

            if (eventChance < 11)
            {
                Console.Clear();
                ArtFiles.ArtFiles.GetEvent("bad");

                Wallet /= 2;

                Console.WriteLine(" You got mugged at the airport and half of your money was stolen!");
                Console.WriteLine("\n\n\n ***** PRESS ANY KEY TO CONTINUE *****");

                Console.ReadKey();
                Console.Clear();
            }

            else if (eventChance < 21)
            {
                Console.Clear();
                ArtFiles.ArtFiles.GetEvent("good");

                int investment = Wallet / 2;
                Wallet += investment;

                Console.WriteLine($" Your banking investments that you completely forgot about finally paid out! {investment.ToString("C0")} has been added to your wallet.");
                Console.WriteLine("\n\n\n ***** PRESS ANY KEY TO CONTINUE *****");

                Console.ReadKey();
                Console.Clear();
            }
        } // end of wallet events
    }
}
