using System;
using System.Text;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode; 
                       
            Menu.Hello();
            for (; ; )
            {
                string curr1 = Menu.FirstCurr();
                Console.WriteLine("");

                string curr2 = Menu.SecondCurr();
                Console.WriteLine("");

                double value = Menu.Amount();
                value = Converter.ConverterToUSD(value, curr1);
                Console.WriteLine("");

                Currency.ConvertCurr(value, curr1, curr2);
                Console.WriteLine("");

                Console.WriteLine("Будем ещё конвертировать ?");
                Console.WriteLine("Введите 1 - Да || 0 - Нет");
                string answer = Console.ReadLine();
                Console.WriteLine("");
                if (answer == "0")
                {
                    break;
                }
            }
        }





    }
}
