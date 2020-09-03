using System;

namespace ClassSepThree
{
    class Program
    {
        static void Main(string[] args)
        {
            double hazardousPrice = 0;
            Boolean hazardousBoolean = false;

            Console.WriteLine("How much does package weigh >>");
            string weightInput = Console.ReadLine();
            double weight = Convert.ToDouble(weightInput);

            Console.WriteLine("How many miles >>");
            string milesInput = Console.ReadLine();
            double distance = Convert.ToDouble(milesInput);

            Console.WriteLine("yes/no: Does it contain hazardous material >>");
            string hazardousResponse = Console.ReadLine();
            
            if (hazardousResponse == "yes")
            {
                hazardousBoolean = true;
            }
            
            else if (hazardousResponse == "no")
            {
                hazardousBoolean == false;
            }

            else
            {
                Console.WriteLine("Input is invalid. Bye.");
                return;
            }

            double price = 0;

            price = (0.55 * distance) + (0.73 * weight);

            if (hazardousBoolean)
            {
                hazardousPrice = .015 * weight;
            }
            else
            {
                hazardousPrice = 0 * weight;
            }

            double totalPrice = price + hazardousPrice;
            Console.WriteLine("Your quote is " + totalPrice + ".");
            



            
        }
    }
}
