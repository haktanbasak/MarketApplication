using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketApplication.Models
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string Ad { get; set; }
        public double Fiyat { get; set; }
        public string Fotograf { get; set; }
        public string Icindekiler { get; set; }
        public string Aciklama { get; set; }


        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }

        public int MagazaId { get; set; }
        public Magaza Magaza { get; set; }


        public virtual ICollection<Yorum> Yorumlar { get; set; }
        public virtual ICollection<Sepet> Sepetler { get; set; }
    }
}