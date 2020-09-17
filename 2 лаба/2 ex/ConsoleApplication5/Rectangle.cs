using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5 {
    class Rectangle {
        public double side1;
        public double side2;

        public Rectangle(double side1, double side2) {
            this.side1 = side1;
            this.side2 = side2;
        }

        public static double PerimeterCalculator(Rectangle rectangle) {
            double result;
            result = (rectangle.side1 + rectangle.side2) * 2;
            return result;
        }

        public static double AreaCalculator(Rectangle rectangle) {
            double result;
            result = rectangle.side1 * rectangle.side2;
            return result;
        }

    }
}
