using System;
using System.Globalization;

namespace exerciciosfixar
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "computador";
            string produto2 = "mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'm';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;
            Console.WriteLine("produtos:");
            Console.WriteLine(produto1 + ",cujo preço é$" + preco1);
            Console.WriteLine(produto2 + ", cujo o preço é" + preco2);
            Console.WriteLine("                            ");
            Console.WriteLine("registro: " + idade + " de idade, codigo:" + codigo + " e gênero:" + genero);
            Console.WriteLine("                            ");
            Console.WriteLine("Medida com oito casas decimais :" + medida.ToString("f8"));
            Console.WriteLine("Arredondando (tres casas decimais):" + medida.ToString("f3"));
            Console.WriteLine("separador decimal invariant culture: "+medida.ToString(CultureInfo.InvariantCulture));
        }
    }
}
