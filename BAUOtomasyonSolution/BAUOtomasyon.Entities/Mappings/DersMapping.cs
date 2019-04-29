using BAUOtomasyon.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAUOtomasyon.Entities.Mappings
{
    public class DersMapping:EntityTypeConfiguration<Ders>
    {
        public DersMapping()
        {
            this.ToTable("Ders");
            Property(x => x.DersAdi).IsRequired().HasMaxLength(100);
            Property(x => x.GuncellemeTarihi).IsOptional();
        }
    }
}
