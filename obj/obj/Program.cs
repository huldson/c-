using System;
using System.Globalization;

namespace obj
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Console.WriteLine("digite os lados do triagulo X ");
             string[] XLADOS = Console.ReadLine().Split(' ');
             double lado1x = double.Parse(XLADOS[0],CultureInfo.InvariantCulture);
             double lado2x = double.Parse(XLADOS[1], CultureInfo.InvariantCulture);
             double lado3x = double.Parse(XLADOS[2], CultureInfo.InvariantCulture);
             double px = (lado1x + lado2x + lado3x) / 2;
             double areax = Math.Sqrt(px * (px - lado1x) * (px - lado2x) * (px - lado3x));
             Console.WriteLine("digite os lados do triangulo y ");

             string[] Ylados = Console.ReadLine().Split(' ');
             double lado1y = double.Parse(Ylados[0], CultureInfo.InvariantCulture);
             double lado2y = double.Parse(Ylados[1], CultureInfo.InvariantCulture);
             double lado3y = double.Parse(Ylados[2], CultureInfo.InvariantCulture);
             double py = (lado1y + lado2y + lado3y) / 2;
             double areay = Math.Sqrt(py * (py - lado1y) * (py - lado2y) * (py - lado3y));
             Console.WriteLine("area do triangulox :"+areax.ToString("f4",CultureInfo.InvariantCulture));
             Console.WriteLine("area do trianguloy :" + areay.ToString("f4", CultureInfo.InvariantCulture));
             if (areax > areay)
             {
                 Console.WriteLine("a area do x é maior");
             }
             else if (areax == areay)
             {
                 Console.WriteLine("são iguais");
             }
             else
             {
                 Console.WriteLine("o y é maior");
             }
            */
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            Console.WriteLine("digite os lados do triangulo x ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pX = (x.A + x.B + x.C) / 2;
            double areaX = Math.Sqrt(pX * (pX - x.A) * (pX - x.B) * (pX - x.C));
            Console.WriteLine("digite os lados do triangulo y ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pY = (y.A + y.B + y.C) / 2;
            double areaY = Math.Sqrt(pY * (pY - y.A) * (pY - y.B) * (pY - y.C));
            Console.WriteLine("area x:"+areaX.ToString("f4",CultureInfo.InvariantCulture));
            Console.WriteLine("area y:" + areaY.ToString("f4", CultureInfo.InvariantCulture));
            if (areaX > areaY)
            {
                Console.WriteLine("triangulo x maior");

            }
            else
            {
                Console.WriteLine("triangulo y maior");
            }
        }
    }
}
