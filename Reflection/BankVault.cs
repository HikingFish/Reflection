using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class BankVault
    {
        private string _secretCode = "SuperSecret123";
        private void RevealSecret()
        {
            Console.WriteLine($"The secret code is: {_secretCode}");
        }
    }
}
