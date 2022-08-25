using System;

namespace Notas
{
    class Program
    {
        static void Main(string[] args)
        {
  
            Console.WriteLine("Escreva a primeira nota");
            double N1= double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva a segunda nota");
            double N2= double.Parse(Console.ReadLine());


            double M3 = N1 / N2;



            if (M3<5)
            {
                Console.WriteLine($"Reprovado");
            }
            else if (M3==6)
            {
                Console.WriteLine("Média");
            }
            else
            {
                Console.WriteLine($"Aprovado");

            }
        }
    }
}
       
   
