using System;

namespace Notas
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.ForegroundColor = color;
                Console.Clear();
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Escreva a primeira nota");
            double N1= double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Escreva a segunda nota");
            double N2= double.Parse(Console.ReadLine());


            double M3 = (N1 + N2) / 2;
            
            

            if (M3>5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Você foi aprovado com honrarias ao obter a nota {M3}.");
            }
            else if (M3==5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Você foi aprovado dentro da média {M3}.");
            }
            else 
            {
                Console.Clear();          
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ao atingir a média {M3}, você não atinge as exigências do curso e está reprovado.");
            }
        }
    }
}
       
   
