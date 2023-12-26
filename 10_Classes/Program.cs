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

            //clsPersonel umit = new clsPersonel(); // bellekte umit nesnesi yaratıldı
            //clsPersonel arda1 = new clsPersonel();
            //clsPersonel eyup = new clsPersonel();
            //clsPersonel arda2 = new clsPersonel();
            //clsPersonel alihan = new clsPersonel();
            //clsPersonel emircan = new clsPersonel();

            //// bilgileri oluşturma
            //int maasilk = 9000;
            //int maasson = 20000;

            //// nesnenin metotlarını kullanma
            //umit.setPersonelBilgileri("Ümit","KARAÇİVİ",new Random().Next(maasilk, maasson));
            //arda1.setPersonelBilgileri("Arda","ÖNDER",new Random().Next(maasilk, maasson));
            //eyup.setPersonelBilgileri("Eyüp","SULTAN",new Random().Next(maasilk, maasson));
            //arda2.setPersonelBilgileri("Arda","YILDIZ",new Random().Next(maasilk, maasson));
            //alihan.setPersonelBilgileri("Alihan","BAHRATOV",new Random().Next(maasilk, maasson));
            //emircan.setPersonelBilgileri("Emircan","KARAKUŞ",new Random().Next(maasilk, maasson));

            //Console.WriteLine(umit.getPersonelBilgileri());
            //Console.WriteLine(arda1.getPersonelBilgileri());
            //Console.WriteLine(eyup.getPersonelBilgileri());
            //Console.WriteLine(arda2.getPersonelBilgileri());
            //Console.WriteLine(alihan.getPersonelBilgileri());
            //Console.WriteLine(emircan.getPersonelBilgileri());

            #endregion

            #region Ogrenci

            clsOgrenci ogr1 = new clsOgrenci();
            clsOgrenci ogr2 = new clsOgrenci();
            clsOgrenci ogr3 = new clsOgrenci();
            clsOgrenci ogr4 = new clsOgrenci();

            ogr1.setOgrData("Ogr1", "SOgr1");
            ogr2.setOgrData("Ogr2", "SOgr2");
            ogr3.setOgrData("Ogr3", "SOgr3");
            ogr4.setOgrData("Ogr4", "SOgr4");

            ogr1.getOgrData();
            ogr2.getOgrData();
            ogr3.getOgrData();
            ogr4.getOgrData();

            #endregion

            #region SınıfGeçme



            #endregion

            Console.ReadKey();
        }

        class clsOgrenci
        {
            public string OgrAd;
            public string OgrSoyad;


            public void setOgrData(string pOgrAd,string pOgrSoyad)
            {
                OgrAd = pOgrAd;
                OgrSoyad = pOgrSoyad;
            }

            public void getOgrData()
            {
                Console.WriteLine($"\n** Ogrenci Oluşturuldu **\n\nİsmi : {OgrAd}\nSoyadı : {OgrSoyad}\n");
            }
        }

        // Çalışma(26.12.23)
        // 1.Bir ogrenci sınıfı yaratalım - (inner)
        // içindeki properties lar
        // Ad , Soyadı,Sınıf,Ders,1.sınav Notu,2.sınav notu 
        // Bunları hard coded olarak verilerini yaratalım
        // 2. Hesap/Kitap : Ders geçme notu 60 (1.sınavın %40 ı,2.sınavın %60 ı etkili)
        // Hesaplayacak ve ekrana Öğrenci Adı,Soyadı,Ders adı,Not,Geçti/Kaldı olarak yazan metdu yazınız

        class clsOgrenci_New
        {

        }

        void GecmeNotHesapla()
        {

        }


    }
}
