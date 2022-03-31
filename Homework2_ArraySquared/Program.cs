using System;

namespace Homework2_ArraySquared
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework 2
            //Создать массив размером 10 элементов, заполнить его квадратами индексов (в цикле), и вывести его содержимое на экран

            int[] squared = new int[10];

            for (int index = 0; index < squared.Length; index++)
            {
                squared[index] = index * index;
                Console.WriteLine(index + " element = " + squared[index]);
            }
        }
    }
}
