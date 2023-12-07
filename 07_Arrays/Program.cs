﻿namespace _07_Arrays
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

            // Şöyle de olabilir
            string[] dizi1 = { "Bir", "İki", "Üç" }; // daha yaratırken içine veriyi yerleştiriyorum.
            int[] dizi2 = {2,-4,5,6};

            float[] dizi3 = { 2f, 2.5f, 4.1f };

            #endregion

            Console.ReadKey();
        }
    }
}
