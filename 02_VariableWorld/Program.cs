internal class Program
{

    private static void Main(string[] args) // Burasi programin ilk giriş noktası Main Metodu....
    {
        // Ilk tanımlamalar yapılıyor..

        #region İlk ornek

        // string bir degisgen tanımlayalım

        //string name = ""; // bellekte string veri tipinde bir name isimli ve şu an içinde bosluk değeri olan bir degisgen yarattım 

        //string nameDesc="Ad bilgisi ";

        //string NameDesc;

        //string Name="Doga Bengi";

        //string Description;

        //// Değer atama

        //name = "Ümit KARACIVI";

        //nameDesc = "Benim adım : ";
        //nameDesc = "Senin adın : ";

        //NameDesc = "Kızımın adı : ";

        //// Şimdi bunları ekrana yazdıralım

        //Console.WriteLine(name);
        //Console.WriteLine(nameDesc + name +"\n\n\n\n"); // Dinamik yazdırma

        //Console.WriteLine("  4 satır atladım..."); // Bos satır...
        //Console.WriteLine("");

        #endregion

        #region değisgenlere devam

        // tamsayı ve içindeki değeri 100 olan "sayi" adında bir değişgen tanımlayınız.

        int sayi = 100;

        const string programAd = "Personel Takip Programı v1.0"; // programın basından sonuna değeri hiç değişmeyecek

        //programAd = "xxx"; //hata durumu

        // satırsal gosterim
        int a;
        int b;
        int c;

        var a1 = 5;

        char karakter = 'a';

        bool dogrumu;


        dogrumu= false;
        Console.WriteLine("ilk değer : " + dogrumu);


        dogrumu = !dogrumu; // ! not
        Console.WriteLine("Şimdiki deger " + dogrumu); ;

        bool sonuc = 5 < 4;

        Console.WriteLine("\n\nSonuc =" + sonuc); ;

        int d=5, e=10, f=50; // tek

        a = 5;
        b=6; c=7; d = 8;

        string eyup = "8",mehmet="16";


        Console.WriteLine("d nin değeri = " + d);

        Console.WriteLine("e nin değeri = " + e);

        Console.WriteLine("f nin değeri = " + f);

        int toplam = a + b + c + d + e + f;


        Console.WriteLine("Değerlerin toplamı = " + toplam +"\n\n");

        Console.WriteLine(eyup+ "\t" + mehmet  ); // karakter olarak yanyana getirme
        #endregion

        //sık yapılan hatalar
        //int n;
        //n = "ali";


        // bazı veri tipleri için değer atarken bazı karakterler kullanmak gerekiyor

        float xx = 12.5f;

        string ff;
        
        // LIFO , FIFO



        Console.ReadKey(); // programı durdurmak ve bir tuşa basılmasını beklıyor.









    }
}