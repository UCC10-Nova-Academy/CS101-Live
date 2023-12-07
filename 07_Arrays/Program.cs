namespace _07_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dizi tanımlama,değer atama ve kullanma

            // 20 elemanlı int değerler tutan "sayilar" isimli bir dizi tanımlama
            int[] sayilar = new int[20]; // tüm içerik 0

            // 5.index indeki elemanına 5 değeri koy

            sayilar[5] = 5;

            Console.WriteLine("5. indexdeki değer = {0}", sayilar[5]);




            #endregion

            Console.ReadKey();
        }
    }
}
