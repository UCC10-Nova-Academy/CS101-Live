namespace _08_ErrorControls
{
    internal class Program
    {
        // Programımızda çeşitli hatalarla karsılasabiiriz. Bunları yakalayabiliriz veya neler olduğunu görebiliriz.
        static void Main(string[] args)
        {
            #region Hata verebilecek bir durum
            //int a = 100;
            //int b = 0; // olura burası bı sekılde 0 oldu..

            //Console.WriteLine("{0} / {1} isleminin sonucu : {2}",a,b,a/b);


            #endregion

            // istenmeyen hata durumunun önüne geçmek için

            #region Hata Avcısı )onceden hatayı olabıleceğini hissetmek
            int c = 200;
            int d = 0;

            try // dene -- olmuosa catch bolumune git
            {
                Console.WriteLine("{0} / {1} isleminin sonucu : {2}", c, d, c / d);
            }
            catch  // olmuosa hata ver patdadanak değil usturuplu
            {// tamamen size kalmış
                if (c != 0 && d==0)
                {
                    d = (c / 10); // d ye yeni bir deüer ata

                    Console.WriteLine("D nin değeri hata oluşturduğu için güncellenmiş ve {0} değeri atanmıştır.\n Şimdi {1} / {2} işleminin sonucu {3} tür.",d,c,d,(c/d));
                }
                else if (c == 0 && d !=0)
                {
                    c = (d * 10);

                    Console.WriteLine("C nin değeri 0 olduğu için güncellenmiş ve {0} değeri atanmıştır.\n Şimdi {1} / {2} işleminin sonucu {3} tür.", c, c, d, (c / d));
                }
                else if (c == 0 && d == 0)
                {
                    c = 50;
                    d = 10;

                    Console.WriteLine("Şimdi {0} / {1} işleminin sonucu {2} tür.", c, d, (c / d));
                }
            }



            #endregion




            Console.ReadKey();
        }
    }
}
