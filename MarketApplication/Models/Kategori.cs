using System.Collections.Generic;

namespace MarketApplication.Models
{
    public class Kategori
    {
        public int KategoriId { get; set; }
        public string Ad { get; set; }
        public string Resim { get; set; }

        public virtual ICollection<Urun> Urunler { get; set; }

    }
}