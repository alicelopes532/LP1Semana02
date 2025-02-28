using System;
using System.Diagnostics;

namespace PerfectCountdown
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 1)
            {
                Console.WriteLine("Out-of-range start or step. Try again.")
            }
            int step;
            Console.WriteLine("Step number: ");
            while (!int.TryParse(Console.ReadLine(), out step) || step < 1 || step > numero)
            {
                Console.WriteLine("Start must be higher than step. Try again.")
            }
            Console.WriteLine($"Start number: ");
            Console.WriteLine($"Step number: ");
        }
    }
}
