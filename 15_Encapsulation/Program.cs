internal class Program
{
    // Bir nesnenin bazı çzellik ve işlevlerini diğer sınıflardan ve nesnelerden saklama yöntemi.
    // kullanılan private erişim belirleyici ile bu değerler saklamış olur.
    // getter ve setter yontemleri kullanılarak değerleri güncellenebilir veya okunabilir.

    // bçylelikle nesneler bazı bilinnçsızce kullanımdan korunmuş olur.
    // fakat bazı durumlarda bu saklı değerler ulasmak gerekebılır. get set ile kullanılarak ulasım sağlanır.


    // Ornek..
    // dikdortgen alanı hesaplanack. ama kapsulleme yontemı kullanılarak

    // Ornek 2: Bir ulke ısımlı sınıf yaratınız.Elemanları ulkenin adı,baskenti,para birimi,kdan atmasyon nufusu olsun.bu sınıftaki bir metot Yazdır ısımlı mesela yazdırın...)Odev

    // Ornek 3: Machine isimlı bır sınıf yaratın. Bu sınıfın Temp adlı bir ozelliği olsun.ekrandan gırılen machine adı ve Temp değerine gore Sınıfımız Temp değerının 0 dan kucuk ve 0 dan buyuk olmasına gore bir hata mesajı versın...Şu makina cok ısınıyor veya makına durdu gıbı

    private static void Main(string[] args)
    {
        Dortgen dortgen = new Dortgen();

        dortgen.UK = 15;
        dortgen.KK = 10;

        Console.WriteLine("Dortgenın alanı : " + dortgen.AlanHesapla() + "\n\n");




        Console.ReadKey();
    }

    public class Dortgen
    {
        private int _kk;
        private int _uk;

        // getter-setter
        public int KK // Kullanılacak olan KK değişgeninin değerlerinin ayarlanması
        {
            get { return _kk; } // _kk içinde ne değer varsa getir...
            set
            {
                if (value < 0 )
                {
                    _kk=0;
                }
                else
                {
                    _kk=value; // value ..reserved keyword...içinde bir değer tutuyor..
                }
            }
        }

        public int UK
        {
            get { return _uk; } // _uk içinde ne değer varsa getir...
            set
            {
                if (value < 0)
                {
                    _uk = 0;
                }
                else
                {
                    _uk = value; // value ..reserved keyword...içinde bir değer tutuyor..
                }
            }
        }

        public int AlanHesapla()
        {
            return _kk * _uk; 
            //return prmkk * prmuk;
        }

    }

}