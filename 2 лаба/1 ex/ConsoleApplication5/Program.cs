using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5 {
    class Program {
        static void Main(string[] args) {            
            Address address = new Address(5226, "Ukraine", "Kyiv", "Khreshatyk", "23", 24);         
            ShowInfo(address);
            Console.ReadKey();
        }


        public static void ShowInfo(Address address) {
            Console.WriteLine("Country: " + address.country);
            Console.WriteLine("City: " + address.city);
            Console.WriteLine("Street: " + address.street);
            Console.WriteLine("House: " + address.house);
            Console.WriteLine("Apartment: " + address.apartment);
            Console.WriteLine("Index: " + address.index);
        }

    }
}
