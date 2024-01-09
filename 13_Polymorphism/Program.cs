using System.Globalization;

internal class Program
{
    // Çokbiçimlilik - Polymorhism

    // Bir nesne yapısının birbirinden sanki farklı şekillerde kullanılabilmesi
    // esneklik,yer kazancı,performans,kodlama hızlılığı



    private static void Main(string[] args)
    {
        Animal animal = new Animal(); // nesne yaratıldı.

        animal.name = "Tiger";
        animal.info = "Kaplan";
        animal.sound = "Roarrr";

        Console.WriteLine(animal.name);
        Console.WriteLine(animal.sound);
        Console.WriteLine(animal.info+"\n\n");

        Animal animal2 = new Animal();

        animal.name = "Lion";
        animal2.info = "Aslan";
        animal2.sound = "Woof";

        //Console.WriteLine(animal.name);
        Console.WriteLine(animal2.name);
        Console.WriteLine(animal2.sound);
        Console.WriteLine(animal2.info);



        Console.ReadKey();
    }



    public class Animal
    {
        public string name, sound, info;

        // bir class yaratıldığında ilk olarak çalışacak bölüm - constructor(yapıcı metot)
        // sınıfımla aynı adlı
        // code snippet - ctor
        public Animal()
        {
            // benim yaratacağım nesnemin propertylerşnş şlk durumuna getirir.
            // yani class/nesne ilk yaratıldığında deüerleri ilk durumuna getir...
            this.name = "";
            this.sound = "";
            this.info = "";
        }

        public Animal(string name) // Metodumun 1.biçimi
        {
            this.name = name;
        }

        public Animal(string name, string sound) // Metodumun 2.biçimi
        {
            this.name = name;
            this.sound = sound;
        }

        public Animal(string name, string sound,string info) // Metodumun 3.biçimi
        {
            this.name = name;
            this.sound = sound;
            this.info = info;
        }

        public string getInfo()
        {
            return info;
        }
    }
}