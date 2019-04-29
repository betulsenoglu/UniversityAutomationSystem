using BAUOtomasyon.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAUOtomasyon.Entities.Mappings
{
    public class AkademisyenMapping : EntityTypeConfiguration<Akademisyen>
    {
        public AkademisyenMapping()
        {
            this.ToTable("Akademisyen");
            this.HasIndex(x => x.KimlikNo).IsClustered(false).IsUnique();
            Property(x => x.KimlikNo).HasMaxLength(11).HasColumnType("char").IsRequired();
            Property(x => x.Adi).HasMaxLength(50).IsRequired();
            Property(x => x.Soyadi).HasMaxLength(50).IsRequired();
            Property(x => x.Cinsiyeti).HasColumnType("int");
            Property(x => x.GuncellemeTarihi).IsOptional();
        }
    }
}
