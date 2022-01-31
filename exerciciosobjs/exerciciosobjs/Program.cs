using System;
using System.Globalization;

namespace exerciciosobjs
{
    class Program
    {
        static void Main(string[] args)
        {
            /* pessoa primeira, segunda;

             primeira = new pessoa();
             segunda = new pessoa();
             Console.WriteLine("dados da primeira pessoa:");
             Console.Write("nome:");
              primeira.nome= Console.ReadLine();
             Console.Write("idade:");
             primeira.idade = int.Parse(Console.ReadLine());
             Console.WriteLine("dados da segunda pessoa:");
             Console.Write("nome:");
             segunda.nome = Console.ReadLine();
             Console.Write("idade:");
             segunda.idade = int.Parse(Console.ReadLine());

             if (primeira.idade > segunda.idade)
             {
                 Console.WriteLine("Mais velho é "+primeira.nome);
             }
             else if(primeira.idade == segunda.idade)
             {
                 Console.WriteLine("Os dois tem a mesma idade");
             }
             else
             {
                 Console.WriteLine("Mais velho é " + segunda.nome);
             }
         */

            funcionario f1 = new funcionario();
            funcionario f2 = new funcionario();
            Console.WriteLine("funcionarios: ");
            Console.WriteLine("primeiro funcionairo: ");
            Console.Write("nome: ");
            f1.nome = Console.ReadLine();
            Console.Write("salario: ");
            f1.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("segundo funcionario :");
            Console.Write("nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("salario: ");
            f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double MediaSal = media(f1.salario,f2.salario);
            Console.Write("media salarial:"+MediaSal.ToString("f2",CultureInfo.InvariantCulture));


        }
        public static Double media(double x,double y)
        {
            return (x + y) / 2;
        }
    }
}
