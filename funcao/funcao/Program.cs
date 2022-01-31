using System;

namespace funcao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite 3 valores:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int valor = maior(n1, n2, n3);
            Console.WriteLine(valor);
        }
        static int maior (int a, int b,int c)
        {
           int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else
            {
                if (b > c)
                {
                    m = b;
                }
                else
                {
                    m = c;
                }
            }
            return m;

        }
    }
}
