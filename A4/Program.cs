using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adição
            int a = 10;
            int b = 20;
            int adicao = a + b;
            Console.WriteLine("Adição: " + adicao);
            //Subtração
            int subtracao = a - b;
            Console.WriteLine("Subtração: " + subtracao);
            //Multiplicação
            int multiplicacao = a * b;
            Console.WriteLine("Multiplicação: " + multiplicacao);
            //Divisão
            double divisao = b/a;
            Console.WriteLine("Divisão: " + divisao);
            //Resto
            int resto = a % b;
            Console.WriteLine("Resto: " + resto);
            //Incremento a
            int incrementoA = a;
            incrementoA = a + 1;
            Console.WriteLine("Incremento de 10 + 1: " + incrementoA);
            //Decremento a
            int decrementoA = a;
            decrementoA = a - 1;
            Console.WriteLine("Decremento de 10 - 1: " + decrementoA);
            //Incremento b
            int incrementoB = b;
            incrementoB = b + 1;
            Console.WriteLine("Incremento de 20 + 1: " + incrementoB);
            //Decremento b
            int decrementoB = b;
            decrementoB = b - 1;
            Console.WriteLine("Decremento de 20 - 1: " + decrementoB);


        }
    }
}
