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
            myToy.Manufacturer = "Play Doh";
            myToy.Name = "Yellow Play Doh";
            myToy.Price = 0.70;
            myToy.setNotes("not edible.");

            Toy toy2 = new Toy();
            toy2.Manufacturer = "Play Douh";
            toy2.Name = "Blue Play doh";
            toy2.Price = 2.3;
            toy2.setNotes("not edible.");

            Toy toy3 = new Toy();
            toy3.Manufacturer = "Play Doh";
            toy3.Name = "Green Play Doh";
            toy3.Price = 5.4;
            toy3.setNotes("not edible.");

            Toy toy4 = new Toy();
            toy4.Manufacturer = "Play Doh";
            toy4.Name = "Orange Play Doh";
            toy4.Price = 1.4;
            toy4.setNotes("not edible.");

            ToyBox MyToyBox = new ToyBox();
            MyToyBox.Toys.Add(myToy);
            MyToyBox.Toys.Add(toy2);


            ToyBox RysaToyBox = new ToyBox();
            MyToyBox.Toys.Add(toy3);
            MyToyBox.Toys.Add(toy4);

            Toy randomToy = MyToyBox.GetRandomToy();
            Console.WriteLine("The random toy from MyToyBox is " + randomToy.Name + " by the manufacturer " + randomToy.Manufacturer + " and the price is " + randomToy.Price + " and the note is " + randomToy.printNotes());

            Toy randomToy2 = RysaToyBox.GetRandomToy();
            Console.WriteLine("The random toy from RysaToyBox is " + randomToy2.Name + " by the manufacturer " + randomToy2.Manufacturer + " and the price is " + randomToy2.Price + " and the note is " + randomToy2.printNotes());




            Console.ReadKey();
        }
    }
}
