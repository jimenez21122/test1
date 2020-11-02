
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
        public static int compare (int a, int b)
        {
            if (a < b)
                return -1;
            if (a > b)
                return +1;
            return 0;
        }
        //Ejercicio 7: Hcer una función que te devuelva el menor de tres enteros
        public static int Get3MinValue (int a, int b, int c)
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
            switch(code)
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
        public static void Add3( int n)
        {
            int i = 0;
            while (i <= n)
            {

                System.Console.Write(i + ",");
                i+= 3;
            }
        }
        /*Hacer una función a la que se le pase un número e imprima por pantalla la siguiente serie:
         Serie(10)-> 0,1,2,3,4,5,6,7,8,9,*/
        public static void SerieContinua (int n)
        {
            
            for (int i = 0; i < n; i++)
            
                System.Console.Write(i + ",");
        }
        /*Hacer una función a la que se le pase un número e imprima por pantalla la siguiente serie:
         Serie(10)-> 0,1,2,3,4,5,6,7,8,9 */
        public static void SerieContinuaV2(int n)
        {
            if(n > 0)
            
                System.Console.Write("0");
            
            for (int i = 1; i < n; i++)

                System.Console.Write("," + i);    
        }
    }
}
