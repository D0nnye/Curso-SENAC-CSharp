using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            //Igual
            bool igual = a == b;
            Console.WriteLine(igual);
            //Diferente
            bool diferente = a != b;
            Console.WriteLine(diferente);
            //Maior
            bool maior = a>b;
            Console.WriteLine(maior);
            //Menor 
            bool menor = b<a;
            Console.WriteLine(menor);
            //Maior ou igual
            bool maiorouigual = b >= a;
            Console.WriteLine(maiorouigual);
            //Menor ou igual
            bool menorouigual = b <= a;
            Console.WriteLine(menorouigual);
        }
    }
}
