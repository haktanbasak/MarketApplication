using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MarketApplication.Models
{
    public class Satici
    {
        [Key]
        public int SaticiId { get; set; }
        public string AdSoyad { get; set; }
        public string Sifre { get; set; }
        public string Eposta { get; set; }
        public string Telefon { get; set; }

        public int MagazaId { get; set; }
        public Magaza Magaza { get; set; }
        public virtual ICollection<Siparis> Sipariler { get; set; }


    }
}