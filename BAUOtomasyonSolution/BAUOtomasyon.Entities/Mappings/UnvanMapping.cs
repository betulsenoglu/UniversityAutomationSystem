using BAUOtomasyon.Entities.Models;
using System.Data.Entity.ModelConfiguration;

namespace BAUOtomasyon.Entities.Mappings
{
    public class UnvanMapping : EntityTypeConfiguration<Unvan>
    {
        public UnvanMapping()
        {
            ToTable("Unvan");
            Property(x => x.UnvanAdi).IsRequired().HasMaxLength(50);
            Property(x => x.GuncellemeTarihi).IsOptional();
        }
    }
}
