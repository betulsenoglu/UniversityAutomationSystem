using BAUOtomasyon.Entities.Models;
using System.Data.Entity.ModelConfiguration;

namespace BAUOtomasyon.Entities.Mappings
{
    public class IletisimMapping : EntityTypeConfiguration<Iletisim>
    {
        public IletisimMapping()
        {
            this.ToTable("Iletisim");
            Property(x => x.AkademisyenID).IsOptional();
            Property(x => x.OgrenciID).IsOptional();
            Property(x => x.Telefon).HasMaxLength(11).HasColumnType("char").IsRequired();
            Property(x => x.EMail).HasMaxLength(50).IsRequired();
            Property(x => x.Adres).IsRequired().HasMaxLength(500);
            Property(x => x.GuncellemeTarihi).IsOptional();
        }
    }
}
