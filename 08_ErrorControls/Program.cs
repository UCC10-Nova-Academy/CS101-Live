﻿namespace _08_ErrorControls
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
            int c = 0;
            int d = 100;
            int sonuc;

            try // dene -- olmuosa catch bolumune git
            {
                sonuc = c / d;
                Console.WriteLine("{0} / {1} isleminin sonucu : {2}", c, d, sonuc);
            }
            catch  // olmuosa hata ver patdadanak değil usturuplu
            {// tamamen size kalmış
                if (c != 0 && d==0)
                {
                    d = (c / 10); // d ye yeni bir deüer ata
                    sonuc = c / d;
                    Console.WriteLine("D nin değeri hata oluşturduğu için güncellenmiş ve {0} değeri atanmıştır.\n Şimdi {1} / {2} işleminin sonucu {3} tür.",d,c,d,sonuc);
                }
                else if (c == 0 && d !=0)
                {
                    c = (d * 10);

                    Console.WriteLine("C nin değeri 0 olduğu için güncellenmiş ve {0} değeri atanmıştır.\n Şimdi {1} / {2} işleminin sonucu {3} tür.", c, c, d, sonuc);
                }
                else if (c == 0 && d == 0)
                {
                    c = 50;
                    d = 10;
                    sonuc= c / d;

                    Console.WriteLine("Şimdi {0} / {1} işleminin sonucu {2} tür.", c, d, sonuc);
                }
            }



            #endregion




            Console.ReadKey();
        }
    }
}
