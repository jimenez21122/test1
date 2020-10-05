using System;
using System.Collections.Generic;
using System.Text;

namespace test1
{
    class Ejercicios
    {
        //Ejercicio: hacer una funcion que imprima por pantalla los números

        public static void Ejercicio1()
        {
            int contador;
            contador = 0;
            while (contador < 100);
            {
                System.Console.WriteLine(contador);
                // contador = contador + 1;
                // contador += 1;
                contador++;
            }

        }
        //Ejercicio: haz una funcion que imprima por pantalla numeros pares desde el 0 hasta n
        
        public static void Ejercicio2(int n)
        {
            int i = 0;
            while (i < n)
            {
                if (Utils.IsEven(i))
                    System.Console.WriteLine(i);
                i++;
            }
        }
        //Ejercicio : haz una funcion que imprima por pantalla si el numero seleccionado es primo o no

        public static void Ejercicio3(int number)
        {
            Utils.IsPrime(137)
                System.Console.WriteLine
        }
    }
}
