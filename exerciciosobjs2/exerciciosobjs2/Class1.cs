using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace exerciciosobjs2
{
    class Retangulo
    {
       public double Altura;
        public double Base;

        public double Area()
        {
            return (Base * Altura);
        }
        public double Perimetro()
        {
            return 2 * (Base + Altura);
        }
        public double Diagonal() {
            return Math.Sqrt((Base * Base) + (Altura * Altura));    
        }
        public override string ToString()
        {
            return "base:"+Area().ToString("F2",CultureInfo.InvariantCulture) + ", periometro "+
                Perimetro().ToString("F2", CultureInfo.InvariantCulture) 
                +", diagonal :"+Diagonal().ToString("F2", CultureInfo.InvariantCulture);

        }

    }

}
