using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
         //Tabuada infinita com laço for atribuido.
            int formula, contador, numero;
            jj
            Console.Write("Digite um numero : ");
            numero = Int32.Parse(Console.ReadLine());

           
            for (contador = 1; contador <= 10; ++contador)
            {
                formula = numero * contador;
                Console.WriteLine(numero + " X " + contador + " = " + formula);
           
            }
            }
    }
}
