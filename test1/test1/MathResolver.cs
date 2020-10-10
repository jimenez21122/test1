using System;
using System.Collections.Generic;
using System.Text;

namespace test1
{
    class MathResolver
    {
        public static double SolveEquation(double a, double b, double c)
        {
            double aux1, aux2, x;
            aux1 = b * b - 4.0 * a * c ;
            aux2 = System.Math.Sqrt(aux1);
            x = ( -b + aux2) / (2 * a);
            return x;
        }     
    }
}
