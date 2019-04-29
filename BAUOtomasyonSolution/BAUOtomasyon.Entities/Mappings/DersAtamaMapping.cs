using BAUOtomasyon.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAUOtomasyon.Entities.Mappings
{
    public class DersAtamaMapping : EntityTypeConfiguration<DersAtama>
    {
        public DersAtamaMapping()
        {
            this.ToTable("DersAtama");
            Property(x => x.OgrenciID).IsOptional();
            Property(x => x.AkademisyenID).IsOptional();
        }
    }
}
