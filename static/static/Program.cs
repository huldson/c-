using System;
using System.Globalization;

namespace static1
{
    class Program
{
    static void Main(string[] args)
    {
        Console.Write("digite a cotação do dolar : ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("digite a cotação do dolar : ");
            double dolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            string  resultado = conversaodemoedas.conversor(cotacao,dolar);
            Console.WriteLine(resultado);
        }
    }
}
