﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Toy
{
    class ToyBox
    {

        public List<Toy> Toys { get; set; }

        public ToyBox()
        {
            Toys = new List<Toy>();

        }

        public Toy GetRandomToy()
        {
            Random rnd = new Random();
            int RandomToy = rnd.Next(0, Toys.Count);
            return Toys[RandomToy];
            //return RandomToy;
        }
    }
}
