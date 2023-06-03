using System;
namespace SinavSistemi.Models
{
    public class Ogrenciler
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string OgrenciNo { get; set; }


        public string GectiMi() => sondurum > 50 ? "Geçti" : "Kaldı";
        public double Vize1 { get; set; }
        public double Vize2 { get; set; }
        public double Sozlu { get; set; }
        public double Final { get; set; }

        double _vize1;
        double _vize2;
        double _sozlu;
        double _final;


        public double sondurum
        {
            set { _vize1 = Vize1; _vize2 = Vize2; _final = Final; _sozlu = Sozlu; }
            get => (Vize1 * 0.2) + (Vize2 * 0.20) + (Sozlu * 0.10) + (Final * 0.50);


            // public string OgrenciNoAra(string ogrenciNo) => ogrenciNo == _ogrencino ? $"Bulundu{Adi} {Soyadi}" : "Bulunamadı";
            /*  public string OgrenciNoAra {
                  get {
                      string degerdon = _ogrencino == OgrenciNo ? "Bulundu" : "Bulunamadı";
                      return degerdon;
                          }
                  set {
                      OgrenciNo = _ogrencino;
                      Adi=_adi;
                      Soyadi = _soyadi;
                  }
              } */




        }
    }
}


