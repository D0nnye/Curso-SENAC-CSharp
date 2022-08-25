using System;
using System.Globalization;

namespace Apartamento
{
    class Program
    {
        static void Main(string[] args)
        {

            double largura, comprimento, area;

            Console.WriteLine("Largura do apartamento");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Comprimento do apartamento");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;

            Console.Clear();

            if (area <= 50)
            {
                Console.WriteLine("Apartamento compacto");
                Console.WriteLine("Apartamento com area de " + area + "m²");

            }
            else
            {
                Console.WriteLine("Apartamento superluxo");
                Console.WriteLine("Apartamento com area de " + area + "m²");



            }
        }
    }
}

    

   
