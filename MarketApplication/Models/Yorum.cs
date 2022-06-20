namespace MarketApplication.Models
{
    public class Yorum
    {
        public int YorumId { get; set; }
        public string YorumIcerik { get; set; }


        public int? UrunId { get; set; }
        public Urun Urun { get; set; }

        public int? MagazaId { get; set; }
        public Magaza Magaza { get; set; }

        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }



    }
}