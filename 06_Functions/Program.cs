namespace _06_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Metinsel Fonksiyonlar/Metotlar

            string ns1,ns1_1;
            string ns2,ns2_1;

            // ToUpper,ToLower
            ns1 = "ümit karaçivi...";
            ns1_1=ns1.ToLower();
            ns2 = "DOĞA BENGİ KARAÇİVİ";
            ns2_1=ns2.ToLower();

            Console.WriteLine(ns1 + " " +ns1_1 + "\n");
            Console.WriteLine(ns2 + " " + ns2_1 + "\n");

            // concat : stringleri birleitiriyor.


            Console.WriteLine("Benim ve kızımın adları : " +);


            Console.ReadKey();
        }
    }
}
