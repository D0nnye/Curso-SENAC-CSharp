using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeusuario = "";
            string nomeproduto = "";
            string saldo = "";
            int quantidade = 0;
            double preco = 0;
            double p_desconto = 0;
            double total_desconto = 0;
            double total_bruto = 0;

            Console.WriteLine("Insira o nome do usuario: ");
            nomeusuario = Console.ReadLine();
            Console.WriteLine("Insira seu limite de crédito: ");
            saldo = Console.ReadLine();
            Console.WriteLine("Insira o nome do produto: ");
            nomeproduto = Console.ReadLine();
            Console.WriteLine("Insira a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do produto: ");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor do desconto: ");
            p_desconto = double.Parse(Console.ReadLine());

            total_bruto = quantidade * preco;
            total_desconto = total_bruto - ((p_desconto / 100) * total_bruto);
            Console.WriteLine("Valor total com o desconto é: " + total_desconto);

            //MSG
            Console.WriteLine($"{nomeusuario} realizou uma compra {quantidade} unidades de {nomeproduto} nos mercados Joja");


        }
    }
}
