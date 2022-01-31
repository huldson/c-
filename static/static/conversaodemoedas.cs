using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace static1
{
    class conversaodemoedas
{
        public static double iof = 6.0;


        public static string conversor(double moeda ,double dolar)
        {
            double resultado = (moeda * dolar) + ((moeda * dolar) * (iof / 100));
            return resultado.ToString("f2",CultureInfo.InvariantCulture);
        }
}
}
