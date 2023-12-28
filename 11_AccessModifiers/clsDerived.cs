using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_AccessModifiers
{
    internal class clsDerived : clsBase // Kalıtım clsDerived <- clsBase
    {
        public void AccessProtectedMethod()
        {
            // Miras alınan(Kalıtıldığı yerden) sınıftaki prot.metoda ulasım.
            ProtectedMethod();
        }
    }
}
