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
            circle2.Radius = 8282828;

            double areaOfCircle2 = circle2.CalculateArea();
            double perimeterOfCircle2 = circle2.CalculatePerimeter();

            Circle circle3 = new Circle(3.5);

            Rectangle myRectangle = new Rectangle();
            myRectangle.Length = 10;
            myRectangle.Width = 5;
            Console.WriteLine("The area of a rectangle with a width of " + myRectangle.Width + " and a length of " + myRectangle.Length + 
                " is " + myRectangle.CalculateArea() + " in area and a perimeter of " + myRectangle.CalculatePerimeter());

            Rectangle rectangle2 = new Rectangle();
            rectangle2.Length = 12;
            rectangle2.Width = 6;
            
            double areaOfRectangle2 = rectangle2.CalculateArea();
            double perimeterOfRectangle2 = rectangle2.CalculatePerimeter();



            Console.ReadKey();
        }
    }
}
