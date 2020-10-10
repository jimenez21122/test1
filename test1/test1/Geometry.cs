using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace test1
{
    class Geometry
    {
        public static double GetVectorLength2D( double x, double y)

        {
            double aux;
            double length;
            aux = x * x + y * y;
            length = System.Math.Sqrt(aux);
            return length; 
        }
        public static double GetVectorLength3D(double x, double y, double z)
        {
            double aux;
            double length;
            aux = x * x + y * y + z * z;
            length = System.Math.Sqrt(aux);
            return length;
        }
    }
        
}
