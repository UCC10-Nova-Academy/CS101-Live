namespace _07_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dizi tanımlama,değer atama ve kullanma

            //// 20 elemanlı int değerler tutan "sayilar" isimli bir dizi tanımlama
            //int[] sayilar = new int[20]; // tüm içerik 0

            //// 5.index indeki elemanına 5 değeri koy

            //sayilar[5] = 5;

            //Console.WriteLine("5. indexdeki değer = {0}", sayilar[5]);

            //// Şöyle de olabilir
            //string[] dizi1 = { "Bir", "İki", "Üç" }; // daha yaratırken içine veriyi yerleştiriyorum.
            //int[] dizi2 = {2,-4,5,6};

            //float[] dizi3 = { 2f, 2.5f, 4.1f }; // yaratırken ilk değerleri atama

            ////Not : yukardaki kullanımı ancak ve ancak dizi daha ilk tanımlanırken yapabilir. Sonrasında bçyle bir atama yapamayız.

            ////int[] dizi4;

            ////dizi4 = { 1,2,3};

            //// Dinamik dizi yaratımı
            //Console.WriteLine("Lütfen bir değer giriniz :");
            //int boyut = Convert.ToInt32(Console.ReadLine());// yaratılacak olan dizinin boyutu isteniyor aslında
            //int[] dizi5 = new int[boyut]; // dinamik bir dizi yaratımı
            //dizi5[0] = 130;
            //dizi5[1] = 20;
            //dizi5[2] = 40;

            //// bu dizinin tüm elemanlarını ekrana bastırınız.

            //for (int index = 0;index <= dizi5.Length-1; index++)
            //{
            //    Console.WriteLine("Dizinin {0}. elemanı {1} dir...",index, dizi5[index] );
            //}
            #endregion

            #region for/foreach döngüleri
            // Bir tamsayı dizimin tüm elemanlarını toplayan durum

            int[] sayilar1 = { 1, 2, 3,4,5,6,7,8,9,10 };

            // toplamı isteniyor
            int toplam = 0;

            for (int index = 0;index <= sayilar1.Length-1; index++)
            {
                toplam = toplam + sayilar1[index];
            }

            Console.WriteLine("Dizi1 toplamı {0} \n\n",toplam);


            // foreach
            int[] sayilar2 = { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };


            // toplamı isteniyor
            int toplam1 = 0;

            foreach (int value in sayilar2)
            {
                toplam1 += value; // toplam1 = toplam1 + value
            }

            Console.WriteLine("Dizi2 toplamı {0} ", toplam1);

            #endregion

            Console.ReadKey();
        }
    }
}
