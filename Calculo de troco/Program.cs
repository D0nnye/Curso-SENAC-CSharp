using System;
using System.Globalization;

namespace Calculo_de_troco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("************Loja Joja************");
            Console.WriteLine("*********************************");

            Console.WriteLine("Informe o valor do produto");
            double valordoproduto = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor pago");
            double valorpago = double.Parse(Console.ReadLine());

            Console.Clear();

            double troco = valordoproduto - valorpago;

            Console.WriteLine("Troco: " + troco);









        }
    }
}
