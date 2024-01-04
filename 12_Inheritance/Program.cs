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




        #endregion





        Console.ReadKey();
    }

    // Super Class
    class Person
    {
        public string FName { get; set; } // First Name property(alan)
        public string LName { get; set; } // Last Name

        public string getFullName()
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