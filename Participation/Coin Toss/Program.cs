using System;

namespace Coin_Toss
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 3);

            Console.WriteLine("Guess heads or tails >>");
            string Answer = Console.ReadLine();

            if (number == 1 && Answer == "heads")
            {
                Console.WriteLine("You ae correct!");
            }
            else if (number == 2 && Answer == "tails")
            {
                Console.WriteLine("You are correct!");
            }
            else
            {
                Console.WriteLine("WRONG!");
            }

        }
    }
}
