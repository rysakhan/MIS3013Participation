using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your minimum value?");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your maximum value?");
            int max = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int randomNum = rnd.Next(min, max);

            Console.WriteLine("Enter your guess for random number >>");
            int guess = Convert.ToInt32(Console.ReadLine());

            while (guess != randomNum)
            {
                Console.WriteLine("Wrong! Enter another guess for random number >>");
                guess = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Congrats! You guessed correctly! The random number is: " + randomNum + "!");
            Console.ReadKey();
        }
    }
}
