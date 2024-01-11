internal class Program
{
    // Constructors (Yapıcı-inşa edici metotlar)

    // bir constructor sınıftan bir nesne yaratıldığında baslangıç durumları ayarlamak için kullanılır.
    // Bazı kurallar
    // - sınıf ısmıyle aynı olmalıdır.
    // - birden fazla tanımlanabılırler ...Farklı parametrik tanımlamalarla...
    // - bu metodun herhangi bir geri donuş tipi yoktur...baslar...biter...
    // - public,private ve protected modda kullanılabilir.
    // 


    private static void Main(string[] args)
    {
        // sınıftan bir ornek/nesne/instance yaratıyoruz...

        Araba araba= new Araba(); // nesne yaratıldı

        Araba araba1 = new Araba("Renault Alpine A4");

        Araba araba2 = new Araba("Peugeot 508","2023");


        Araba araba3 = new Araba("Mersedes");

        Araba araba4 = new Araba("Peugeot 508", "2023");




        Console.ReadKey();
    }

    public class Araba
    {
        // sadece bu sınıfın içinde kullanılacak değişgenler
        string _adi;
        string _modelyili;
        int _renk;
        string _motor;

        // araba sınıfından bir ornek/nesne yaratılmak istendiğinde ilk once burası devreye gırecek.
        public Araba()
        {
            // ilk nesne yaratımında buraya duşmesşnş istiyorum.
            Console.WriteLine("Araba sınıfının constructor metodu çalıştı...\n\n");
        }

        // Parametrik olarak farklı yapılardaki constructorlar
        public Araba(string adi) // parametrik bir constr.
        {
            this._adi = adi; // kendi üzerimdeki değişgene parametreden gelen deüeri yüklüyorum...ve bişseler
            Console.WriteLine("Arabanın adı : " + this._adi + "\n\n" );


        }

        public Araba( string adi, string modelyili) 
        { 
            this._adi=adi;
            this._modelyili=modelyili;

            Console.WriteLine("Arabanın adı : " + this._adi + "\nArabanın modeli " + this._modelyili);

        }

        public Araba(int renk,string motor)
        {
            this._renk=renk;
            this._motor=motor;

            Console.WriteLine("Arabanın renk : " + this._renk + "\nArabanın modeli " + this._motor);
        }

    }
}