internal class Program
{
    private static void Main(string[] args)
    {
        #region 1.Matematiksel Operatorler

        // % operatoru (mod alma)

        //int a = 3854 % 8; // sonuc 1

        //Console.WriteLine("Mod sonucu 5 2 = " + a.ToString());

        #endregion

        #region 1.1 Değişik bir durum
        // Eğer işlem yapılan her iki operand farklı veri tipindeyse işlem sonucu daha büyük türde tutulur.

        //float b = 5 / 2f; // burada 5 sayısı da float gibi devranmıştır.ve sonuc ondalıklı cıkmıitır.


        //Console.WriteLine("1.1 - İşlem sonucu = " + b.ToString());

        #endregion

        #region 1.2 Ancak...durumu

        //float c = 100/25 / 5 / 2f;

        //Console.WriteLine("1.2 - İşlem sonucu = " + c.ToString());

        #endregion

        #region 1.3 Daha ilginci

        //float e = 2f / 5 / 2 / 8 / 2 / 4 / 9 / 5 / 3 / 12 / 7;
        //Console.WriteLine("1.3 - İşlem sonucu = " + e.ToString());

        #endregion


        #region 2. bir arttırma bir eksiltme operatörleri
        // en çok kullanılan
        // ++sayi, sayi++, --sayi,sayi--
        // sayi=sayi+1--
        // sayi+=5 -- sayi=sayi + 5;

        //int fonceki = 5;

        //int fsonraki = ++fonceki;//prefix ..hem fonceki değerini bir atırıyor..bu değeri tutuyor..fsonrak, değişgenine atıyor.

        //Console.WriteLine(  "Önceki değer : " + fonceki + "\nSonraki değer " + fsonraki);

        //int gonceki = 10;

        //int gsonraki = gonceki++; // suffix orneği.

        //Console.WriteLine("Önceki değer : " + gonceki + "\nSonraki değer " + gsonraki);

        #endregion

        #region ortaya karışık
        // int h = 5;

        // int i = h++;

        // int j = i--;

        // int k = 10;

        // int l = --k;

        //Console.WriteLine("h değeri - {0}\ni değeri - {1}\nj değeri - {2}\nk değeri - {3}\nl değeri - {4}",h,i,j,k,l);


        #endregion

        #region Karşılaştırma operatörleri
        // kü.ükl büyük 

        bool m = 4 < 6;

        bool n = 6 > 8;

        bool o = 7 <= 7;

        bool p = 9 >= 12;

        bool q = 10 == 12;

        bool r = 11 != 12;

        Console.WriteLine("m değeri - {0}\nn değeri - {1}\no değeri - {2}\np değeri - {3}\nqdeğeri - {4}\nr değeri - {5}",m,n,o,p,q,r);

        #endregion

        #region Mantıksal
        // ve, veya, değil (&& ,|| , !=)
        bool D = 35 > 10 && 10 == 50; // false
        bool H = !(5 < 4);

        Console.WriteLine(D);
        #endregion


        Console.ReadKey();


    }
}