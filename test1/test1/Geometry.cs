using System;
using System.Collections.Generic;
using System.Text;

namespace test1
{
    class Geometry
    {
        public static double GetVectorLenght( double x, double y)

        {
            double aux;
            double lenght;
            aux = x * x + y * y;
            lenght = System.Math.Sqrt(aux);
            return lenght; 
        }

    }
        
}
