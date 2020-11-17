using System;

namespace Classes_Toy
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Notes;

        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Notes = "";
        }

        public Toy(string manufacturer, string name, double price, string notes)
        {
            Manufacturer = manufacturer;
            Name = name;
            Price = price;
            Notes = notes;
        }

        public string GetAisle()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 24);
            return Manufacturer[1] + num.ToString();
        }

        public void setNotes(string notesMessage)
        {
            Notes = notesMessage;
        }

        public string printNotes()
        {
                return Notes;
        }


    }
}