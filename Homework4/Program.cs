using System;

namespace Homework4_ChangeMaxMinValues
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework 4
            //1.Создать два произвольных массива, подсчитать максимальное  и минимальное значение их элементов. Вывести на экран.
            //2.Поменять в массивах максимальные и минимальные значения местами

            int[] array1 = { 5, -7, 56, 1, 23 };

            int minValue = array1[0];
            int minPlace = 0;

            for (int i = 1; i < array1.Length; i++)
            {
                if (array1[i] < minValue)
                {
                    minValue = array1[i];
                    minPlace = i;
                }
            }

            int maxValue = array1[0];
            int maxPlace = 0;

            for (int i = 1; i < array1.Length; i++)
            {
                if (array1[i] > maxValue)
                {
                    maxValue = array1[i];
                    maxPlace = i;
                }
            }

            foreach (int item in array1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("minValue and place = {0}, {1}, maxValue and place = {2}, {3}", minValue, minPlace, maxValue, maxPlace);

            int oldMinPlace = array1[minPlace];
            array1[minPlace] = array1[maxPlace];
            array1[maxPlace] = oldMinPlace;

            foreach (int item in array1)
            {
                Console.WriteLine(item);
            }

            int[] array2 = { 98465, 3, 0, -45, 1568 };

            int minValue2 = array2[0];
            int minPlace2 = 0;

            for (int i = 1; i < array2.Length; i++)
            {
                if (array2[i] < minValue2)
                {
                    minValue2 = array2[i];
                    minPlace2 = i;
                }
            }

            int maxValue2 = array2[0];
            int maxPlace2 = 0;

            for (int i = 1; i < array2.Length; i++)
            {
                if (array2[i] > maxValue2)
                {
                    maxValue2 = array2[i];
                    maxPlace2 = i;
                }
            }

            foreach (int item in array2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("minValue and place = {0}, {1}, maxValue and place = {2}, {3}", minValue2, minPlace2, maxValue2, maxPlace2);

            int oldMinPlace2 = array2[minPlace2];
            array2[minPlace2] = array2[maxPlace2];
            array2[maxPlace2] = oldMinPlace2;

            foreach (int item in array2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
