using System;

namespace entradadedados
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            Console.WriteLine(frase);
            string s = Console.ReadLine();
            string[] v = s.Split(' ');// separados por espaço em braco
            Console.WriteLine(v[0]);
            string [] palavra = Console.ReadLine().Split(' ');// pode ser de forma direta

            string a = palavra[0];
            string b = palavra[1];
            string c = palavra[2];
        }
    }
}
