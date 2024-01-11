using System.Globalization;

internal class Program
{
    // Çokbiçimlilik - Polymorhism

    // Bir nesne yapısının birbirinden sanki farklı şekillerde kullanılabilmesi
    // esneklik,yer kazancı,performans,kodlama hızlılığı



    private static void Main(string[] args)
    {
        //Animal animal1 = new Animal(); // nesne yaratıldı.

        //animal1.name = "Tiger";
        //animal1.info = "Kaplan";
        //animal1.sound = "Roarrr";

        //Console.WriteLine(animal1.name);
        //Console.WriteLine(animal1.sound);
        //Console.WriteLine(animal1.info+"\n\n");

        //Animal animal2 = new Animal();

        //animal2.name = "Lion";
        //animal2.info = "Aslan";
        //animal2.sound = "Woof";

        ////Console.WriteLine(animal.name);
        //Console.WriteLine(animal2.name);
        //Console.WriteLine(animal2.sound);
        //Console.WriteLine(animal2.info);

        // Polymorp
        Animal animal3 = new Animal("Eagle");

        Console.WriteLine(animal3.name);
        Console.WriteLine(animal3.sound);
        Console.WriteLine(animal3.info + "\n\n");

        Animal animal4 = new Animal("Penguin", "vırık vırık");

        Console.WriteLine(animal4.name);
        Console.WriteLine(animal4.sound);
        Console.WriteLine(animal4.info + "\n\n");

        Animal animal5 = new Animal("Cat", "miyav miyav","bu bir kedidir");
        Console.WriteLine(animal5.name);
        Console.WriteLine(animal5.sound);
        Console.WriteLine(animal5.info + "\n\n");

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