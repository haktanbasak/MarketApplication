using MarketApplication.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MarketApplication.DbContexts
{
    public class Context:DbContext
    {
        public Context():base("con2")
        {

        }

        public DbSet<Urun> Urun { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Magaza> Magaza { get; set; }
        public DbSet<MagazaKategori> MagazaKategori { get; set; }
        public DbSet<Siparis> Siparis { get; set; }
        public DbSet<SiparisStatu> SiparisStatu { get; set; }
        public DbSet<Yorum> Yorum { get; set; }
        public DbSet<Sepet> Sepet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}