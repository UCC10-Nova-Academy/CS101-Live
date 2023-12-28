using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_AccessModifiers
{
    internal class clsProtected
    {
        protected string Name = "ÜK";

        protected void Message(string message)
        {
            Console.WriteLine("Merhaba " + message);
        }
    }
}
