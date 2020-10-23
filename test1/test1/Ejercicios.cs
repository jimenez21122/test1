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
            while (contador < 100) ;
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
            int i = 2;
            while (i < number)
            {
                if (Utils.IsPrime(i))
                    System.Console.WriteLine(number + " no es primo");

                else
                    System.Console.WriteLine(number + " es primo");
            }
        }
        //Ejercicio: imprime por pantalla la serie de 1 al 100

        public static void Ejercicio4()
        {
            int i = 0;
            while (i < 100)
            {

                System.Console.WriteLine(i);
                i++;

            }
        }
        //Ejercicio: imprime por pantalla la serie: 3,6, 9, 12, 15

        public static void Ejercicio5()
        {
            int i = 0;
            while (i < 100)
            {
                System.Console.WriteLine(i * 3);
                i++;
            }
        }
        //Ejercicio: imprime por pantalla la serie: -5,-4,-3,-2,-1,0

        public static void Ejercicio6()
        {
            int i = 0;
            while (i < 100)
            {
                System.Console.WriteLine(5 - i);
                i++;
            }
        }
        //Ejercicio: imprime por pantalla la serie: 0, -1, 2, -3, 4, -5
        public static void Ejercicio7()
        {
            int i = 0;
            while (i < 100)
            {
                if (Utils.IsEven(i))
                    System.Console.WriteLine(i);

                else
                    System.Console.WriteLine(-i);
 
                i++;
            }
        }
        //ejrcicio: ¿Te acuerdas de Fibonacci pues yo tampoco, imprime la siguiente serie: 0, 1, 1, 2, 3, 5, 8...
        public static void Ejercicio8()
        {
            int i = 0;
            int a = 1;
            int aa = 0;
            System.Console.WriteLine(aa);
            System.Console.WriteLine(a);
            while (i < 100)
            {
                System.Console.WriteLine(a + aa);
                int aux = a;
                
                aa = a + aa;
                a = aux; 

                i++;
            }
        }
        //ejercicio: imprime por pantalla tantos asteriscos como el número que escribas
        public static void Asteriscos(int count)
        {
            int i = 0;
            while (i < count)
            {
                System.Console.WriteLine("*");
                i++;

            }

        }
    }
}
