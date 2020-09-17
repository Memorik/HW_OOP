using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class Converter
    {
        public static void ConverterUSD(double value, string curr1, string curr2)
        {
            Console.WriteLine("Итог: "+value);
        }

        public static void ConverterUAH(double value, string curr1, string curr2)
        {
            Console.WriteLine("Итог: " + value *27.45);
        }
        public static void ConverterEUR(double value, string curr1, string curr2)
        {
            Console.WriteLine("Итог: "+ value * 0.85);
        }
        public static void ConverterRUB(double value, string curr1, string curr2)
        {
            Console.WriteLine("Итог: " + value * 73.93);
        }
        public static void ConverterPLN(double value, string curr1, string curr2)
        {
            Console.WriteLine("Итог: " + value * 3.71);
        }

        public static double ConverterToUSD(double value, string curr1)
        {
            if (curr1 == "2")
            {
                value = value / 0.8464;
            }
            else if (curr1 == "3")
            {
                value = value / 73.99;
            }
            else if (curr1 == "4")
            {
                value = value / 3.71;
            }
            else if (curr1 == "5")
            {
                value = value / 27.45;
            }

            return value;
        }
    }
}
