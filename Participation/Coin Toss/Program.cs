using System;

namespace Coin_Toss
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 3);

            if (number == 1)
            {
                Console.WriteLine("Heads");
            }

            else
            {
                Console.WriteLine("Tails");
            }

        }
    }
}
