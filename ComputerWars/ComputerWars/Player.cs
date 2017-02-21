using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWars
{
    public class Player
    {
        public Player()
        {
            Money = 1000;
            CurrentDay = 1;
        }

        public int Money { get; set; }

        public int CurrentDay { get; set; }

        private Dictionary<string, int> inventory = new Dictionary<string, int>()
        {
            {"Processors", 0 },
            {"Grpahics Cards", 0 },
            {"Hard Drives", 0 },
            {"RAM Sticks", 0 },
            {"Flash Drives", 0 }
        };

        public string[] GetItemName()
        {
            List<string> itemNames = new List<string>();

            foreach (KeyValuePair<string, int> kvp in inventory)
            {
                itemNames.Add(kvp.Key);
            }

            return itemNames.ToArray();
        }

        public int GetItemQuantity(string itemName)
        {
            return inventory[itemName];
        }

        public void IncreaseQuantity(string partName, int increaseAmount)
        {
            inventory[partName] += increaseAmount;
        }

        public void DecreaseQuantity(string partName, int decreaseAmount)
        {
            inventory[partName] -= decreaseAmount;
        }
    }
}