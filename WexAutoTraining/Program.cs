using System;

namespace WexAutoTraining
{
    class Program
    {
        static void CreateArray(int[] array, int degree)
        { 
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = (int)Math.Pow(index, degree);               
            }
        }

        static float GetAverage(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i]; // sum = sum + array[i]
            }
            return (sum / array.Length);
        }

        static void Main(string[] args)
        {
            //Homework 1
            //Вывести в консоль максимальные и минимальные допустимые значения для типов данных byte, short, int, long, float, double, uint, ulong.

            //byte byteMin = byte.MinValue;
            //byte byteMax = byte.MaxValue;

            //Console.WriteLine("Min and Max values for byte = {0} {1}", byteMin, byteMax);

            //short shortMin = short.MinValue;
            //short shortMax = short.MaxValue;

            //Console.WriteLine("Min and Max values for short = {0} {1}", shortMin, shortMax);

            //int intMin = int.MinValue;
            //int intMax = int.MaxValue;

            //Console.WriteLine("Min and Max values for int = {0} {1}", intMin, intMax);

            ////long, float, double, uint, ulong.

            //uint uintMin = uint.MinValue;
            //uint uintMax = uint.MaxValue;

            //Console.WriteLine("Min and Max values for uint = {0} {1}", uintMin, uintMax);

            //long longMin = long.MinValue;
            //long longMax = long.MaxValue;

            //Console.WriteLine("Min and Max values for long = {0} {1}", longMin, longMax);

            //ulong ulongMin = ulong.MinValue;
            //ulong ulongMax = ulong.MaxValue;

            //Console.WriteLine("Min and Max values for ulong = {0} {1}", ulongMin, ulongMax);

            //float floatMin = float.MinValue;
            //float floatMax = float.MaxValue;

            //Console.WriteLine("Min and Max values for float = {0} {1}", floatMin, floatMax);

            //double doubleMin = double.MinValue;
            //double doubleMax = double.MaxValue;

            //Console.WriteLine("Min and Max values for double = {0} {1}", doubleMin, doubleMax);


            //Homework 2
            //Создать массив размером 10 элементов, заполнить его квадратами индексов (в цикле), и вывести его содержимое на экран

            //int[] squared = new int[10];

            //for (int index = 0; index < squared.Length; index++)
            //{
            //    squared[index] = index * index;
            //    Console.WriteLine(index + " element = " + squared[index]);
            //}

            //Homework 3
            //Cоздать три массива по 10 элементов, первый заполнить значениями индексов элементов, второй - квадратами индексов, третий-кубами, и вывести на экран средние значения элементов для всех массивов

            int[] indexes = new int[10];
            CreateArray(indexes, 1);
            foreach (int item in indexes)
            {
                Console.WriteLine("Element = " + item);
            }
            Console.WriteLine("Average = " + GetAverage(indexes));

            int[] squared = new int[10];
            CreateArray(squared, 2);
            foreach (int item in squared)
            {
                Console.WriteLine("Element = " + item);
            }
            Console.WriteLine("Average = " + GetAverage(squared));

            int[] cubed = new int[10];
            CreateArray(cubed, 3);
            foreach (int item in cubed)
            {
                Console.WriteLine("Element = " + item);
            }
            Console.WriteLine("Average = " + GetAverage(cubed));

            //Console.WriteLine(index + " element = " + array[index]);

            //int[] marks = new int[10];
            //for (int i = 1; i <= 3; i++)
            //{
            //    CreateArray(marks, 1);
            //    Console.WriteLine(GetAverage(marks));
            //}

        }
    }
}
