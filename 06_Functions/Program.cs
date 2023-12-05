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
            ns1 = "ümit karaçivi";
            ns1_1=ns1.ToUpper();
            ns2 = "DOĞA BENGİ KARAÇİVİ";
            ns2_1=ns2.ToLower();

            Console.WriteLine(ns1 + " " + ns1_1 + "\n");
            Console.WriteLine(ns2 + " " + ns2_1 + "\n");

            // Concat : stringleri birleştiriyor.


            Console.WriteLine("Benim ve kızımın adları : " + string.Concat(ns1_1," - ",ns2," İstanbul'da yasıyoruz..Sağlıklıyız....Paraya para demiyoruz...."));

            // Substring

            string substr;
            string sonuc,sonuc1;

            substr = "This is a test string...";
            sonuc=substr.Substring(8, 8); // belli bir aralık
            sonuc1=substr.Substring(9); // den itibaren sonuna kadar


            Console.WriteLine(substr + " - " + sonuc + " - " + sonuc1);

            // Insert (baslangic,value)
            string adsoyad = "Ümit KARAÇİVİ";
            string lakap = "scrat ";

            Console.WriteLine(adsoyad.Insert(5,lakap)+ "\n\n");

            // Remove (baslangic,value)
            string adsoyad1 = "Ümit KARAÇİVİ";

            Console.WriteLine(adsoyad.Remove(3,5) + "\n\n");

            Console.ReadKey();
        }
    }
}
