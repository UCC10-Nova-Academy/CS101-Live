using System.Threading.Channels;

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
        // Kalıtım olayı genel olarak 4 çesit diyebiliriz.

        // 1.Single
        // 2.MultiLevel
        // 3.Hierarchical
        // 4.Multiple (Interface yöntemiyle)


        #region Sample1
        // bir Person isimli bir üst sınıfımız olsun.Ve bundan 3 adet Employee,Student,Customer alt sınıf olusturalım

        //Employee employee = new Employee(); // employee nesnem yaratıldı.

        //employee.Id = 1;
        //employee.FName = "Ümit";
        //employee.LName = "Karaçivi";
        //employee.CompanyName = "Oyak Renault";

        //string FullName=employee.getFullInfo();

        //Console.WriteLine($"Personel Bilgisi : \n\nPersonel No : {employee.Id}\nPersonel Ad Soyad : {FullName}\nÇalıştığı şirket : {employee.CompanyName}");

        Dog dog = new Dog(); // yaaratılırken animal çzelliklerini de üzerine kopyaladı
        
        dog.Eat(); // super clss içindeki metodu kullanabiliyorum
        dog.HavHav(); // kendi içindeki metodu kullanabiiyorıum.

        // Multiple
        Horse horse = new Horse();
        horse.Eat(); // Animal classından geldi
        horse.Gallop(); // kendi üzerinde
        horse.Run(); // memeli sınıfından geldi.

        Eagle eagle = new Eagle();
        Penguin penguin = new Penguin();

        eagle.Eat();
        eagle.Hunt();

        penguin.Eat();
        penguin.Fly();
        penguin.Swim();
        #endregion

        #region Another sample
        //icinde Ad,soyad,cinsiyet,yas gibi özelliklerin bulunduğu Human isimli bir super class yaratınız.
        // ardından yıne bır sırket calısanı orneğı gibi içinde çalıstığı bolum ve maas bilgilerinin olduğu Employee isimli bir alt sınıf olusturunuz.
        // manuel olarak ilgili propertylere değerler atayıp yine bunları ekranda gösterecek sekilde sınıfları yaratınız ve kullanınız.
        // eğer manuel yerine ekrandan bilgi alacak skilde yaparsanız dadından yenmez.


        #endregion

        Console.ReadKey();
    }

    #region 1.Single Inheritance
    // Super Class
    class Person
    {
        public string FName { get; set; } // First Name property(alan)
        public string LName { get; set; } // Last Name

        // super class içindeki bir metot
        public string getFullInfo()
        {
            return FName + " " + LName;
        }

    }


    // Sub Class
    class Employee : Person // Kendini Person sıfından kalıttı/miras aldım
    {
        public int Id { get; set; }

        public string CompanyName { get; set; }

        
    }

    class Dog : Animal
    {
        public void HavHav()
        {
            Console.WriteLine("Köpekler havlar....\n\n");
        }
    }

    class Cat : Animal
    {
        public void MiyavMiyav()
        {
            Console.WriteLine("Kediler de doyndum emeeen derler..\n\n");
        }
    }



    #endregion

    #region 2.Multilevel Inheritance

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Hayvanlar yerler....\n\n");
        }

    }

    class Mammal : Animal
    {
        public void Run()
        {
            Console.WriteLine("Memeli hayvanlar koşarlar....\n\n");
        }
    }

    class Horse : Mammal
    {
        public void Gallop()
        {
            Console.WriteLine("Atlar tırıs tırıs giderler..\n\n");
        }
    }


    #endregion

    #region 3.Hierarchical Inheritance

    class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine("Kuşlar uçarlar....\n\n");
        }
    }

    class Eagle : Bird
    {
        public void Hunt()
        {
            Console.WriteLine("Kartallar yüksek uçar..Avlanır..\n\n");
        }
    }

    class Penguin: Bird
    {
        public void Swim()
        {
            Console.WriteLine("Penguenler yüzebilir...\n\n");
        }
    }



    #endregion

    #region 4.Multiple Inheritance

    #endregion


}