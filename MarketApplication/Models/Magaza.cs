using System.Collections.Generic;

namespace MarketApplication.Models
{
    public class Magaza
    {
        public int MagazaId { get; set; }
        public string Ad { get; set; }
        public double MinimumFiyat { get; set; }
        public string Konum { get; set; }
        public string KapakGorsel { get; set; }

        public virtual ICollection<Urun> Urunler { get; set; }

        public int MagazaKategoriId { get; set; }
        public MagazaKategori Kategori { get; set; }

        public virtual ICollection<Yorum> Yorumlar { get; set; }
        public virtual ICollection<Satici> Saticilar { get; set; }



    }
}