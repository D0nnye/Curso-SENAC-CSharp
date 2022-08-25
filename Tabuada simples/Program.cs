using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada_simples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int N = Int32.Parse(Console.ReadLine());

            Console.Clear();

            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.ForegroundColor = color;
                Console.Clear();
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|*************|");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("|***Tabuada***|");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|*************|");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" 1  x  " + N + "=" + (1 * N));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" 2  x  " + N + "=" + (2 * N));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 3  x  " + N + "=" + (3 * N));
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" 4  x  " + N + "=" + (4 * N));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" 5  x  " + N + "=" + (5 * N));
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" 6  x  " + N + "=" + (6 * N));
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" 7  x  " + N + "=" + (7 * N));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" 8  x  " + N + "=" + (8 * N));
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" 9  x  " + N + "=" + (9 * N));
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" 10 x  " + N + "=" + (10 * N));


        }
    }
}
