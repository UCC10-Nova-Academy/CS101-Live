namespace _09_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir dikdortgenin alanı hesaplanacak


            #region 1.Geriye deger dondurmeyen ve herhangi bir parametre almayan metotlar)Yalnız calısan..

            //Hesapla();


            #endregion

            #region 2. Geriye değer döndurmeyen ama parametre alan
            //Console.WriteLine("Kısa Kenar :");
            //int kk = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Uzun Kenar :");
            //int uk = Convert.ToInt32(Console.ReadLine());

            //Hesapla2(uk, kk);// ekrandan aldığım değerrleri metoda gecmiş oldum
            #endregion

            #region 3. Geriye değer döndüren ama herhangi bir parametre almayan

            //int sonuc = HesaplaPrmsiz(); // sonuc=alan

            //Console.WriteLine("Alan= {0}", HesaplaPrmsiz());
            //Console.WriteLine("Geri dönen bilgi = {0}", HesaplaPrmsiz2());


            #endregion

            #region 4. Geriye değer dondurecek ve parametre alacak

            Console.WriteLine("Kısa Kenar :");
            int kk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Uzun Kenar :");
            int uk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Alan= {0}", HesaplaPrmli(kk, uk));
            #endregion

            #region Sınıf içi WO
            // ekrandan kullanıcıdan 2 adet sayı girmesi istenecek...
            // sonra dört işlemden hangisini yapmak istediği istenecek.Burada kullanıcı +,-,*,/ karakterlerinden birini girecek
            // Parametreli ve geriye değer donduren bir metot/fonksiyon yazınız ve sonucu ekranda gösteriniz...

            #endregion


            Console.ReadKey();
        }


        // Benim yazdıgım Metotlar
        static void Hesapla()
        {
            Console.WriteLine("Kısa Kenar :");
            int kk=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Uzun Kenar :");
            int uk = Convert.ToInt32(Console.ReadLine());

            int alan = kk * uk;

            Console.WriteLine("Dikdortgenin alanı {0} dır",alan  );
        }

        static void Hesapla2(int kisak,int uzunk)
        {
            int alan = kisak * uzunk;

            Console.WriteLine("Dikdortgenin alanı {0} dır", alan);
        }

        // Burası benim metodum ve yaptığım işlem sonucu oluşan değeri tamsayı türünde çağrıldığım yere geri postalayacağım
        static int HesaplaPrmsiz() 
        {
            Console.WriteLine("Kısa Kenar :");
            int kk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Uzun Kenar :");
            int uk = Convert.ToInt32(Console.ReadLine());

            int alan = kk * uk;

            return alan; // geri değeri postalayan keyword
        }

        static string HesaplaPrmsiz2()
        {
            Console.WriteLine("Ad :");
            string ad = Console.ReadLine();

            Console.WriteLine("Soyad :");
            string soyad = Console.ReadLine();

            return string.Concat(ad," ",soyad);
        }
        
        static int HesaplaPrmli(int kkenar,int ukenar)
        {

            return kkenar * ukenar;
        }

    }
}
