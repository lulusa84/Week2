using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.CastEOperator
{
    public class Rombo : IShape
    {
        // si può calcolare a partire dae diagonali,
        // altrimenti si rischia di creare una figura incorente(lato tropo lungo)
        public double Lato { get; set; } 

        public double DiagonaleMaggiore { get; set; }

        public double DiagonaleMinore { get; set; }

        public Rombo(double lato, double dM, double dm)
        {
            Lato = lato;
            DiagonaleMaggiore = dM;
            DiagonaleMinore = dm;
        }

        public double Area()
        {
            return (DiagonaleMaggiore * DiagonaleMinore) * 0.5;
        }

        public bool isQadrilatero()
        {
            return true;
        }

        public double Perimetro()
        {
            return Lato * 4;
        }


        public static implicit operator Rombo(Quadrato q)
        {
            double lato = q.Base;
            double dM = q.Base * Math.Sqrt(2);
            double dm = dM;
            return new Rombo(lato, dM, dm);

        }

        

    }
}
