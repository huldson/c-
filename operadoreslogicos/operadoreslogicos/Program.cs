using System;

namespace operadoreslogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);
            a += 2;
            Console.WriteLine(a);
            a = a + 2;
            Console.WriteLine(a);
            a *= 3;
            Console.WriteLine(a);
            a /= 3;
            Console.WriteLine(a);
            string name = "ABC";
            Console.WriteLine(name);
            name += "DEF";// consegue acrecentar strings
            Console.WriteLine(name);
            int c = 10;
            int d = c++;// se passar como referenci assim ele só vai a variaevel sem acrecentar o valor a mais.
            Console.WriteLine(c);
            Console.WriteLine(d);

            int r = 10;
            int v = ++r;// assim acrecenta. vira 11 no exercicio de cima continua 10
            Console.WriteLine(r);
            Console.WriteLine(v);
        }
    }
}
