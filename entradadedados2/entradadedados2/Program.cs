using System;
using System.Globalization;
namespace entradadedados2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());// necessario pois readline só ler em string  int.parse para converter pra int
            //char letra = char.Parse(Console.ReadLine());
            //double numero = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //Console.WriteLine("voce digitou :");
            //Console.WriteLine(n);
            //Console.WriteLine(letra);
            //Console.WriteLine(numero);

            String[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
            Console.Write(nome+" ");
            Console.Write(sexo + " ");
            Console.Write(idade + " ");
            Console.Write(altura.ToString("f2", CultureInfo.InvariantCulture) + " ");
        }
    }
}
