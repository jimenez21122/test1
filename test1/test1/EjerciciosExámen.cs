
using System.Reflection;

namespace test1
{
    class EjerciciosExámen
    {
        //Ejercicio 1: hacer una función a la que se le pasen dos números enteros y devuelva el resultado
        //de la suma de esos dos números
        public static int AddNum(int n1, int n2)
        {
            int result = n1 + n2;
            return result;
            //Una foma mejorada sería simplemente: 
            //return: n1 + n2
        }

        //Ejercicio 2: Hacer una función que reciba 2 reales y devuleva la resta de esos dos reales
        public static float Resta(float a, float b)
        {
            return a - b;
            //Tambien puede ser double
        }

        //Ejercicio 3: Hacer una función a la que se le pasen dos enteros y devuelva el menor de ellos
        public static int MinValue(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            return b;
            // Funciona pero deberia tener "else" entre a y b
        }

        //Ejercicio 4: Hacer una función que reciba como parámetro 2 números y devuelva si el primero es menor 
        // que el segundo
        public static bool ReturnValue(int a, int b)
        {
            if (a < b)
            {
                return true;
            }
            return false;
        }

        //Ejercicio 5: Hacer una función que se pasen 3 string y devuelva la concatenación de los strings
        public static string Cat(string s1, string s2, string s3)
        {
            return s1 + s2 + s3;
        }
        //Ejercicio 6: Hacer una función que reciba 2 enteros y devuelva -1 si el primero es menos que el segundo 
        // +1 si el segundo es menor que el primero, 0 en cualquier otro caso (que sean iguales)
        public static int compare(int a, int b)
        {
            if (a < b)
                return -1;
            if (a > b)
                return +1;
            return 0;
        }
        //Ejercicio 7: Hcer una función que te devuelva el menor de tres enteros
        public static int Get3MinValue(int a, int b, int c)
        {
            if (a <= b && a <= c)
                return a;
            if (b < c)
                return b;
            return c;
            /*Solución óptima:
             if (a < b)
            {
                if (a < c)
                    return a;
                else 
                    return c;
            }
             else
            {
                if (b < c)
                    return b;
                else
                    return c;
            }
            Es la más optima por el número de instrucciones, en este caso 2*/
        }
        /*Ejercicio 8: Hacer una función que reciba un código de error e imprima por pantalla lo siguiente 
         "error grave" si el código de error es 0 
         "error moderado" si el código de error es 1
         "error leve" si el código de error es 2
         "error desconocido en cualquier otro caso"*/
        public static void PrintError(int code)
        {
            switch (code)
            {
                case 0:
                    System.Console.WriteLine("Error Grave");
                    break;
                case 1:
                    System.Console.WriteLine("Error moderado");
                    break;
                case 2:
                    System.Console.WriteLine("Error leve");
                    break;
                default:
                    System.Console.WriteLine("Error desconocido");
                    break;
            }
        }
        /*Hacer una función a la que se le pase un número e imprima por pantalla la siguiente serie:
        función(10)-> 0,3,6,9
        función (15)-> 0,3,6,9,12,15*/
        public static void Add3(int n)
        {
            int i = 0;
            while (i <= n)
            {

                System.Console.Write(i + ",");
                i += 3;
            }
        }
        /*Hacer una función a la que se le pase un número e imprima por pantalla la siguiente serie:
         Serie(10)-> 0,1,2,3,4,5,6,7,8,9,*/
        public static void SerieContinua(int n)
        {

            for (int i = 0; i < n; i++)

                System.Console.Write(i + ",");
        }
        /*Hacer una función a la que se le pase un número e imprima por pantalla la siguiente serie:
         Serie(10)-> 0,1,2,3,4,5,6,7,8,9 */
        public static void SerieContinuaV2(int n)
        {
            if (n > 0)

                System.Console.Write("0");

            for (int i = 1; i < n; i++)

                System.Console.Write("," + i);
        }
        /* Hacer una función a la que se le pase un número n he imprima una serie de asteriscos 
         en función del número que se pongan*/
        public static void Asteriscos(int n)
        {
            for (int i = 0; i < n; i++)
                System.Console.Write("*");
        }
        /* Hacer una función a la que se le pase un número n he imprima una serie de asteriscos 
         en función del número que se pongan*/
        public static void Asteriscosmás(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if ((i % 2) == 0)
                    System.Console.Write("*");
                else
                    System.Console.Write("+");
            }
        }
        /*Hace una función que devuelva el menor valor de 9 enteros*/
        public static int Get9MinValue(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8, int n9)
        {
            return Get3MinValue(Get3MinValue(n1, n2, n3), Get3MinValue(n4, n5, n6), Get3MinValue(n7, n8, n9));
        }
        /* Hcer una función que imprima por pantalla un cuadrado formado por "*" igual al número que haya puesto*/
        public static void Cuadrado(int n)
        {
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }
        //Ejercicio
        public static void Cuadrado2(int n)
        {
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    if ((f % 2) == 0)
                        System.Console.Write("+");
                    else

                        System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }
        //Ejercicio
        public static void Triangulo(int n)
        {

        }
        //Ejercicio
        public static void Triangulo2(int n)
        {
            for (int f = 0; f < n; f++)
            {
                int nesp = n - f - 1;
                int nast = f + 1;
                for (int c = 0; c < nesp; c++)
                {
                    System.Console.Write(" ");
                }
                for (int c1 = 0; c1 < nast; c1++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }
        //Ejercicio
        public static void Triangulo3(int n)
        {
            for (int f = 0; f < n; f++)
            {
                int nesp1 = n - f - 1;
                int nesp2 = f * 2;
                for (int c = 0; c < nesp1; c++)
                {
                    System.Console.Write(" ");
                }
                System.Console.Write("*");
                for (int c1 = 0; c1 < nesp2; c1++)
                {
                    System.Console.Write(" ");
                }
                System.Console.Write("*");
                System.Console.WriteLine();
            }
        }
        //Ejercicio
        public static void Triangulo4(int n)
        {
            for (int f = 0; f < n; f++)
            {
                int nesp1 = f * 2;
                int nesp2 = (n - f - 1) * 2;
                for (int c = 0; c < nesp1; c++)
                {
                    System.Console.Write(" ");
                }
                System.Console.Write("*");
                for (int c1 = 0; c1 < nesp2; c1++)
                {
                    System.Console.Write(" ");
                }
                System.Console.Write("*");
                System.Console.WriteLine();
            }
        }
        public static void Triangulo5(int n)
        {
            Triangulo3(n);
            Triangulo4(n);
        }
        /*Hacer una función que devuelva 2 elevado a n, siendo n el parámetro que recibe
          la función*/
        public static int square(int n)
        {
            int result = 1;
            for (int i = 0; i < n; i++)
            {
                result *= 2;
            }
            return result;
        }
        //Hacer una función que imprima por pantalla la bandera de estdos Unidos
        public static void USA()
        {
            for (int f = 0; f <= 10; f++)
            {
                for (int c = 0; c <= 70; c++)
                {
                    if (0 <= c && c <= 8 && 0 <= f && f <= 4)
                    {
                        int flag = f + c;
                        if ((flag % 2) == 0)
                        {
                            System.Console.Write("+");
                        }
                        else
                        {
                            System.Console.Write(" ");
                        }
                    }
                    else if ((f % 4) < 2)
                    {
                        System.Console.Write("=");
                    }
                    else
                    {
                        System.Console.Write(" ");
                    }
                }
                System.Console.WriteLine();
            }
        }
        //Hacer una función que devuelva la distancia entre dos puntos 2D
        public static double distancia2D(double x1, double y1, double x2, double y2)
        {
            double vx = x1 - x2;
            double vy = y1 - y2;
            return System.Math.Sqrt(vx * vx + vy * vy);
        }
        //Hacer una función que imprima por pantalla la bandera de Japon.
        public static void LiveInJapan()
        {
            for (int f = 0; f <= 15; f++)
            {
                for (int c = 0; c <= 70; c++)
                {
                    if (f == 0 || f == 14 || c == 0 || c == 69)
                    {
                        System.Console.Write("-");
                    }
                    else if (distancia2D(35, 7, c, f) <= 6)
                    {
                        System.Console.Write("O");
                    }
                    else
                    {
                        System.Console.Write(" ");
                    }
                }
                System.Console.WriteLine();
            }
        }
        //Implemanta una función que devuelva el sumatorio de un número 
        public static int Sumatorio (int n)
        {
            int result = 1;
            for (int i =  1; i <= n; i++)

                result += i;
          
            return result;
        }
    }   
}
