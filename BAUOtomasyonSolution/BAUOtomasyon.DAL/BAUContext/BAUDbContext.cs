using BAUOtomasyon.Entities.Mappings;
using BAUOtomasyon.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAUOtomasyon.DAL.BAUContext
{
    public class BAUDbContext : DbContext
    {
        public BAUDbContext():base("BAUDbContext")
        {

        }
        public DbSet<Akademisyen> Akademisyen { get; set; }
        public DbSet<Bolum> Bolum { get; set; }
        public DbSet<Ders> Ders { get; set; }
        public DbSet<DersAtama> DersAtama { get; set; }
        public DbSet<Fakulte> Fakulte { get; set; }
        public DbSet<Iletisim> Iletisim { get; set; }
        public DbSet<Not> Not { get; set; }
        public DbSet<Ogrenci> Ogrenci { get; set; }
        public DbSet<Sifre> Sifre { get; set; }
        public DbSet<Unvan> Unvan { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AkademisyenMapping());
            modelBuilder.Configurations.Add(new BolumMapping());
            modelBuilder.Configurations.Add(new DersAtamaMapping());
            modelBuilder.Configurations.Add(new DersMapping());
            modelBuilder.Configurations.Add(new FakulteMapping());
            modelBuilder.Configurations.Add(new IletisimMapping());
            modelBuilder.Configurations.Add(new NotMapping());
            modelBuilder.Configurations.Add(new OgrenciMapping());
            modelBuilder.Configurations.Add(new SifreMapping());
            modelBuilder.Configurations.Add(new UnvanMapping());
        }
    }
}
