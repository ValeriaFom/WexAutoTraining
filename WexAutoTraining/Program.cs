using System;

namespace Homework1_Min_MaxValues
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework 1
            //Вывести в консоль максимальные и минимальные допустимые значения для типов данных byte, short, int, long, float, double, uint, ulong.

            Console.WriteLine($"Min and Max values for byte = {byte.MinValue} {byte.MaxValue}");
            Console.WriteLine($"Min and Max values for short = {short.MinValue} {short.MaxValue}");
            Console.WriteLine($"Min and Max values for int = {int.MinValue} {int.MaxValue}");
            Console.WriteLine($"Min and Max values for uint = {uint.MinValue} {uint.MaxValue}");
            Console.WriteLine($"Min and Max values for long = {long.MinValue} {long.MaxValue}");
            Console.WriteLine($"Min and Max values for ulong = {ulong.MinValue} {ulong.MaxValue}");
            Console.WriteLine($"Min and Max values for float = {float.MinValue} {float.MaxValue}");
            Console.WriteLine($"Min and Max values for double = {double.MinValue} {double.MaxValue}");            
        }
    }
}
