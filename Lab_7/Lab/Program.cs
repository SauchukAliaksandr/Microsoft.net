using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Func<Action<float>, int, float, bool> function = Function;
            Action<float> action = Action;

            Console.WriteLine(function(action, 6, 6.6f));
            Console.ReadLine();
        }
        static void Action(float m)
        {
            Console.WriteLine(m);
        }

        static bool Function(Action<float> action, int first, float second)
        {
            float res = first + second;
            action(res);
            return res >= 0;
        }
    }
}