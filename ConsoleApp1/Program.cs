using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, valorm2, area, valorTotal;

            Console.WriteLine("Largura");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Comprimento");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor do M²");
            valorm2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            valorTotal = area * valorm2;

            Console.Clear();
            Console.WriteLine("Resultado");
            Console.WriteLine("Area do terreno é: " + area.ToString("F2", CultureInfo.InvariantCulture) + " m²");
            Console.WriteLine("Valor total é R$: " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));

















        }
    }
}
