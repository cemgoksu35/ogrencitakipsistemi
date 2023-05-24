using System;
namespace SinavSistemi.Models
{
    public class Sinavlar
    {
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
        }


       


    }
}
