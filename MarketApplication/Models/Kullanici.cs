using System.Collections.Generic;

namespace MarketApplication.Models
{
    public class Kullanici
    {
        public int KullaniciId { get; set; }
        public string AdSoyad { get; set; }
        public string Sifre { get; set; }
        public string Eposta { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }

        public virtual ICollection<Yorum> Yorumlar { get; set; }
        public virtual ICollection<Siparis> Siparis { get; set; }
    }
}