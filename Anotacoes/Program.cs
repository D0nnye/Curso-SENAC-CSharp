using System;

namespace Anotacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Com VARiavel dinamica
            var nome = "MArcos";
            var sobrenome = "Paulo";
            Console.WriteLine(nome+sobrenome);

            //Sem Variavel
            string nome1 = "MArcos";
            string sobrenome1 = "PAulo";
            var nomecompleto = $"{nome} {sobrenome}";
            Console.WriteLine(nomecompleto);

            //Usar maiusculo
            Console.WriteLine(nomecompleto.ToUpper());
            //Minusculo
            Console.WriteLine(nomecompleto.ToLower());
            //Sublinhas com função contagem de caractere
            Console.WriteLine(nomecompleto.Substring(6));
            //Sub com função de mais caractere além da contagem
            Console.WriteLine(nomecompleto.Substring(6, 6));
            //Função para procurar se existe o argumento, ex se existe a leta M, para achar com mais de um caracteres só colocar em aspas duplas.
            Console.WriteLine(nomecompleto.Contains('M'));
            //Função que "começa com" a letra que você definir, para finalizar "com a letra" definida é EndsWith.
            Console.WriteLine(nomecompleto.StartsWith("P"));
            //Função para contar os caract até encontrar o argumento definido.
            Console.WriteLine(nomecompleto.IndexOf("o"));
            //Função para encontrar o ultimo argumento
            Console.WriteLine(nomecompleto.LastIndexOf("o"));


           









        }
    }
}
