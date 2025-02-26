using System;
using System.ComponentModel;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Insere um número inteiro não negativo: ");
            while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0 || byte.MaxValue)
            Console.WriteLine(numero / 2);
            Console.WriteLine(numero << 3);
            Console.WriteLine(numero ^ 6);
            Console.WriteLine(numero > 10);
        }
    }
}
