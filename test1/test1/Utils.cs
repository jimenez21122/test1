using System;
using System.Collections.Generic;
using System.Text;

namespace test1
{
    class Utils
    {
        public static int GetMinValue(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                if (a < b);
            }
            return b;
            {


            }
        }

        // IsEven devuelve el valor true si el valor es par y false en caso contrario.
        public static bool IsEven(int value)
        {
            if ((value % 2) == 0)
                return true;
            else
                return false;
        }

        public static bool IsPrime( int number)
        {
            int i = 2;
            while (i < number)
            {
                if ((number % i) == 0)
                return false;
                i++;
            }
                return true;    
        }
        //public static int Count( int i)


    }
}



    





