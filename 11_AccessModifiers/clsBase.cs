using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_AccessModifiers
{
    internal class clsBase
    {
        string AdSoyad = "Ümit Karaçivi";

        protected void ProtectedMethod()
        {
            Console.WriteLine("Burası sadece kendi sınıfında kullanılabilir\n"  );
            Console.WriteLine(AdSoyad);
        }

    }
}
