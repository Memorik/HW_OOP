using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    public class Menu
    {
        public static void Hello()
        {
            Console.WriteLine("Здравствуйте, это конвертер валют ");
        }

        public static string FirstCurr()
        {
            for (; ; )
            {
                Console.WriteLine("Введите номер валюты из которой хотите конвертировать");
                ShowCurr();
                string curr = Console.ReadLine();
                if (curr == "1" || curr == "2" || curr == "3" || curr == "4" || curr == "5")
                {
                    return curr;
                }
            }

        }


        public static string SecondCurr()
        {
            for (; ; )
            {
                Console.WriteLine("Введите номер валюты в которую хотипе конвертировать");
                ShowCurr();
                string curr = Console.ReadLine();
                if (curr == "1" || curr == "2" || curr == "3" || curr == "4" || curr == "5")
                {
                    return curr;
                }
            }
        }

        public static double Amount()
        {
            Console.WriteLine("Введите сумму которую хотите перевести");
            double.TryParse(Console.ReadLine(), out double value);
            return value;
        }


        public static void ShowCurr()
        {
            Console.WriteLine("1 - USD ");
            Console.WriteLine("2 - EUR ");
            Console.WriteLine("3 - RUB ");
            Console.WriteLine("4 - PLN ");
            Console.WriteLine("5 - UAH ");
        }



    }
}
