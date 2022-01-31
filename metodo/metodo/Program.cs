using System;
using System.Globalization;
namespace metodo
{
    class Program
    {
        static void Main(string[] args)
        {
            triangulo primeiro = new triangulo();
            triangulo segundo = new triangulo();
            Console.WriteLine("informe os lados do primeiro triangulo:");
            primeiro.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            primeiro.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            primeiro.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("informe os lados do segundo triangulo:");
            segundo.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            segundo.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            segundo.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double areap = primeiro.area();
            double areas = segundo.area();

            Console.WriteLine(areap);
            Console.WriteLine(areas);
        }
    }
}


