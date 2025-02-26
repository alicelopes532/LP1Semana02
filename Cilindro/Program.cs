using System;
using System.Globalization;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double altura, raio;
            Console.WriteLine("Insere a altura do cilindro: ");
            while (!double.TryParse(Console.ReadLine(), NumberStyles.Float, out altura))
            Console.WriteLine("Insere o raio do cilindro: ");
            while (!double.TryParse(Console.ReadLine(), NumberStyles.Float, out raio))
            double volume = Math.PI * Math.Pow(raio, 2) * altura;
            double areaSuperficie = 2 * Math.PI * raio (raio + altura);
            Console.WriteLine($"Volume = {volume:F3}");
            Console.WriteLine($"Área de superfície = {areaSuperficie:F3}");
        }
    }
}
