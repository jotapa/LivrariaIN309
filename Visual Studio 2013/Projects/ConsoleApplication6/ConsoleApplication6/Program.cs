using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] v1 = Console.ReadLine().Split();
            double X = double.Parse(v1[0]);
            double Y = double.Parse(v1[1]);
            if(X > 0)
            {
                if(Y > 0)
                {
                    Console.WriteLine("Q1");
                    if(X > 0)
                    {
                        if(Y < 0)
                        {
                            Console.WriteLine("Q4");
                            if(X < 0)
                            {
                                if(Y > 0)
                                {
                                    Console.WriteLine("Q2");
                                    if(X < 0)
                                    {
                                        if(Y < 0)
                                        {
                                            Console.WriteLine("Q3");
                                            if(X == 0)
                                            {
                                                if(Y == 0)
                                                {
                                                    Console.WriteLine("Origem");
                                                    if(X == 0)
                                                    {
                                                        if(Y != 0)
                                                        {
                                                            Console.WriteLine("Eixo X");
                                                            if(X != 0)
                                                            {
                                                                if(Y == 0)
                                                                {
                                                                    Console.WriteLine("Eixo Y");
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {

            }
        }
    }
}
