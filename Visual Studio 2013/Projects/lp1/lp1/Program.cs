using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, soma1, soma2, Div;
            string[] nome;
            string p;
            p = Console.ReadLine();
            nome = p.Split(' ');
            A = int.Parse(nome[0]);
            B = int.Parse(nome[1]);
            C = int.Parse(nome[2]);
            D = int.Parse(nome[3]);
            soma1 = C + D;
            soma2 = A + B;
            Div = A % 2;
            if (B > C && D > A && soma1 > soma2 && C >= 0 && D >= 0 && Div == 0 && A>0 && B>0 && C>0 && D>0 )
            {
                Console.WriteLine("Valores Aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
