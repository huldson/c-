using System;
using System.Globalization;
namespace exerciciospropostosifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * exercicio 1
             * int x = int.Parse(Console.ReadLine());

            if (x<0) {
                Console.WriteLine("é negativo");
            }
            else
            {
                Console.WriteLine(" não é negativo");
            }
            Console.Write( "digite dois numero para ver se são multiplos: " );
            string[] vet = Console.ReadLine().Split(" ");

            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("são multiplos");

            }
            else
            {
                Console.WriteLine("não são multiplos");
            }
            int cachorro = 1;
            int xsalada = 2;
            int xbacon = 3;
            int torrada = 4;
            int refri = 5;
            double valor = 00.00;


            string[] vet = Console.ReadLine().Split(' ');

            int opcao = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);

            if (opcao == 1)
            {
                valor = 4.00 * quantidade;
            }
              else if (opcao == 2)
            {
                valor = 4.50 * quantidade;
            }
            else if (opcao == 3)
            {
                valor = 5.00 * quantidade;
            }
            else if (opcao == 4)
            {
                valor = 2.00 * quantidade;
            }
            else if (opcao == 5)
            {
                valor = 1.50 * quantidade;
            }
            Console.WriteLine("valor a pagar R$: "+ valor.ToString("f2", CultureInfo.InvariantCulture));

            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor < 0||valor >100)
            {
                Console.WriteLine("fora dos limites");
            }
            else if (valor <= 25&& valor >=0)
            {
                Console.WriteLine("entre 0 e 25");
            }
            else if (valor  <=50)
            {
                Console.WriteLine("entre 25 e 50");
            }
            else if (valor <= 75)
            {
                Console.WriteLine("entre 50 e 75");
            }
            else if (valor <= 100)
            {
                Console.WriteLine("entre 75 e 100");}
            Console.Write("DIGITE VALOR DE X:");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("DIGITE VALOR DE Y:");
            double Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (x > 0 && Y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && Y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && Y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && Y < 0)
            {
                Console.WriteLine("Q4");
            }
            else
            {
                Console.WriteLine("origem");
            }*/

            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double juros = 00.00;
            double valor = 00;
            if (salario <= 2000.00)
            {
                Console.WriteLine("isento");
            }
            else if (salario<3000.00) {
                valor = salario - 2000;
                juros = valor * 0.08;
                Console.WriteLine("R$"+juros.ToString("f2",CultureInfo.InvariantCulture));
            }
            else if (salario < 4500.00)
            {
                valor = salario - 3000.00;
                juros = (valor * 0.18)+80;
                Console.WriteLine("R$"+juros.ToString("f2", CultureInfo.InvariantCulture));

            }
            else if (salario >4500.00)
            {
                valor = salario - 4500.00;
                juros = (valor * 0.28)+80+270;
                Console.WriteLine("R$"+juros.ToString("f2", CultureInfo.InvariantCulture));
            }
        }
    }
}
