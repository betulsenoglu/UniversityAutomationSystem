using BAUOtomasyon.Entities.Models;
using System.Data.Entity.ModelConfiguration;

namespace BAUOtomasyon.Entities.Mappings
{
    public class NotMapping : EntityTypeConfiguration<Not>
    {
        public NotMapping()
        {
            ToTable("Not");
            Property(x => x.GuncellemeTarihi).IsOptional();
        }
    }
}
