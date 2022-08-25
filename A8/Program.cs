using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Montadoras = new string[6] { "Mercedes", "Aston Martin", "Ferrari", "Porsche", "Audi", "Tesla" };

            for (int cont = 0; cont < Montadoras.Length; cont++)
                Console.WriteLine(Montadoras[cont]);
            {
                Console.ReadLine();

            }
        }
    }
}

   