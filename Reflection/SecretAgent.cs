using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class SecretAgent
    {
        private string _codename = "007";

        public void DisplayCodename()
        {
            Console.WriteLine($"The secret agent's codename is: {_codename}");
        }

        public void DisplayCodeNameFormat2()
        {
            Console.WriteLine($"The secret agent in disguise's codename is: {_codename}");
        }
    }
}
