using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string prompt = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            Console.WriteLine(prompt);

            Console.WriteLine("What word do you want to look for in the above sentence?");
            string answer1 = Console.ReadLine();

            Console.WriteLine("What word to you want to change it to?");
            string replaceWord = Console.ReadLine();

            bool contains = prompt.Contains(answer1);

            if (contains)
            {
                prompt = prompt.Replace(answer1, replaceWord);
                Console.WriteLine(prompt);
            }
            else
            {
                Console.WriteLine("Sorry, I could not find your word: " + answer1);
                for (int i = answer1.Length-1; i >= 0; i--)
                {
                    char letter = answer1[i];
                    Console.Write(letter.ToString());
                }

            }

          
            

            Console.ReadKey();
        }
    }
}
