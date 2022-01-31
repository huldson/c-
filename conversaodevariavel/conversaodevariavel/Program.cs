using System;

namespace conversaodevariavel
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 10;
            double b = a;

            //double c = 10;
            // float d = c; // da erro porque a float pega 4 bites de memoria e double pega 8 bites consegue armazena ao contrario como ex acima 

            // forma correta

            double f = 10;
            float x = (float)f;

            int q = 5;
            int t = 2;


            double resultado = q / t;
            double resultado2 =(double) q / t;// como as variaveis estão em inteiro a respota tambem vem em int, por isso necessario converter.
            Console.WriteLine(resultado);
            Console.WriteLine(resultado2);
            double aoquadrado = Math.Pow(q, 2);
            double raizquadrada = Math.Sqrt(25);
            Console.WriteLine(aoquadrado);
            Console.WriteLine(raizquadrada);
        }
    }
}
