using System;

namespace Homework3_3ArraysWithAverages
{
    class Program
    {
        static void CreateArray(int[] array, int degree)
        {
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = (int)Math.Pow(index, degree);  // возведение в степень           
            }
        }

        static float GetAverage(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i]; // sum = sum + array[i]
            }
            return ((float)sum / array.Length);
        }

        static void Main(string[] args)
        {
            //Homework 3
            //Cоздать три массива по 10 элементов,
            //первый заполнить значениями индексов элементов, второй - квадратами индексов, третий-кубами,
            //и вывести на экран средние значения элементов для всех массивов

            //int[] indexes = new int[10];
            //CreateArray(indexes, 1);

            //foreach (int item in indexes)
            //{
            //    Console.WriteLine("Element = " + item);
            //}
            //Console.WriteLine("Average = " + GetAverage(indexes) + "\n");

            //int[] squared = new int[10];
            //CreateArray(squared, 2);

            //foreach (int item in squared)
            //{
            //    Console.WriteLine("Element = " + item);
            //}
            //Console.WriteLine("Average = " + GetAverage(squared) + "\n");

            //int[] cubed = new int[10];
            //CreateArray(cubed, 3);

            //for (int index = 0; index < cubed.Length; index++)
            //{
            //    Console.WriteLine(index + " element = " + cubed[index]);
            //}
            //Console.WriteLine("Average = " + GetAverage(cubed) + "\n");

            int[] marks = new int[10];
            for (int i = 1; i <= 3; i++)
            {
                CreateArray(marks, i);
                for (int index = 0; index < marks.Length; index++)
                {
                    Console.WriteLine(index + " element = " + marks[index]);
                }
                Console.WriteLine("Average = " + GetAverage(marks) + "\n");
            }
        }
    }
}
