using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy myToy = new Toy();
            myToy.Manufacturer = "Rida Raza";
            myToy.Name = "Doctor";
            myToy.Price = 70;
            //myToy.Notes = "Becoming a doctor";

            Toy toy2 = new Toy();
            toy2.Manufacturer = "Sana Raza";
            toy2.Name = "Psychology";
            toy2.Price = 54;

            List<Toy> MyToyBox = new List<Toy>();
            MyToyBox.Add(myToy);
            MyToyBox.Add(toy2);

            Console.WriteLine("Would you like to add a toy box?");
            string toyboxAnswer = Console.ReadLine();

            while(toyboxAnswer.ToLower() == "yes")
            {
                Console.WriteLine(" What is the name of the toy?");
                string userAnswer = Console.ReadLine();
                Toy newToy = new Toy();
                newToy.Name = userAnswer;
                Console.WriteLine(" Who is the manufacturer?");
                newToy.Manufacturer = Console.ReadLine();
                Console.WriteLine(" What is the price?");
                double toyPrice = Convert.ToDouble(Console.ReadLine());
                newToy.Price = toyPrice;

            }

            Console.ReadKey();
        }
    }
}
