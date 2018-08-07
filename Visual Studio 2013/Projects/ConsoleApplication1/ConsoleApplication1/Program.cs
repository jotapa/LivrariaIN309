using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, fn, fc;
            fc = 0;
            n1 = int.Parse(Console.ReadLine());
            if (n1 >= 100) ;
            {
                fn = n1 / 100;
                Console.WriteLine("{0} nota(s) de R$ 100,00", fn);
                fc = n1 - fn * 100;
            }

            if (0<= fc >= 100000000)
            {
                fn = fc / 50;
                Console.WriteLine("{0} nota(s) de R$ 50,00", fn);
                fc = fc - fn * 50;
            }

            if (fc >= 20)
            {
                fn = fc / 20;
                Console.WriteLine("{0} nota(s) de R$ 20,00", fn);
                fc = fc - fn * 20;
            }

            if (fc >= 10)
            {
                fn = fc / 10;
                Console.WriteLine("{0} nota(s) de R$ 10,00", fn);
                fc = fc - fn * 10;
            }

            if (fc >= 5)
            {
                fn = fc / 5;
                Console.WriteLine("{0} nota(s) de R$ 5,00", fn);
                fc = fc - fn * 5;
            }

            if (fc >= 2)
            {
                fn = fc / 2;
                Console.WriteLine("{0} nota(s) de R$ 2,00", fn);
                fc = fc - fn * 2;
            }

            if (fc >= 1)
            {
                fn = fc / 1;
                Console.WriteLine("{0} nota(s) de R$ 1,00", fn);
                fc = fc - fn * 1;
            }
           
          
            
            
        }
    }
}
