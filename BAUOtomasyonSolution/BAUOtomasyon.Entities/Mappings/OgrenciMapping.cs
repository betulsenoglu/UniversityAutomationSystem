using BAUOtomasyon.Entities.Models;
using System.Data.Entity.ModelConfiguration;

namespace BAUOtomasyon.Entities.Mappings
{
    public class OgrenciMapping: EntityTypeConfiguration<Ogrenci>
    {
        public OgrenciMapping()
        {
            ToTable("Ogrenci");
            HasIndex(x => x.KimlikNo).IsClustered(false).IsUnique();
            Property(x => x.KimlikNo).HasMaxLength(11).HasColumnType("char").IsRequired();
            Property(x => x.Adi).HasMaxLength(50).IsRequired();
            Property(x => x.Soyadi).HasMaxLength(50).IsRequired();
            Property(x => x.Cinsiyeti).HasColumnType("int");
            Property(x => x.OgrenciNo).HasMaxLength(12).IsRequired().HasColumnType("char");
            Property(x => x.GuncellemeTarihi).IsOptional();
        }
    }
}
