using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Classes
{        
    // Burası artık bir sınıf
        //bunun içine bazı tanımlamalar yapacagız...property(ozellık)...değisgen

        // 1. bir personelin kayıt yapısını ..kaydını oluşturmak için bir metot yaratabiliriz ve bunun içinde cesitli güncelleme ıslemlerinin olacağı bir yapı kurabiliriz.

    internal class clsPersonel
    {
        // değisgenlerimi tanımlıyorum
        // public ...dış dunyaya acık
        public int PersonelID; // Personel no
        public string Ad;
        public string Soyad;
        public string Unvan = null;
        public int Maas;
        public int IzinGunu;

        // 1.setter
        public void setPersonelBilgileri(string pAd,string pSoyad,int pMaas) // parametrik
        {
            // Kural 
            // eğer gelen maas bilgisi 10000 PNG Kina dan büyük ve esitse izin gunu 14   gun olsun
            // 10000 - 14000 dahil ise unvan kıdemli pers izin gunu 20
            // 14001 - 15500 dahil Kıdemli+ pers izin gunu 24 gun
            // 15501 butukse unvan uzman pers. ig 30 gün

            this.Ad = pAd;
            this.Soyad = pSoyad;
            this.Maas = pMaas;
            this.IzinGunu = 14;

            if ( pAd.Length > 0 && pSoyad.Length > 0)
            {
                if(pMaas >= 10000)
                {
                    if(pMaas >=10000 && pMaas <= 14000)
                    {
                        Unvan = "Kıdemli Personel";
                        IzinGunu = 20;
                    }
                    else if (pMaas >=14001 && pMaas <= 15500)
                        {
                        Unvan = "Kıdemli+ Personel";
                        IzinGunu = 24;
                    }
                    else if (pMaas > 15500)
                    {
                        Unvan = "Uzman Personel";
                        IzinGunu = 30;
                    }
                    else
                    {
                        Unvan = "Junior Personel";
                    }

                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n** Personel Olusturulamadı **");
            } 

        }

        // 2. getter
        public string getPersonelBilgileri()
        {
            if (Unvan != null)
            
                return $"\n** Personel Oluşturuldu **\n\nPersonel İsmi : {Ad}\nPersonel Soyadı : {Soyad}\nPersonel Maası : {Maas} PNG Kina\nPersonel Unvan : {Unvan}\nPersonel İzin Gunu : {IzinGunu} Gün";
            else
                return $"\n** Personel Oluşturulmamış **\n\n";


        }






    }
}
