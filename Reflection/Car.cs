using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class Car
    {
        public string Make { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int Year;
        public void drive()
        {
            Console.WriteLine($"The {Make} {Model} is driving.");
        }
    }
}
