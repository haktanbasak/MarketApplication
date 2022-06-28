using System.ComponentModel.DataAnnotations.Schema;

namespace MarketApplication.Models
{
    public class Sepet
    {
        public int SepetId { get; set; }
        public int Adet { get; set; }
        public bool isAktif { get; set; }

        [NotMapped]
        public double SepetTutar
        {
            get
            {
                if(Adet != 0 && Urun != null)
                {
                    return Adet * Urun.Fiyat;
                }
                return 0.0;
                
            }
        }

        public int UrunId { get; set; }
        public Urun Urun { get; set; }

        public int? SiparisId { get; set; }
        public Siparis Siparis { get; set; }


    }
}