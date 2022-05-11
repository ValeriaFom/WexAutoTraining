using System;

namespace Homework4_ChangeMaxMinValues
{
    class Program
    {
        static int[] FindMinValueAndPlaceInArray(int[] array)
        {
            int minPlace = 0;
            int minValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                    minPlace = i;
                }
            }
            return new int[] { minValue, minPlace };
        }

        static int[] FindMaxValueAndPlaceInArray(int[] array)
        {
            int maxValue = array[0];
            int maxPlace = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    maxPlace = i;
                }
            }
            return new int[] { maxValue, maxPlace };
        }

        static void SwapMinAndMaxValues(int[] array, int minPlace, int maxPlace)
        {
            (array[minPlace], array[maxPlace]) = (array[maxPlace], array[minPlace]);
        }

    static int[] CreateArrayWithRandomValues()
        {
            Console.WriteLine("Enter number for array length");
            string temp = Console.ReadLine(); 
            int length = Convert.ToInt16(temp);

            Random rnd = new Random();
            var array = new int[length];

            for (int index = 0; index < length; index++)
            {
                array[index] = rnd.Next(-100, 100);
            }
            return array;
        }

        static void Main(string[] args)
        {
            //Homework 4
            //1.Создать два произвольных массива, подсчитать максимальное  и минимальное значение их элементов. Вывести на экран.
            //2.Поменять в массивах максимальные и минимальные значения местами.

            for (int i = 1; i < 3; i++)
            {
                var array = CreateArrayWithRandomValues();

                foreach (int item in array)
                {
                    Console.WriteLine(item);
                }

                var minValueAndPlace = FindMinValueAndPlaceInArray(array);
                var maxValueAndPlace = FindMaxValueAndPlaceInArray(array);
                Console.WriteLine("Minimum value = {0}, Maximum value = {1}", minValueAndPlace[0], maxValueAndPlace[0] + "\n");

                SwapMinAndMaxValues(array, minValueAndPlace[1], maxValueAndPlace[1]);

                foreach (int item in array)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
