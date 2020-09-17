using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class Currency
    {
        public static void ConvertCurr(double value, string curr1, string curr2)
        {
            if (curr1 == curr2)
            {
                Console.WriteLine("Нет смысла переводить одинаковую валюту");
            }
            else if (curr2 == "1")
            {
                Converter.ConverterUSD(value, curr1, curr2);
            }
            else if (curr2 == "2")
            {
                Converter.ConverterEUR(value, curr1, curr2);
            }
            else if (curr2 == "3")
            {
                Converter.ConverterRUB(value, curr1, curr2);
            }
            else if (curr2 == "4")
            {
                Converter.ConverterPLN(value, curr1, curr2);
            }
            else if (curr2 == "5")
            {
                Converter.ConverterUAH(value, curr1, curr2);
            }
        }       
    }
}
