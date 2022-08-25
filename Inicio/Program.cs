using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tipo, Identificador.
            //Declaração de Variáveis

            char primeiraletranome;
            string nome;
            int idade;
            float valor;
            double valoralto;
            bool primeiraletradonomeD;

            primeiraletranome = 'D';
            // ao identificar o valor L é necessario usar aspas simples pq se trata de uma variavel char
            nome = "Don";
            idade = 21;
            valor = 0.6f;
            // ao colocar um "f" o visual studio entende que se trata de um float, não é obrigatorio mas se vc ficar fica melior.
            valoralto = 1632.76;
            primeiraletradonomeD = true;

            Console.WriteLine("Primeira letra do nome é: "+ primeiraletranome);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Valor Default: " + valor);
            Console.WriteLine("Valor Alto: " + valoralto);
            Console.WriteLine("Começa com a letra D: " + primeiraletradonomeD);






        }
    }
}
