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

        //}


        // randomize parts prices after each day
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

        // parts stolen from your house
        public void PartsStolen()
        {
            Console.Clear();
      
            Console.WriteLine("OH NO! Your thieving neighbor found your personal information in your trash and used it to take all of your money from your bank account!");
            stolenMoney = depositAccount;
            stolenIdentity = true;
            depositAccount = 0;
        }

    }
}
