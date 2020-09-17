using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5 {
    class Program {
        static void Main(string[] args) {
            double a;
            double b;
            AskNum(out a, out b);

            Rectangle rectangle = new Rectangle(a, b);
            Console.WriteLine("Perimetr: " + Rectangle.PerimeterCalculator(rectangle));
            Console.WriteLine("Area: " + Rectangle.AreaCalculator(rectangle));
            Console.ReadKey();
        }

        public static void AskNum(out double a, out double b) {
            Console.Write("Write first side: ");
            Double.TryParse(Console.ReadLine(), out a);
            Console.Write("Write second side: ");
            Double.TryParse(Console.ReadLine(), out b);
        }

       
    }
}
