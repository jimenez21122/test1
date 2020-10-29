
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
        public static float Resta (float a, float b)
        {
            return a - b;
            //Tambien puede ser double
        }

        //Ejercicio 3: Hacer una función a la que se le pasen dos enteros y devuelva el menor de ellos
        public static int MinValue (int a, int b)
        {
            if(a < b)
            {
                return a;
            }
                return b;
            // Funciona pero deberia tener "else" entre a y b
        }
          
        //Ejercicio 4: Hacer una función que reciba como parámetro 2 números y devuelva si el primero es menor 
        // que el segundo
        public static bool ReturnValue (int a , int b)
        {
            if (a < b)
            {
                return true;
            }
            return false;
        }
    }
}
