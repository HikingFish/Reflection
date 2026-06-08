using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class Printer<T>
    {
        public void PrintValue(T item) => Console.WriteLine($"Value: {item}");
    }
}

