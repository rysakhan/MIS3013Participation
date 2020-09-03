using System;

namespace SumOf3
{
    class Program
    {
        //@author , collaborated with Zareen Khan on this assignment 
        const double NUM = 7.777;
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter after every input.");

            Console.WriteLine("Enter 1st number >>");
            string InputNumOne = Console.ReadLine();
            double NumOne = Convert.ToDouble(InputNumOne);
            // stores user input for first value

            Console.WriteLine("Enter 2nd number >>");
            string InputNumTwo = Console.ReadLine();
            double NumTwo = Convert.ToDouble(InputNumTwo);
            // stores user input for second value

            Console.WriteLine("Enter 3rd number >>");
            string InputNumThree = Console.ReadLine();
            double NumThree = Convert.ToDouble(InputNumThree);
            // stores user input for third value

            double SumOfThree = NumOne + NumTwo + NumThree;
            Console.WriteLine("Sum of the three inputs is: " + SumOfThree);
            // adds and prints the sum

            double SecondValue = SumOfThree * NUM;
            Console.WriteLine("The second value is: " + SecondValue);
            // multiplies and prints the second value with the constant double

    
        }
        
    }
}
