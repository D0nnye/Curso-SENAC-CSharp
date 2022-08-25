using System;
using System.Globalization;

namespace Calculos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Programa para calcular o aumento de salário de uma funcionario X exibindo
             
             - % de aumento de salário
             - Aumento em reais
             - Salário final
            
             */
            Console.WriteLine("===============================================");
            Console.WriteLine("=====   Programa de aumento de salário  =======");
            Console.WriteLine("===============================================");

            Console.WriteLine("Insira o nome do funcionario: ");
            string Nome = Console.ReadLine();

            Console.WriteLine("Insira o salário do funcionario: ");
            double SalarioInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual % de aumento deseja para o funcionario " + Nome + " ?");
            double perc = double.Parse(Console.ReadLine());

            double percemdecimal = perc / 100;
            // 1000 + 1000 * 0,15
            // 1000 + 150
            // 1150
            double SalarioFinal = SalarioInicial + SalarioInicial * percemdecimal; 

            Console.Clear();

            Console.WriteLine("===============================================");
            Console.WriteLine("=====  Resultado  ========");
            Console.WriteLine("===============================================");

            Console.WriteLine("Salário inicial: " + SalarioInicial);
            Console.WriteLine("Percentual de aumento" + perc + " %");
            Console.WriteLine("Sálário final: " + "R$ " + SalarioFinal.ToString("F2", CultureInfo.InvariantCulture));






        }

    }
}
