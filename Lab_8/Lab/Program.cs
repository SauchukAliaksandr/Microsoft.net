using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_6
{
    class Program
    {
        delegate bool IsEqual(int x);
        static void Main(string[] args)
        {


            int[] array = { 4, 5, 23, 4, 2321, 43 };
            int result = func(array, x => x == 5);
            if (result == 1)
            {
                Console.Write("èìååòñÿ");
            }
            else
            {
                Console.Write("íå èìååòñÿ");
            }
            Console.ReadLine();
        }
        private static int func(int[] numbers, IsEqual func)
        {
            foreach (int i in numbers)
            {
                if (func(i))
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}

