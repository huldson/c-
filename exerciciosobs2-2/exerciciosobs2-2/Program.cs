using System;
using System.Globalization;

namespace exerciciosobs2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            funcionario F = new funcionario();
            Console.Write("Nome do funcionario :");
            F.Nome = Console.ReadLine();
            Console.Write("salario bruto :");
            F.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("impostos :");
            F.Impostos = double.Parse(Console.ReadLine());
            Console.WriteLine(F);
            Console.Write("diigite a porcentagem do aumento do salario :");
            double porcent = double.Parse(Console.ReadLine());
            F.AumentoSalarial(porcent);
            Console.WriteLine(F);

        }
    }
}
