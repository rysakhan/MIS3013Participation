using System;

namespace FizzBuzzRK
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Randome();
            int number = rnd.Next(1, 101);
            Console.WriteLine(number); 
        }
    }
}
