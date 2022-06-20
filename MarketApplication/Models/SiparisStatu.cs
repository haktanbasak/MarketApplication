using System.Collections.Generic;

namespace MarketApplication.Models
{
    public class SiparisStatu
    {
        public int SiparisStatuId { get; set; }
        public string Statu { get; set; }

        public virtual ICollection<Siparis> Siparisler { get; set; }
    }
}