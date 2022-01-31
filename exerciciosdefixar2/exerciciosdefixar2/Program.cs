using System;
using System.Globalization;
namespace exerciciosdefixar2
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.Write("digite seu nome : ");
            string nome = Console.ReadLine();
            Console.Write("quantos quartos tem sua casa : ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("preco do produto : ");
            double produto = double.Parse(Console.ReadLine());
            Console.Write(" digite o nome e idade e a altura : ");
            string[] info = Console.ReadLine().Split(' ');
            string nome1 = info[0];
            int idade1 = int.Parse(info[1]);
            double altura = double.Parse(info[2]);
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(produto.ToString("f2",CultureInfo.InvariantCulture));
            Console.WriteLine(nome1);
            Console.WriteLine(idade1);
            Console.WriteLine(altura.ToString("f2", CultureInfo.InvariantCulture));*/

            int hora = int.Parse(Console.ReadLine());

            if (hora <12)
            {
                Console.WriteLine("bom dia! são "+hora+":00 horas");
            }
            else if(hora<18)
            {
                Console.WriteLine("bom tarde! são " + hora + ":00 horas");

            }
            else if (hora < 24)
            {
                Console.WriteLine("bom noite! são " + hora + ":00 horas");
            }
            else
            {
                Console.WriteLine("hora envalida!");
            }



        }
    }
}
