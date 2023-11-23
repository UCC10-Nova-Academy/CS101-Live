internal class Program
{
    private static void Main(string[] args)
    {
        // Bilinçsiz tür donusumleri
        byte a = 10;// max 0-255 arasında değer alır

        short b = 20;

        sbyte c = 30;

        int d = a + b + c;

        string e= "Nova Academy Team";

        char f = 'A';

        object g = e + " " + f + " " + d; // farklı farklı veri tiplerini object veri tipi kapsıyor.

        long h = d;

        float i = h;

        double j = i;

        double k = 21.5;

        object l = h + k;

        Console.WriteLine("1.Durum : " + d.ToString());
        Console.WriteLine("2.Durum : " + g.ToString());
        Console.WriteLine("3.Durum : " + l.ToString());


        Console.ReadKey();

    }
}