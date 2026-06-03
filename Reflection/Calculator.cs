using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class Calculator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"Addition: {a} + {b} = {a + b}");
        }

        public static void GetPi()
        {
            Console.WriteLine("3.14159");
        }
    }
}
