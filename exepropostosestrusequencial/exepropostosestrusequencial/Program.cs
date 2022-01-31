using System;
using System.Globalization;
namespace exepropostosestrusequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int resultado = x + y;
            Console.WriteLine("soma:"+resultado);

            double pi = 3.14159;

            double raio = double.Parse(Console.ReadLine());

            double area = raio * raio * pi;
            Console.WriteLine("A :"+ area.ToString("f4", CultureInfo.InvariantCulture));

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int diferenca = (a*b-c*d);
            Console.WriteLine("difenreça: "+diferenca);


            Console.Write("matricula: ");
            int matricula = int.Parse(Console.ReadLine());
            Console.Write("horas trabalhas: ");
            double horasT = double.Parse(Console.ReadLine());
            Console.Write("valor da hora: ");
            double hora = double.Parse(Console.ReadLine());

            double salario = horasT * hora;
            Console.Write("matricula:" + matricula);
            Console.WriteLine("salario: " + salario.ToString("f2",CultureInfo.InvariantCulture));


            Console.Write("digite codigo e quantidade de peças e valor da peça 1");
            int condigo1 = int.Parse(Console.ReadLine());
            int peca1 = int.Parse(Console.ReadLine());
            double valor1 = double.Parse(Console.ReadLine());

            Console.Write("digite codigo e quantidade de peças e valor da peça 2");
            int condigo2 = int.Parse(Console.ReadLine());
            int peca2 = int.Parse(Console.ReadLine());
            double valor2 = double.Parse(Console.ReadLine());

            double valorPagar = (peca1 * valor1) + (peca2*valor2);
            Console.WriteLine ("valor a pagar "+valorPagar.ToString("f2",CultureInfo.InvariantCulture));


            double triangulo, circulo, trapezio, quadrado, retangulo;

            string[] vet = Console.ReadLine().Split(' ');
            double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            triangulo = (A * C) / 2;
            circulo = (C*C)*3.14159;
            trapezio = (A + B) * C / 2;
            quadrado = B * B;
            retangulo = A * B;
            Console.WriteLine(triangulo.ToString("f3",CultureInfo.InvariantCulture));
            Console.WriteLine(circulo.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine(trapezio.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine(quadrado.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine(retangulo.ToString("f3", CultureInfo.InvariantCulture));
        }
    }
}
