using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            int cedulas, cem, cinquenta, vinte, dez, cinco, dois, um;
            cedulas = int.Parse(Console.ReadLine());
            cem = cedulas / 100;
            cinquenta = (cedulas % 100) / 50;
            vinte = (cedulas % 100) % 50 / 20;
            dez = (cedulas % 100) % 50 % 20 / 10;
            cinco = (cedulas % 100) % 50 % 20 % 10 / 5;
            dois = (cedulas % 100) % 50 % 20 % 10 % 5 / 2;
            Console.WriteLine("{0}", cedulas);
            Console.WriteLine("{0:0} nota(s) de R$ 100.00", cem);
            Console.WriteLine("{0:0} nota(s) de R$ 50.00", cinquenta);
            Console.WriteLine("{0:0} nota(s) de R$ 20.00", vinte);
            Console.WriteLine("{0:0} nota(s) de R$ 10.00", dez);
            Console.WriteLine("{0:0} nota(s) de R$ 5.00", cinco);
            Console.WriteLine("{0:0} nota(s) de R$ 2.00", dois);
        }
    }
}
