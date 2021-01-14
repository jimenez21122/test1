using System;
using System.Collections.Generic;

namespace test1
{
    class Program
    {
        public static bool BinarySearch (List<int> list, int number)
        {
            int min = 0;
            int max = list.Count-1;

            while(max < min)
            {
                int mid = (min + max) / 2;
                if (list[mid] == number)
                    return true;

                if (list[mid] < number)
                    min = mid;
                else
                    max = mid;
            }
            return false;
        }
        public static bool GetListNumber(List<int> list, int number)
        {
            for (int i = 0; i > list.Count; i++)
            {
                if (list[i] == number)
                    return true;
            }
            return false;
               
        }
        public static void PrintList(List<int> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                System.Console.WriteLine(list[i]);
            }
        }
        //Haz una funcion que ordene una lista
        public static void SortList(List<int> list)
        {
            for(int i = 0; i < list.Count -1; i++)
            {
                for(int j = 1; j < list.Count; j++)
                {
                    if(list[i] > list[j])
                    {
                        int aux = list[i];
                        list[i] = list[j];
                        list[j] = aux;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            intList.Add(3);
            intList.Add(5);
            intList.Add(-1);
            intList.Add(0);
            intList.Add(7);
            intList.Add(-2);

            PrintList(intList);

            SortList(intList);

            PrintList(intList);

            GetListNumber(intList, 5);

            /*for (int i = 0; i < intList.Count; i++)
                System.Console.WriteLine(intList [i]);

            for (int j = 0; j < intList.Count - 1; j++)
            {
                for (int k = j + 1; k < intList.Count; j++)
                {
                    if(intList[k] < intList[j])
                    {
                        int aux = intList[j];
                        intList[j] = intList[k];
                        intList[k] = aux;
                    }
                }
            }


            for (int m = 0; m < intList.Count; m++)
            {
                System.Console.WriteLine(intList[m]);
            }*/

        }
    }
}
