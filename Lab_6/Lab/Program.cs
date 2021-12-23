using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввведите координату x для первой точки ");
            double x0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ввведите координату y для первой точки ");
            double y0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ввведите координату x для второй точки ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ввведите координату y для второй точки ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ввведите координату x для третей точки ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ввведите координату y для третей точки ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double XO = (x0 + x2) / 2;
            double YO = (y0 + y2) / 2;
            double x3 = (2 * XO) - x1;
            double y3 = (2 * YO) - y1;
            Console.Write("Координаты четвертой точки (" + x3 + "," + y3 + ")");
        }
    }
}