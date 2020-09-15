using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace forandwhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-100");

            int sum = 0;
            int i = 1;
            //    control  ; var,       increment/decremenation
            for (i = 1; i <= 100; i++)
            {
                
                sum = sum + i;
               
            }
            Console.WriteLine("Sum is : " + sum);

            int iterations = 1;

            Console.WriteLine("do you want to perform another iteration, yes/no");
            string response = Console.ReadLine();

            while(response.ToLower()=="yes")
            {
                iterations = iterations + 1;
                Console.WriteLine("do you want to perform another iteration, yes/no");
                response = Console.ReadLine();
            }
            Console.WriteLine("the number of iterations is " + iterations);
            Console.ReadKey();
        }
    }
}
