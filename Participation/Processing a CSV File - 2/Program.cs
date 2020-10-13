using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processing_a_CSV_File___2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"salesJan2009.csv";

            string[] lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(',');
               // double sale = Convert.ToDouble(pieces[1]);
                string transactiondate = pieces[0];
                string name = pieces[4];


                if (pieces[3].Trim().ToLower() == "visa" && pieces[7].Trim().ToLower() == "united states")
                {
                    Console.WriteLine(transactiondate + " " + name);
                }

            }
            Console.ReadKey();

        }

    }
}

