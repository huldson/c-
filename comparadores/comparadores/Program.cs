using System;

namespace comparadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 10;
            bool cl = k > 10;
            bool cl1 = k < 10;
            bool cl2 = k >= 10;
            bool cl3 = k <= 10;
            bool cl4 = k == 10;
            bool cl5 = k != 10;

            Console.WriteLine(cl);
            Console.WriteLine(cl1);
            Console.WriteLine(cl2);
            Console.WriteLine(cl3);
            Console.WriteLine(cl4);
            Console.WriteLine(cl5);

            bool vl = 4 > 3 && 8 != 4;
            bool v2 = !(4 > 3) && 8 != 4;// ! nega a condição.
            Console.WriteLine(vl);
            Console.WriteLine(v2);

        }
    }
}
