using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class StringProcessor : IProcessor<string>
    {
        public void Process(string data)
        {
            data.ToUpper();

            Console.WriteLine(data);
        }
    }
}
