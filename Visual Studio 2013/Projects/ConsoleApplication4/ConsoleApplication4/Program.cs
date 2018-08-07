using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, d = 0, b = 1, c = 0;
            //---
            for (b = 1; b <= 6; b++)
            {
                a = double.Parse(Console.ReadLine());
                if (0 <= a)
                {
                    c++;
                    a += c;
                }
            }
            Console.WriteLine(c + " valores positivos");
            a = b + c / b;
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}

