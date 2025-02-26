using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Valores Mínimos e Máximos de Tipos Numéricos:");
            Console.WriteLine($"sbyte:   {sbyte.MinValue} a {sbyte.MaxValue}");
            Console.WriteLine($"byte:    {byte.MinValue} a {byte.MaxValue}");
            Console.WriteLine($"short:   {short.MinValue} a {short.MaxValue}");
            Console.WriteLine($"ushort:  {ushort.MinValue} a {ushort.MaxValue}");
            Console.WriteLine($"int:     {int.MinValue} a {int.MaxValue}");
            Console.WriteLine($"uint:    {uint.MinValue} a {uint.MaxValue}");
            Console.WriteLine($"long:    {long.MinValue} a {long.MaxValue}");
            Console.WriteLine($"ulong:   {ulong.MinValue} a {ulong.MaxValue}");
            Console.WriteLine($"float:   {float.MinValue} a {float.MaxValue}");
            Console.WriteLine($"double:  {double.MinValue} a {double.MaxValue}");
            Console.WriteLine($"decimal: {decimal.MinValue} a {decimal.MaxValue}");
            
            Console.WriteLine("\nValores Especiais de float e double:");
            Console.WriteLine($"Float -∞: {float.NegativeInfinity}");
            Console.WriteLine($"Float +∞: {float.PositiveInfinity}");
            Console.WriteLine($"Float NaN: {float.NaN}");

            Console.WriteLine($"Double -∞: {double.NegativeInfinity}");
            Console.WriteLine($"Double +∞: {double.PositiveInfinity}");
            Console.WriteLine($"Double NaN: {double.NaN}");

            Console.WriteLine("\nTeste de Overflow em float:");
            float overflowFloat1 = float.MaxValue * 2;
            float overflowFloat2 = float.MaxValue * float.MaxValue;

            Console.WriteLine($"float.MaxValue * 2 = {overflowFloat1}");
            Console.WriteLine($"float.MaxValue * float.MaxValue = {overflowFloat2}");

            Console.WriteLine("\nTeste de Underflow em float:");
            float underflowFloat = float.MinValue / 2;
            Console.WriteLine($"float.MinValue / 2 = {underflowFloat}");
        }
    }
}
