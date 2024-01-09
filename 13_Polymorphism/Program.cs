using System.Globalization;

internal class Program
{
    // Çokbiçimlilik - Polymorhism

    // Bir nesne yapısının birbirinden sanki farklı şekillerde kullanılabilmesi
    // esneklik,yer kazancı,performans,kodlama hızlılığı



    private static void Main(string[] args)
    {

        Console.WriteLine("Hello, World!");
    }

    public string getInfo()
    {
        return info;
    }

    public class Animal
    {
        public string name, sound, info;

        // bir class yaratıldığında ilk olarak çalışacak bölüm - constructor(yapıcı metot)
        // sınıfımla aynı adlı
        // code snippet - ctor
        public Animal()
        {
            // yani class/nesne ilk yaratıldığında deüerleri ilk durumuna getir...
            this.name = null;
            this.sound = null;
            this.info = null;
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
    }
}