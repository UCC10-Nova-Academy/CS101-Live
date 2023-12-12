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
            Console.WriteLine("Kısa Kenar :");
            int kk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Uzun Kenar :");
            int uk = Convert.ToInt32(Console.ReadLine());

            Hesapla2(uk, kk);// ekrandan aldığım değerrleri metoda gecmiş oldum
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
    }
}
