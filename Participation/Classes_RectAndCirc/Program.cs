using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_RectAndCirc
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle = new Circle();
            myCircle.Radius = 7.5;
            Console.WriteLine("The area of a circle with" + myCircle.Radius + "is" + myCircle.CalculateArea() +
                                 "and a perimeter of " + myCircle.CalculatePerimeter());

            Circle circle2 = new Circle();
            circle2.Radius = 8282828282;
            double areaOfCircle2 = circle2.CalculateArea();
            double perimeterOfCircle2 = circle2.CalculatePerimeter();

            Circle circle3 = new Circle(3.5);

            Console.ReadKey();
        }
    }
}
