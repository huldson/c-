using System;
using System.Globalization;
namespace exerciciosobjs2
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.Write("digite a altura do retangulo: ");
            r.Altura =double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("digite a base do retangulo: ");
            r.Base= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(r);
        }
    }
}
