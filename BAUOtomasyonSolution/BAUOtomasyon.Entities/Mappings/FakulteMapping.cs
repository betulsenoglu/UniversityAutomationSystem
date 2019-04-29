using BAUOtomasyon.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAUOtomasyon.Entities.Mappings
{
    public class FakulteMapping: EntityTypeConfiguration<Fakulte>
    {
        public FakulteMapping()
        {
            this.ToTable("Fakulte");
            Property(x => x.FakulteAdi).IsRequired().HasMaxLength(100);
            Property(x => x.GuncellemeTarihi).IsOptional();
        }
    }
}
