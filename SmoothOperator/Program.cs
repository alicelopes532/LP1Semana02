using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Insere um número inteiro: ");
            while (!int.TryParse(Console.ReadLine(), out numero) || numero < sbyte.MinValue || numero > sbyte.MaxValue)
            Console.WriteLine(--numero);
            Console.WriteLine(++numero);
            
        }
    }
}

