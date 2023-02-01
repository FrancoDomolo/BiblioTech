using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIUtils
{
    public class InputLib
    {
        public static DateTime ReadDateTimeFromConsole(string msg, bool checkOnlyInPast = false)
        {
            string input;
            DateTime date;
            bool result = false;
            do
            {
                Console.Write(msg);
                result = DateTime.TryParse(Console.ReadLine(), out date);
                if (result && checkOnlyInPast)
                {
                    result = result && date > DateTime.Now.Date;
                }
            } while (!result);
            return date;
        }

        public static float ReadFloatFromConsole(string msg)
        {
            string input;
            float num;
            do
            {
                Console.Write(msg);
                input = Console.ReadLine();
            } while (float.TryParse(input, out num) == false);

            return num;
        }

        public static byte ReadByteFromConsole(string msg)
        {
            string input;
            byte num;
            do
            {
                Console.Write(msg);
                input = Console.ReadLine();
            } while (byte.TryParse(input, out num) == false);

            return num;
        }
        public static int ReadNaturalNumberFromConsole(string msg)
        {
            string input;
            int num;
            do
            {
                Console.Write(msg);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out num) || num <= 0);

            return num;
        }
        public static decimal ReadPositiveDecimalFromConsole(string msg)
        {
            string input;
            decimal num;
            do
            {
                Console.Write(msg);
                input = Console.ReadLine();
            } while (!decimal.TryParse(input, out num) || num <= 0);

            return num;
        }

        public static string ReadHexFromConsole(string msg)
        {
            string input;
            string hex;
            bool result = false;
            do
            {
                Console.Write(msg);
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input) || input.Length != 6)
                    result = false;
                else
                {
                    input = input.ToLower();
                    foreach (var c in input)
                    {
                        if (!"0123456789abcdef".Contains(c))
                        {
                            result = false;
                            break;
                        }
                    }
                    result = true;
                }
            } while (!result);
            return input;
        }

        public static string ReadStringFromConsole(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }
    }
}
