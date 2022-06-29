using System.Collections.Generic;

namespace MarketApplication.Models
{
    public class Siparis
    {
        public int SiparisId { get; set; }
        public double Tutar { get; set; }
        public string Adres { get; set; }

        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }

        public int SaticiId { get; set; }
        public Satici Satici { get; set; }

        public int SiparisStatuId { get; set; }
        public SiparisStatu siparisStatu { get; set; }

        public ICollection<Sepet> Sepetler { get; set; }

    }
}