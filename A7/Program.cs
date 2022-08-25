using System;
using System.Globalization;

namespace A7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Marktplace - Joja");
            Console.WriteLine();
            Console.WriteLine("Dados do Usuário");
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite seu saldo: ");
            double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do produto");
            Console.WriteLine("Digite o nome do produto: ");
            string nomeproduto = Console.ReadLine();
            Console.WriteLine("Digite o valor do produto: ");
            double valorproduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double saldofinal = saldo - valorproduto;
            bool comprarealizada = saldofinal >= 0;

            if (comprarealizada)
            {
                Console.WriteLine("Compra efetivada");
            }
            else
            {
                Console.WriteLine("Não aprovada");
            }
            Console.ReadKey();

        }
    }
}
