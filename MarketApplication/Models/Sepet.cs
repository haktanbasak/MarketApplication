namespace MarketApplication.Models
{
    public class Sepet
    {
        public int SepetId { get; set; }
        public int Adet { get; set; }
        public bool isAktif { get; set; }
        public double SepetTutar { get; set; }

        public int UrunId { get; set; }
        public Urun Urun { get; set; }
        
    }
}