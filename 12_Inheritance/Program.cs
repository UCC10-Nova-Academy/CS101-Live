internal class Program
{
    // Inheritance - Kalıtım/Miras

    // OOP en önemli kısımlarından biri
    // Var olan, yaratılmış bir sınıftan bir diğer sınıfa tüm özelliklerin aktarımı
    // Bazı terminolojiler
    // SuperClass.. üst sınıf.çmetotlarını ve özelliklerini baska bir sınıfa miras bırakan aktaran sınıflar

    // SubClass .. alt sınıf..diğer bir sınıfın özelliklerini  alan sınıftır.

    private static void Main(string[] args)
    {
        // Kalıtım olayı genel olarak 5 çesit diyebiliriz.

        // 1.Single
        // 2.MultiLevel
        // 3.Hierarchical
        // 4.Multiple (Interface yöntemiyle)
        // 5.Hybrid(Interface yönt.)

        #region Sample1
        // bir Person isimli bir üst sınıfımız olsun.Ve bundan 3 adet Employee,Student,Customer alt sınıf olusturalım

        Employee employee = new Employee(); // employee nesnem yaratıldı.

        employee.Id = 1;
        employee.FName = "Ümit";
        employee.LName = "Karaçivi";
        employee.CompanyName = "Oyak Renault";

        string FullName=employee.getFullInfo();

        Console.WriteLine($"Personel Bilgisi : \n\nPersonel No : {employee.Id}\nPersonel Ad Soyad : {FullName}\nÇalıştığı şirket : {employee.CompanyName}");




        #endregion

        #region Another sample
        //icinde Ad,soyad,cinsiyet,yas gibi özelliklerin bulunduğu Human isimli bir super class yaratınız.
        // ardından yıne bır sırket calısanı orneğı gibi içinde çalıstığı bolum ve maas bilgilerinin olduğu Employee isimli bir alt sınıf olusturunuz.
        // manuel olarak ilgili propertylere değerler atayıp yine bunları ekranda gösterecek sekilde sınıfları yaratınız ve kullanınız.
        // eğer manuel yerine ekrandan bilgi alacak skilde yaparsanız dadından yenmez.


        #endregion

        Console.ReadKey();
    }

    // Super Class
    class Person
    {
        public string FName { get; set; } // First Name property(alan)
        public string LName { get; set; } // Last Name

        public string getFullInfo()
        {
            return FName + " " + LName;
        }

    }

    // Sub Class
    class Employee : Person // Kendini Person sıfından kalıttı
    {
        public int Id { get; set; }

        public string CompanyName { get; set; }

        
    }
}