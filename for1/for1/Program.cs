using System;

namespace for1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.Write("digite o um valor " );
             int x = int.Parse(Console.ReadLine());

             for(int i = 0; i <=x; i++)
             {
                 if (i % 2 != 0)
                 {
                     Console.WriteLine(i);
                 }
             }*/

            int x = int.Parse(Console.ReadLine());
            int fora = 0;
            int dentro = 0;
            int y;
            for (int i = 0; i < x; i++)
            {
                y = int.Parse(Console.ReadLine());
                if (y >= 10 && y <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }
            Console.WriteLine(dentro+" in");
            Console.WriteLine(fora + " out");
        }
    }
}
