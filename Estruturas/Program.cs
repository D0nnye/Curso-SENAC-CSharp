using System;

namespace Estruturas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira sua idade");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Maior de idade");
            }
            else
            {
                Console.WriteLine("Menor de idade");
            }
        }
    }
}
