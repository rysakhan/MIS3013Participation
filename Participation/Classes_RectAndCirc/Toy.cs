using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_RectAndCirc
{
    class Toy
    {
        public string Manufacturer{get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Notes { get; set; }
       
        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Notes = "";
        }

        public Toy (string manufacturer, string name, double price, string notes)
        {
            Manufacturer = manufacturer;
            Name = name;
            Price = price;
            Notes = notes;
        }

        public string GetAisle()
        {
            string UpperManu = Manufacturer[0].ToString();
            Random rand = new Random();
            int RandomNumber = rand.Next(0, 24);
            string result = UpperManu + RandomNumber.ToString();

            return result;
        }

    }
}
