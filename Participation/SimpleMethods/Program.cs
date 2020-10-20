using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethods
{
    class Program
    {
       // static string AnimalSounds(string AnimalInput)
       // {
            static void Main(string[] args)
            {
            string Animal = AnimalInput();
            string sound = Speak(Animal);
            Console.WriteLine(sound);o
            Console.ReadKey();
            }

            static string AnimalInput()
            {
                Console.WriteLine("Enter an animal >>");
                string AnimalInput = Console.ReadLine();
            return AnimalInput; 
            }

            static string Speak(string AnimalInput)
            {
            string sound = " ";
                if (AnimalInput.ToLower() == "dog")
                {
                    sound = "Woof";
                }
                else if (AnimalInput == "monkey")
                {
                    sound = "Ooo Ooo Ahhh Ahhh";
                }
                else
                {
                    sound = "Baaaaah";
                }
            return sound;
            }
       // Console.ReadKey();
            }
     //   }
    
}
