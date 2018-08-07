using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] partes = Console.ReadLine().Split();


            int a = int.Parse(partes[0]);
            int b = int.Parse(partes[1]);
            int c = int.Parse(partes[2]);
            int d = int.Parse(partes[3]);

            if (b < c)
            {
                Console.WriteLine("Valores nao aceitos");
            }

            else
            {
                if (a > d)
                {
                    Console.WriteLine("Valores nao aceitos");
                }
                else
                {
                    int somaCD = c + d;
                    int somaAB = a + b;
                    if (somaAB > somaCD)
                    {
                        Console.WriteLine("Valores nao aceitos");
                    }
                    else
                    {
                        if (c < 0)
                        {
                            Console.WriteLine("Valores nao aceitos");
                        }
                        if (d < 0)
                        {
                            Console.WriteLine("Valores nao aceitos");

                        }
                        if (a % 2 == 1)
                        {
                            Console.WriteLine("Valores nao aceitos");
                        }

                        Console.WriteLine("Valores aceitos");
                    }
                    &&||
        }
    }
}
