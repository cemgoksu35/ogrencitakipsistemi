using System;
using System.Collections.Generic;
using SinavSistemi.Models;

namespace SinavSistemi
{
    class Program
    {
        static void Main(string[] args)
        {

            Sifre sifre = new Sifre();

            while (true)
            {

            

            string KAdi, Sifre;
            Console.WriteLine("Kullanıcı Adınızı Giriniz : ");
            KAdi = Console.ReadLine();

            Console.WriteLine("Lütfen Şifrenizi Giriniz");
            Sifre = Console.ReadLine();

            bool girisyap = sifre.GirisKontrol(KAdi,Sifre);

            if (girisyap==true)
            {
                    Console.WriteLine("Giriş Başarılı Öğrenci Takip Sistemine Hoşgeldiniz\n");
                List<Ogrenciler> ogrencilers = new List<Ogrenciler>();
                Ogrenciler newogrenci1 = new Ogrenciler();
                Ogrenciler newogrenci2 = new Ogrenciler();
                Ogrenciler newogrenci3 = new Ogrenciler();
                Ogrenciler newogrenci4 = new Ogrenciler();
                Console.WriteLine("Adı" + "\t" + "Soyadı" + "\t" + "No" + "\t" + "Ort" + "\t" + "Durum" + "\n");
                    
                newogrenci1.Adi = "Cem";
                newogrenci1.Soyadi = "GÖKSU";
                newogrenci1.OgrenciNo = "11";
                newogrenci1.Vize1 = 45;
                newogrenci1.Vize2 = 55;
                newogrenci1.Sozlu = 70;
                newogrenci1.Final = 90;

                newogrenci2.Adi = "Pablo";
                newogrenci2.Soyadi = "GÖKSU";
                newogrenci2.OgrenciNo = "22";
                newogrenci2.Vize1 = 35;
                newogrenci2.Vize2 = 33;
                newogrenci2.Sozlu = 22;
                newogrenci2.Final = 21;

                newogrenci3.Adi = "Minik";
                newogrenci3.Soyadi = "GÖKSU";
                newogrenci3.OgrenciNo = "33";
                newogrenci3.Vize1 = 80;
                newogrenci3.Vize2 = 35;
                newogrenci3.Sozlu = 66;
                newogrenci3.Final = 33;

                newogrenci4.Adi = "Fulya";
                newogrenci4.Soyadi = "GÖKSU";
                newogrenci4.OgrenciNo = "44";
                newogrenci4.Vize1 = 99;
                newogrenci4.Vize2 = 35;
                newogrenci4.Sozlu = 77;
                newogrenci4.Final = 90;

                ogrencilers.Add(newogrenci1);
                ogrencilers.Add(newogrenci2);
                ogrencilers.Add(newogrenci3);
                ogrencilers.Add(newogrenci4);


                for (int i = 0; i < ogrencilers.Count; i++)
                {
                    Console.WriteLine(ogrencilers[i].Adi + "\t" + ogrencilers[i].Soyadi + "\t" + ogrencilers[i].OgrenciNo + "\t" + ogrencilers[i].sondurum + "\t" + ogrencilers[i].GectiMi());

                }



                    while (true)
                    {
                        Console.Write("\nAranacak numara giriniz: ");
                        string aranandeger = Console.ReadLine();
                        bool varmi = false;


                        for (int i = 0; i < ogrencilers.Count; i++)
                        {
                            varmi = ogrencilers[i].OgrenciNo.Contains(aranandeger);
                            if (varmi == true)
                            {

                                Console.WriteLine($"Bulundu \nAdı : {ogrencilers[i].Adi} \nSoyadı : {ogrencilers[i].Soyadi} \nGeçme Durumu : {ogrencilers[i].sondurum} \nGeçme Durumu :  {ogrencilers[i].GectiMi()}");

                            }

                        }

                        Console.WriteLine("Bitti");
                    }






                // Numaradan öğrenci aratma

               
            }
            else
            {
                Console.WriteLine("Tekrar Deneyin");
            }


            }

        }
    }
}
