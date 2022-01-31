using System;
using System.Globalization;// para poder transformar virgula em ponto
namespace course
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'f';
            Console.WriteLine(int.MaxValue);
            string nome = "maria de souza ";//para cadeia de caracteres é aspas duplas
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            double n5 = 4.5;
            float n6 = 4.5f;
            float n8 = 34.5533f;
            long n4 = 2147483648L;// recomendoado a usar L NO FINAL PARA SABER QUE É NUMERO LONGO
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n8.ToString("f2"));//f mais o numero de casa decimais apos a virgula.
            Console.WriteLine(n8.ToString("f3", CultureInfo.InvariantCulture));//pra isso a segunda biblioteca
        }
    }
}
