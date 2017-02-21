using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWars
{
    public class CheckInput
    {      
        public static int GetInteger(string message)
        {
            string userInput = String.Empty;
            int intValue = 0;
            bool invalidEntry = false;

            do
            {
                if (invalidEntry)
                {
                    Console.WriteLine(" Please enter a number.");
                }

                Console.Write(message + " ");
                userInput = Console.ReadLine();
                invalidEntry = true;
            }
            while (!int.TryParse(userInput, out intValue));

            return intValue;
        }
      
        public static string GetString(string message)
        {
            string userInput = String.Empty;
            bool invalidEntry = false;

            do
            {
                if (invalidEntry)
                {
                    Console.WriteLine(" Please enter a valid part name.");
                }

                Console.Write(message + " ");
                userInput = Console.ReadLine();
                invalidEntry = true;
            }
            while (String.IsNullOrEmpty(userInput));

            return userInput;
        }
    }
}