using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int  b, c, d, e, f, g, h;
            

            double a1 = double.Parse(Console.ReadLine());
            int tmp = (int)(a1 * 100);
            int a = tmp / 100;
            int a2 = tmp % 100;
            
            Console.WriteLine("NOTAS:")
;            if (a >= 100)
            {
                b = a / 100;
                Console.WriteLine("{0} nota(s) de R$ 100.00", b);
                a = (a - (b * 100));
            }
            else
            {
                Console.WriteLine("0 nota(s) de R$ 100.00");
            }
            if (a >= 50)
            {
                c = a / 50;
                Console.WriteLine("{0} nota(s) de R$ 50.00", c);
                a = (a - (c * 50));
            }
            else
            {
                Console.WriteLine("0 nota(s) de R$ 50.00");
            }
            if (a >= 20)
            {
                d = a / 20;
                Console.WriteLine("{0} nota(s) de R$ 20.00", d);
                a = (a - (d * 20));
            }
            else
            {
                Console.WriteLine("0 nota(s) de R$ 20.00");
            }
            if (a >= 10)
            {
                e = a / 10;
                Console.WriteLine("{0} nota(s) de R$ 10.00", e);
                a = (a - (e * 10));
            }
            else
            {
                Console.WriteLine("0 nota(s) de R$ 10.00");
            }
            if (a >= 5)
            {
                f = a / 5;
                Console.WriteLine("{0} nota(s) de R$ 5.00", f);
                a = (a - (f * 5));
            }
            else
            {
                Console.WriteLine("0 nota(s) de R$ 5.00");
            }
            if (a >= 2)
            {
                g = a / 2;
                Console.WriteLine("{0} nota(s) de R$ 2.00", g);
                a = (a - (g * 2));
            }
            else
            {
                Console.WriteLine("0 nota(s) de R$ 2.00");
            }
            Console.WriteLine("MOEDAS:");
            if (a >= 1)
            {
                h = a / 1;
                Console.WriteLine("{0} moeda(s) de R$ 1.00", h);
                a = (a - (h * 1));
            }
            else
            {
                Console.WriteLine("0 moeda(s) de R$ 1.00");
            }

            
            if (a2 >= 50)
            {
                c = a2 / 50;
                Console.WriteLine("{0} moeda(s) de R$ 0.50", c);
                a2 = (a2 - (c * 50));
            }
            else
            {
                Console.WriteLine("0 moeda(s) de R$ 0.50");
            }
            if (a2 >= 25)
            {
                d = a2 / 25;
                Console.WriteLine("{0} moeda(s) de R$ 0.25", d);
                a2 = (a2 - (d * 25));
            }
            else
            {
                Console.WriteLine("0 moeda(s) de R$ 0.25");
            }
            if (a2 >= 10)
            {
                e = a2 / 10;
                Console.WriteLine("{0} moeda(s) de R$ 0.10", e);
                a2 = (a2 - (e * 10));
            }
            else
            {
                Console.WriteLine("0 moeda(s) de R$ 0.10");
            }
            if (a2 >= 5)
            {
                f = a2 / 5;
                Console.WriteLine("{0} moeda(s) de R$ 0.05", f);
                a2 = (a2 - (f * 5));
            }
            else
            {
                Console.WriteLine("0 moeda(s) de R$ 0.05");
            }
           
            if (a2 >= 1)
            {
                h = a2 / 1;
                Console.WriteLine("{0} moeda(s) de R$ 0.01", h);
                a2 = (a2 - (h * 1));
            }
            else
            {
                Console.WriteLine("0 moeda(s) de R$ 0.01");
            }
   
   

        }
    }
}
