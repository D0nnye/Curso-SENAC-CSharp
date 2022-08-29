using System;

namespace Aula_2908
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Selecione a opção desejada");
            var opcao = Console.ReadLine();
            
            switch(opcao)
            {
                case "1":
                    Console.WriteLine("Opção 01 - Seu saldo é de R$ 1000,00");
                    break;
                case "2":
                    Console.WriteLine("Opção 02 - Informe o valor do depósito");
                    break;
                case "3":
                    Console.WriteLine("Opção 01 - Saque - Informe o valor");
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;

            }*/
            //Dias da semana com switch
            /*Console.WriteLine("Semana");
            var semana = Console.ReadLine();
            switch (semana)
            {
                case "1":
                    Console.WriteLine("Domingo");
                    break;
                case "2":
                    Console.WriteLine("Segunda");
                    break;
                case "3":
                    Console.WriteLine("Terça");
                    break;
                case "4":
                    Console.WriteLine("Quarta");
                    break;
                case "5":
                    Console.WriteLine("Quinta");
                    break;
                case "6":
                    Console.WriteLine("Sexta");
                    break;
                case "7":
                    Console.WriteLine("Sabado");
                    break;
            */
            //WHILE é função enquanto o argumento não for verdadeiro ( i<5) vai adicionando valor ou retirando (i++)                                               
            /*t i = 0;
            while ( i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            */
            //Array com While 

            /*
            var indice = 0;
            var versoes = new[] { "1.0", "1.1", "2.0", "3.0" };

            while (indice < versoes.Length)
            {
              //Console.WriteLine(versoes[indice] + "Corresponde ao índice: "+indice): = com frase.
                
                Console.WriteLine(versoes[indice]);
                indice++;
            }
            */

            /*
             var opc = "";
             Console.WriteLine("DIGITE A OPÇÃO");
             Console.WriteLine("1 - SAQUE | 2 - DEPÓSITO | 3 - SALDO | 0 - SAIR");
             opc = Console.ReadLine();
             switch (opc)
             {
                 case "1":
                     Console.WriteLine("Saque selecionado");
                     break;
                 case "2":
                     Console.WriteLine("Depósito selecionado");
                     break;
                 case "3":
                     Console.WriteLine("Saldo disponível: R$ 100,00");
                     break;
                 default:
                     Console.WriteLine("Opção invalida - Aprenda a LER");
                     break;
             }
             while (opc != "0") ;
             }
            */
            //Array com laço foreach
            string[] carCompanies = { "Mercedes", "RBR", "Ferrari" };

            foreach (string car in carCompanies)
            {
                Console.WriteLine("{0}", car);
            }
        }
    }
}

        
        
    

