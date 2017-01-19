using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>()
            {
                {"Processors", 0},
                {"Graphics Cards", 0},
                {"Hard Drives",0},
                {"RAM Cards",0},
                {"Flash Drives", 0}
            };

            //variable declaration
            int wallet = 500;
            int depositAccount = 0;
            int dayCount = 1;
            string currentCity = "Cleveland";
            bool hasGambled = false;
            bool stolenIdentity = false;
            int stolenMoney = 0;


            // parts stolen
            Console.WriteLine("OH NO! Your thieving neighbor broke into your house during the night and stole half of your computer parts!");

            foreach(KeyValuePair<string, int> kvp in inventory)
            {
                inventory[kvp.Key] /= 2;
            }

            // identity stolen
            Console.WriteLine("OH NO! Your thieving neighbor found your personal information in your trash and used it to take all of your money from your bank account!");
            stolenMoney = depositAccount;
            stolenIdentity = true;
            depositAccount = 0;

            // interest increase
            Console.WriteLine($"GOOD NEWS! Interests rates were through the roof yesterday! Your new bank account balance is ${depositAccount}.");

            // wallet stolen
            Console.WriteLine($"OH NO! Your wallet got stolen while you were at the airport. You lost ${wallet} that you had in your wallet.");
            wallet = 0;

            // flight delay
            Console.WriteLine($"OH NO! Your flight got delayed for an entire day. It is now Day {dayCount + 1}.");
            dayCount++;

            // plane crash, end game
            Console.WriteLine($"OH NO! Your plane crashed during your flight from {currentCity}.");

            // traffic after leaving LA
            Console.WriteLine("OH NO! Traffic in Los Angeles was terrible on your way to the airport.");
            Console.WriteLine($"You missed your flight and had to wait until the next day to fly out. It is now Day {dayCount + 1}");

            // part prices in LA
            Console.WriteLine("GOOD NEWS! Part prices are insanely low in Los Angeles today. Buy everything that you can!");

            // identity recovered
            Console.WriteLine($"GOOD NEWS! The bank credited ${stolenMoney} back to your account from when your neighbor stole your account information.");
            stolenIdentity = false;
            depositAccount += stolenMoney;
            stolenMoney = 0;


        }
    }
}
