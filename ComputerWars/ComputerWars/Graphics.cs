using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWars
{
    public class Graphics
    {
        public static void Title()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("  ██████╗ ██████╗ ███╗   ███╗██████╗ ██╗   ██╗████████╗███████╗██████╗     ██╗    ██╗ █████╗ ██████╗ ███████╗  ██╗");
            Console.WriteLine(" ██╔════╝██╔═══██╗████╗ ████║██╔══██╗██║   ██║╚══██╔══╝██╔════╝██╔══██╗    ██║    ██║██╔══██╗██╔══██╗██╔════╝  ██║");
            Console.WriteLine(" ██║     ██║   ██║██╔████╔██║██████╔╝██║   ██║   ██║   █████╗  ██████╔╝    ██║ █╗ ██║███████║██████╔╝███████╗  ██║");
            Console.WriteLine(" ██║     ██║   ██║██║╚██╔╝██║██╔═══╝ ██║   ██║   ██║   ██╔══╝  ██╔══██╗    ██║███╗██║██╔══██║██╔══██╗╚════██║  ╚═╝");
            Console.WriteLine(" ╚██████╗╚██████╔╝██║ ╚═╝ ██║██║     ╚██████╔╝   ██║   ███████╗██║  ██║    ╚███╔███╔╝██║  ██║██║  ██║███████║  ██╗");
            Console.WriteLine("  ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚═╝      ╚═════╝    ╚═╝   ╚══════╝╚═╝  ╚═╝     ╚══╝╚══╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝  ╚═╝\n");
        }

        public static void Prices()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" ██████╗  █████╗ ██████╗ ████████╗    ██████╗ ██████╗ ██╗ ██████╗███████╗███████╗");
            Console.WriteLine(" ██╔══██╗██╔══██╗██╔══██╗╚══██╔══╝    ██╔══██╗██╔══██╗██║██╔════╝██╔════╝██╔════╝");
            Console.WriteLine(" ██████╔╝███████║██████╔╝   ██║       ██████╔╝██████╔╝██║██║     █████╗  ███████╗");
            Console.WriteLine(" ██╔═══╝ ██╔══██║██╔══██╗   ██║       ██╔═══╝ ██╔══██╗██║██║     ██╔══╝  ╚════██║");
            Console.WriteLine(" ██║     ██║  ██║██║  ██║   ██║       ██║     ██║  ██║██║╚██████╗███████╗███████║");
            Console.WriteLine(" ╚═╝     ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝       ╚═╝     ╚═╝  ╚═╝╚═╝ ╚═════╝╚══════╝╚══════╝\n");
        }

        public static void Inventory()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" ██╗███╗   ██╗██╗   ██╗███████╗███╗   ██╗████████╗ ██████╗ ██████╗ ██╗   ██╗");
            Console.WriteLine(" ██║████╗  ██║██║   ██║██╔════╝████╗  ██║╚══██╔══╝██╔═══██╗██╔══██╗╚██╗ ██╔╝");
            Console.WriteLine(" ██║██╔██╗ ██║██║   ██║█████╗  ██╔██╗ ██║   ██║   ██║   ██║██████╔╝ ╚████╔╝ ");
            Console.WriteLine(" ██║██║╚██╗██║╚██╗ ██╔╝██╔══╝  ██║╚██╗██║   ██║   ██║   ██║██╔══██╗  ╚██╔╝  ");
            Console.WriteLine(" ██║██║ ╚████║ ╚████╔╝ ███████╗██║ ╚████║   ██║   ╚██████╔╝██║  ██║   ██║   ");
            Console.WriteLine(" ╚═╝╚═╝  ╚═══╝  ╚═══╝  ╚══════╝╚═╝  ╚═══╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝   ╚═╝   \n");
        }

        public static void Airport()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("  █████╗ ██╗██████╗ ██████╗  ██████╗ ██████╗ ████████╗");
            Console.WriteLine(" ██╔══██╗██║██╔══██╗██╔══██╗██╔═══██╗██╔══██╗╚══██╔══╝");
            Console.WriteLine(" ███████║██║██████╔╝██████╔╝██║   ██║██████╔╝   ██║   ");
            Console.WriteLine(" ██╔══██║██║██╔══██╗██╔═══╝ ██║   ██║██╔══██╗   ██║   ");
            Console.WriteLine(" ██║  ██║██║██║  ██║██║     ╚██████╔╝██║  ██║   ██║   ");
            Console.WriteLine(" ╚═╝  ╚═╝╚═╝╚═╝  ╚═╝╚═╝      ╚═════╝ ╚═╝  ╚═╝   ╚═╝   \n");
        }

        public static void Casino()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("  ██████╗ █████╗ ███████╗██╗███╗   ██╗ ██████╗ ");
            Console.WriteLine(" ██╔════╝██╔══██╗██╔════╝██║████╗  ██║██╔═══██╗");
            Console.WriteLine(" ██║     ███████║███████╗██║██╔██╗ ██║██║   ██║");
            Console.WriteLine(" ██║     ██╔══██║╚════██║██║██║╚██╗██║██║   ██║");
            Console.WriteLine(" ╚██████╗██║  ██║███████║██║██║ ╚████║╚██████╔╝");
            Console.WriteLine("  ╚═════╝╚═╝  ╚═╝╚══════╝╚═╝╚═╝  ╚═══╝ ╚═════╝ \n");
        }

        public static void SellParts()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" ███████╗███████╗██╗     ██╗         ██████╗  █████╗ ██████╗ ████████╗███████╗");
            Console.WriteLine(" ██╔════╝██╔════╝██║     ██║         ██╔══██╗██╔══██╗██╔══██╗╚══██╔══╝██╔════╝");
            Console.WriteLine(" ███████╗█████╗  ██║     ██║         ██████╔╝███████║██████╔╝   ██║   ███████╗");
            Console.WriteLine(" ╚════██║██╔══╝  ██║     ██║         ██╔═══╝ ██╔══██║██╔══██╗   ██║   ╚════██║");
            Console.WriteLine(" ███████║███████╗███████╗███████╗    ██║     ██║  ██║██║  ██║   ██║   ███████║");
            Console.WriteLine(" ╚══════╝╚══════╝╚══════╝╚══════╝    ╚═╝     ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   ╚══════╝\n");
        }

        public static void BuyParts()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" ██████╗ ██╗   ██╗██╗   ██╗    ██████╗  █████╗ ██████╗ ████████╗███████╗");
            Console.WriteLine(" ██╔══██╗██║   ██║╚██╗ ██╔╝    ██╔══██╗██╔══██╗██╔══██╗╚══██╔══╝██╔════╝");
            Console.WriteLine(" ██████╔╝██║   ██║ ╚████╔╝     ██████╔╝███████║██████╔╝   ██║   ███████╗");
            Console.WriteLine(" ██╔══██╗██║   ██║  ╚██╔╝      ██╔═══╝ ██╔══██║██╔══██╗   ██║   ╚════██║");
            Console.WriteLine(" ██████╔╝╚██████╔╝   ██║       ██║     ██║  ██║██║  ██║   ██║   ███████║");
            Console.WriteLine(" ╚═════╝  ╚═════╝    ╚═╝       ╚═╝     ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   ╚══════╝\n");
        }

        public static void Day(int dayCount)
        {
            switch (dayCount)
            {
                case (1):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗     ██╗");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ███║");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝     ╚██║");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝       ██║");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║        ██║");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝        ╚═╝\n");
                    break;

                case (2):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗    ██████╗ ");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ╚════██╗");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝      █████╔╝");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝      ██╔═══╝ ");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║       ███████╗");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝       ╚══════╝\n");
                    break;

                case (3):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗    ██████╗ ");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ╚════██╗");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝      █████╔╝");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝       ╚═══██╗");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║       ██████╔╝");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝       ╚═════╝\n");
                    break;

                case (4):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗    ██╗  ██╗");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ██║  ██║");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝     ███████║");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝      ╚════██║");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║            ██║");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝            ╚═╝\n");
                    break;

                case (5):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗    ███████╗");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ██╔════╝");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝     ███████╗");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝      ╚════██║");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║       ███████║");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝       ╚══════╝\n");
                    break;

                case (6):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗     ██████╗ ");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ██╔════╝ ");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝     ███████╗ ");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝      ██╔═══██╗");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║       ╚██████╔╝");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝        ╚═════╝\n");
                    break;

                case (7):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗    ███████╗");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ╚════██║");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝         ██╔╝");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝         ██╔╝ ");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║          ██║  ");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝          ╚═╝\n");
                    break;

                case (8):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗     █████╗ ");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ██╔══██╗");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝     ╚█████╔╝");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝      ██╔══██╗");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║       ╚█████╔╝");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝        ╚════╝\n");
                    break;

                case (9):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗     █████╗ ");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ██╔══██╗");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝     ╚██████║");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝       ╚═══██║");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║        █████╔╝");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝        ╚════╝\n");
                    break;

                case (10):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗     ██╗ ██████╗ ");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ███║██╔═████╗");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝     ╚██║██║██╔██║");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝       ██║████╔╝██║");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║        ██║╚██████╔╝");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝        ╚═╝ ╚═════╝\n");
                    break;

                case (11):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗     ██╗ ██╗");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ███║███║");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝     ╚██║╚██║");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝       ██║ ██║");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║        ██║ ██║");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝        ╚═╝ ╚═╝\n");
                    break;

                case (12):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗     ██╗██████╗ ");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ███║╚════██╗");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝     ╚██║ █████╔╝");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝       ██║██╔═══╝ ");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║        ██║███████╗");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝        ╚═╝╚══════╝\n");
                    break;

                case (13):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗     ██╗██████╗ ");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ███║╚════██╗");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝     ╚██║ █████╔╝");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝       ██║ ╚═══██╗");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║        ██║██████╔╝");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝        ╚═╝╚═════╝\n");
                    break;

                case (14):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗     ██╗██╗  ██╗");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ███║██║  ██║");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝     ╚██║███████║");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝       ██║╚════██║");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║        ██║     ██║");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝        ╚═╝     ╚═╝\n");
                    break;

                case (15):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗     ██╗███████╗");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ███║██╔════╝");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝     ╚██║███████╗");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝       ██║╚════██║");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║        ██║███████║");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝        ╚═╝╚══════╝\n");
                    break;

                case (16):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗     ██╗ ██████╗ ");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ███║██╔════╝ ");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝     ╚██║███████╗ ");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝       ██║██╔═══██╗");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║        ██║╚██████╔╝");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝        ╚═╝ ╚═════╝\n");
                    break;

                case (17):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗     ██╗███████╗");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ███║╚════██║");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝     ╚██║    ██╔╝");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝       ██║   ██╔╝ ");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║        ██║   ██║  ");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝        ╚═╝   ╚═╝\n");
                    break;

                case (18):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗     ██╗ █████╗ ");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ███║██╔══██╗");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝     ╚██║╚█████╔╝");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝       ██║██╔══██╗");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║        ██║╚█████╔╝");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝        ╚═╝ ╚════╝\n");
                    break;

                case (19):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗     ██╗ █████╗ ");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ███║██╔══██╗");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝     ╚██║╚██████║");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝       ██║ ╚═══██║");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║        ██║ █████╔╝");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝        ╚═╝ ╚════╝\n");
                    break;

                case (20):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗    ██████╗  ██████╗ ");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ╚════██╗██╔═████╗");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝      █████╔╝██║██╔██║");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝      ██╔═══╝ ████╔╝██║");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║       ███████╗╚██████╔╝");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝       ╚══════╝ ╚═════╝\n");
                    break;

                case (21):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗    ██████╗  ██╗");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ╚════██╗███║");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝      █████╔╝╚██║");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝      ██╔═══╝  ██║");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║       ███████╗ ██║");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝       ╚══════╝ ╚═╝\n");
                    break;

                case (22):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗    ██████╗ ██████╗ ");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ╚════██╗╚════██╗");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝      █████╔╝ █████╔╝");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝      ██╔═══╝ ██╔═══╝ ");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║       ███████╗███████╗");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝       ╚══════╝╚══════╝\n");
                    break;

                case (23):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗    ██████╗ ██████╗ ");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ╚════██╗╚════██╗");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝      █████╔╝ █████╔╝");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝      ██╔═══╝  ╚═══██╗");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║       ███████╗██████╔╝");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝       ╚══════╝╚═════╝\n");
                    break;

                case (24):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗    ██████╗ ██╗  ██╗");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ╚════██╗██║  ██║");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝      █████╔╝███████║");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝      ██╔═══╝ ╚════██║");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║       ███████╗     ██║");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝       ╚══════╝     ╚═╝\n");
                    break;

                case (25):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗    ██████╗ ███████╗");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ╚════██╗██╔════╝");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝      █████╔╝███████╗");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝      ██╔═══╝ ╚════██║");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║       ███████╗███████║");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝       ╚══════╝╚══════╝\n");
                    break;

                case (26):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗    ██████╗  ██████╗ ");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ╚════██╗██╔════╝ ");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝      █████╔╝███████╗ ");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝      ██╔═══╝ ██╔═══██╗");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║       ███████╗╚██████╔╝");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝       ╚══════╝ ╚═════╝\n");
                    break;

                case (27):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗    ██████╗ ███████╗");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ╚════██╗╚════██║");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝      █████╔╝    ██╔╝");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝      ██╔═══╝    ██╔╝ ");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║       ███████╗   ██║  ");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝       ╚══════╝   ╚═╝\n");
                    break;

                case (28):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗    ██████╗  █████╗ ");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ╚════██╗██╔══██╗");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝      █████╔╝╚█████╔╝");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝      ██╔═══╝ ██╔══██╗");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║       ███████╗╚█████╔╝");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝       ╚══════╝ ╚════╝\n");
                    break;

                case (29):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗    ██████╗  █████╗ ");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ╚════██╗██╔══██╗");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝      █████╔╝╚██████║");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝      ██╔═══╝  ╚═══██║");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║       ███████╗ █████╔╝");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝       ╚══════╝ ╚════╝\n");
                    break;

                case (30):
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ██████╗  █████╗ ██╗   ██╗    ██████╗  ██████╗ ");
                    Console.WriteLine(" ██╔══██╗██╔══██╗╚██╗ ██╔╝    ╚════██╗██╔═████╗");
                    Console.WriteLine(" ██║  ██║███████║ ╚████╔╝      █████╔╝██║██╔██║");
                    Console.WriteLine(" ██║  ██║██╔══██║  ╚██╔╝       ╚═══██╗████╔╝██║");
                    Console.WriteLine(" ██████╔╝██║  ██║   ██║       ██████╔╝╚██████╔╝");
                    Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝       ╚═════╝  ╚═════╝\n");
                    break;
            }
        }

        public static void GameOver()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("  ██████╗  █████╗ ███╗   ███╗███████╗     ██████╗ ██╗   ██╗███████╗██████╗ ");
            Console.WriteLine(" ██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔═══██╗██║   ██║██╔════╝██╔══██╗");
            Console.WriteLine(" ██║  ███╗███████║██╔████╔██║█████╗      ██║   ██║██║   ██║█████╗  ██████╔╝");
            Console.WriteLine(" ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║   ██║╚██╗ ██╔╝██╔══╝  ██╔══██╗");
            Console.WriteLine(" ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╔╝ ╚████╔╝ ███████╗██║  ██║");
            Console.WriteLine("  ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝     ╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═╝\n");
        }

        public static void DisplaySplashPage()
        {
            Title();
            Console.WriteLine(" v1.0");
            Console.WriteLine(" Created by Mitchel Mayle III");
            Console.WriteLine("\n\n\n\n\n\n");
            Console.Write(" ***** PRESS ANY KEY TO START *****");
            Console.ReadKey();
            Console.Clear();
        }

        public static void DisplayInstructions()
        {
            Title();
            Console.WriteLine();
            Console.WriteLine(" You have 30 days to travel between cities to buy and sell computer parts to accumulate as much money as you can.\n");
            Console.WriteLine(" When you travel to a different city, one day will pass, and the price rate for each part will change for that day.\n");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(" ***** PRESS ANY KEY TO BEGIN DAY 1 *****");
            Console.ReadKey();
            Console.Clear();
        }
    }
}