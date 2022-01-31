using System;

namespace ifesle1
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            if (x == "dia")
            {
                Console.WriteLine("bom dia ");
            }
            else if (x == "tarde"){
                Console.WriteLine("boa tarde ");
            }
            else
            {
                Console.WriteLine("boa noite");
            }
        }
    }
}
