using System;
using System.Globalization;

namespace whille
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.Write("escolha uma senha :");
             int x = int.Parse(Console.ReadLine());
             int senha = 0;
             while (x != senha)
             {
                 Console.Write("repita sua senha :");
                 senha = int.Parse(Console.ReadLine());
                 if (senha != x) { Console.WriteLine("senha invalida"); }
             }
             Console.WriteLine("senha valida");*/



            /*Console.Write("DIGITE VALOR DE X:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("DIGITE VALOR DE Y:");
            int y = int.Parse(Console.ReadLine());

            while (0 != x && 0 != y) {

                if (x < 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x > 0 && y > 0) {

                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {

                    Console.WriteLine("terceiro");
                }
                else if (x > 0 && y < 0)
                {

                    Console.WriteLine("quarto");
                }

                Console.Write("DIGITE VALOR DE X:");
                 x = int.Parse(Console.ReadLine());
                Console.Write("DIGITE VALOR DE Y:");
                 y = int.Parse(Console.ReadLine());

            }*/

            int alc = 0;
            int gas = 0;
            int dies = 0;
            int x = 0;
            Console.WriteLine("digite para 1 alcool");
            Console.WriteLine("digite para 2 gasolina");
            Console.WriteLine("digite para 3 diesel");
            Console.WriteLine("digite para 4 para sair");
            while (x != 4)
            {
                if (x == 1)
                {
                    alc++;
                }
                else if (x == 2)
                {
                    gas++;
                }
                else if (x == 3)
                {
                    dies++;
                }
                else
                {
                    
                }
                x = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("muito obrigado");
            Console.WriteLine("alcool :"+alc);
            Console.WriteLine("gasolina :"+gas);
            Console.WriteLine("diesel :"+dies);

        }

    }
}
