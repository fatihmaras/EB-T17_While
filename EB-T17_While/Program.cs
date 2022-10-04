using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDongusuPratik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            while (a <= 10)
            {
                Console.WriteLine(a);
                a++;

            }

            Console.WriteLine("\n");
            int b = 0;
            while (b <= 100)
            {

                Console.WriteLine(b);
                b += 2;

            }

            Console.WriteLine("\n");


            int c = 100;
            while (c >= 0)
            {
                Console.WriteLine(c);
                c -= 2;

            }
            Console.ReadLine();
        }
    }
}

