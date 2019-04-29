using BAUOtomasyon.Entities.Models;
using System.Data.Entity.ModelConfiguration;

namespace BAUOtomasyon.Entities.Mappings
{
    public class SifreMapping : EntityTypeConfiguration<Sifre>
    {
        public SifreMapping()
        {
            ToTable("Sifre");
            Property(x => x.AkademisyenID).IsOptional();
            Property(x => x.OgrenciID).IsOptional();
            Property(r => r.KullaniciSifre).HasMaxLength(8).IsRequired();
            Property(x => x.GuncellemeTarihi).IsOptional();
        }
    }
}
