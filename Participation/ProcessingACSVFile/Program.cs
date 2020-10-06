using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingACSVFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"sales_data_sample.csv";

            string[] lines = File.ReadAllLines(filePath);

            double sum = 0;
            double sumfor2003 = 0;
            double sumfor2004 = 0;
            double sumfor2005 = 0;
            double sumforJanuary = 0;
            double sumforFebruary = 0;
            double sumforMarch = 0;
            double sumforApril = 0;
            double sumforMay = 0;
            double sumforJune = 0;
            double sumforJuly = 0;
            double sumforAugust = 0;
            double sumforSeptember = 0;
            double sumforOctober = 0;
            double sumforNovember = 0;
            double sumforDecember = 0;

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(',');
                double sale = Convert.ToDouble(pieces[1]);
                string year = pieces[9];
                string month = pieces[8];



                if (pieces[6].Trim().ToLower() == "shipped")
                {
                    if (year == "2003")
                    {
                        sumfor2003 += sale;
                    }
                    else if (year == "2004")
                    {
                        sumfor2004 += sale;
                    }
                    else//if (year == "2005")
                    {
                        sumfor2005 += sale;
                    }

                    if (month == "1")
                    {
                        sumforJanuary += sale;
                    }
                    if (month == "2")
                    {
                        sumforFebruary += sale;
                    }
                    if (month == "3")
                    {
                        sumforMarch += sale;
                    }
                    if (month == "4")
                    {
                        sumforApril += sale;
                    }
                    if (month == "5")
                    {
                        sumforMay += sale;
                    }
                    if (month == "6")
                    {
                        sumforJune += sale;
                    }
                    if (month == "7")
                    {
                        sumforJuly += sale;
                    }
                    if (month == "8")
                    {
                        sumforAugust += sale;
                    }
                    if (month == "9")
                    {
                        sumforSeptember += sale;
                    }
                    if (month == "10")
                    {
                        sumforOctober += sale;
                    }
                    if (month == "11")
                    {
                        sumforNovember += sale;
                    }
                    if (month == "12")
                    {
                        sumforDecember += sale;
                    }

                }
                sum = sum + sale;
            }
            Console.WriteLine("The sales total for 2003 is " + sumfor2003.ToString("C"));
            Console.WriteLine("The sales total for 2004 is " + sumfor2004.ToString("C"));
            Console.WriteLine("The sales total for 2005 is " + sumfor2005.ToString("C"));
            Console.WriteLine("The sales total is " + sum.ToString("C"));
            Console.WriteLine("The sales total for January is " + sumforJanuary.ToString("C"));
            Console.WriteLine("The sales total for February is " + sumforFebruary.ToString("C"));
            Console.WriteLine("The sales total for March is " + sumforMarch.ToString("C"));
            Console.WriteLine("The sales total for April is " + sumforApril.ToString("C"));
            Console.WriteLine("The sales total for May is " + sumforMay.ToString("C"));
            Console.WriteLine("The sales total for June is " + sumforJune.ToString("C"));
            Console.WriteLine("The sales total for July is " + sumforJuly.ToString("C"));
            Console.WriteLine("The sales total for August is " + sumforAugust.ToString("C"));
            Console.WriteLine("The sales total for September is " + sumforSeptember.ToString("C"));
            Console.WriteLine("The sales total for October is " + sumforOctober.ToString("C"));
            Console.WriteLine("The sales total for November is " + sumforNovember.ToString("C"));
            Console.WriteLine("The sales total for December is " + sumforDecember.ToString("C"));


            Console.ReadKey();
        }
    }
}
