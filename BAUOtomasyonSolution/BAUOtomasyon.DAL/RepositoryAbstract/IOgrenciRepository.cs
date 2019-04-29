using BAUOtomasyon.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAUOtomasyon.DAL.RepositoryAbstract
{
    interface IOgrenciRepository : IBaseRepository<Ogrenci>
    {
        bool OgrenciLoginKontrol(string kullaniciAdi, string sifre);
        ICollection<Ogrenci> ArananOgrenci(string isim);
    }
}
