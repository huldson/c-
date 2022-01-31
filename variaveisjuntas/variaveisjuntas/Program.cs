using System;

namespace variaveisjuntas
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "pedro de oliveira ";
            float valor = 23.4495f;
            int idade = 30;
            Console.WriteLine("{0} tem {1} anos e o valor igual a R${2:f2}",nome,idade,valor);//placeholders
            Console.WriteLine(nome+" tem " + idade + " anos e o valor igual a R$"+valor.ToString("f2"));//concatenação
            Console.WriteLine($"{nome} tem {idade} anos e o valor igual a R${valor:f2} ");//interpolação
        }
    }
}
