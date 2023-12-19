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

            Console.WriteLine("Alan= {0}", HesaplaPrmsiz());

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
    }
}
