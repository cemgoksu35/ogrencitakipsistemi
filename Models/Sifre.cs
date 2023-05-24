using System;
namespace SinavSistemi.Models
{
    public class Sifre
    {
      


        string _kullaniciadi;
        string _sifre;

        public bool GirisKontrol(string kullanciadi, string sifre)
        {
            _sifre = sifre;
            _kullaniciadi = kullanciadi;
            
                if (kullanciadi=="cem" && sifre=="12345")
                {
                   return true;
                }
                else
                {
                    return false;
                }
            
        }


    }
}
