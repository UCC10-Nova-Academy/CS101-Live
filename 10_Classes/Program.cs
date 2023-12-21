namespace _10_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Sınıflar nerelerde oluşturulabılır.

            // bulunulan namespace içinde
            // baska bir namespace içinde/yani bulunulan ns nin dışında)
            // herhangi bir class içinde de yaratılabilir.


            #endregion

            #region Personel 

            // bir personel kayıt sistemi oluşturulacak
            // yani class tanımlamamı ayrı bir dosyada (cs) yaratacağım.

            // şimdi yaratmıs oldumuz class dan nesne olusturma zmanı..yani kullanma zamanı

            // class dan nesne yaratma syntax bellekte yer ayırma

            clsPersonel umit = new clsPersonel(); // bellekte umit nesnesi yaratıldı
            clsPersonel arda1 = new clsPersonel();
            clsPersonel eyup = new clsPersonel();
            clsPersonel arda2 = new clsPersonel();
            clsPersonel alihan = new clsPersonel();
            clsPersonel emircan = new clsPersonel();

            // bilgileri oluşturma
            int maasilk = 9000;
            int maasson = 20000;

            // nesnenin metotlarını kullanma
            umit.setPersonelBilgileri("Ümit","KARAÇİVİ",new Random().Next(maasilk, maasson));
            arda1.setPersonelBilgileri("Arda","ÖNDER",new Random().Next(maasilk, maasson));
            eyup.setPersonelBilgileri("Eyüp","SULTAN",new Random().Next(maasilk, maasson));
            arda2.setPersonelBilgileri("Arda","YILDIZ",new Random().Next(maasilk, maasson));
            alihan.setPersonelBilgileri("Alihan","BAHRATOV",new Random().Next(maasilk, maasson));
            emircan.setPersonelBilgileri("Emircan","KARAKUŞ",new Random().Next(maasilk, maasson));

            Console.WriteLine(umit.getPersonelBilgileri());
            Console.WriteLine(arda1.getPersonelBilgileri());
            Console.WriteLine(eyup.getPersonelBilgileri());
            Console.WriteLine(arda2.getPersonelBilgileri());
            Console.WriteLine(alihan.getPersonelBilgileri());
            Console.WriteLine(emircan.getPersonelBilgileri());

            #endregion

            Console.ReadKey();
        }
    }
}
