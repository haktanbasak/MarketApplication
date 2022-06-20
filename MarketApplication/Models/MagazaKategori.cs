using System.Collections.Generic;

namespace MarketApplication.Models
{
    public class MagazaKategori
    {
        public int MagazaKategoriId { get; set; }
        public string Ad { get; set; }
        public string Resim { get; set; }


        public virtual ICollection<Magaza> Magazalar { get; set; }
    }
}