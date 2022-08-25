using System;

namespace Leitura_de_numero_e_retorno
{
    class Program
    {
        static void Main(string[] args)
        {
            //escrever um programa que leia um numero e retorne se ele é positivo ou negativo.

            Console.WriteLine("Escreva um numero");
            double num = double.Parse(Console.ReadLine());


            if (num < 0)
            {
                Console.WriteLine($"O Numero {num} é negativo!");
            }
            else if (num == 0)
            {
                Console.WriteLine(" 0 é um número neutro");
            }
            else
            {
                Console.WriteLine($"O numero {num} é positivo");

            }
        }
    }
}

