using BAUOtomasyon.DAL.RepositoryAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAUOtomasyon.Entities.Models;
using BAUOtomasyon.DAL.BAUContext;

namespace BAUOtomasyon.DAL.RepositoryConcrete
{
    public class OgrenciRepository : IOgrenciRepository
    {
        BAUDbContext _db;
        public OgrenciRepository()
        {
            _db = new BAUDbContext();
        }

        int _etkilenenSatir;
        public int AddItem(Ogrenci item)
        {
            _db.Ogrenci.Add(item);
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }

        public int DeleteItem(Ogrenci item)
        {
            _db.Ogrenci.Remove(item);
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }

        public ICollection<Ogrenci> GetAllById(int? id = null)
        {
            return _db.Ogrenci.ToList();
        }

        public Ogrenci GetById(int id)
        {
            return _db.Ogrenci.Where(x => x.ID == id).FirstOrDefault();
        }

        public int UpdateItem(Ogrenci item)
        {
            Ogrenci eskiOgrenci = _db.Ogrenci.Where(x => x.ID == item.ID).FirstOrDefault();
            eskiOgrenci.KimlikNo = item.KimlikNo;
            eskiOgrenci.Soyadi = item.Soyadi;
            eskiOgrenci.Adi = item.Adi;
            eskiOgrenci.GuncellemeTarihi = DateTime.Now;
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }

        public bool OgrenciLoginKontrol(string kullaniciAdi, string sifre)
        {
            Ogrenci ogrenci = _db.Ogrenci.Where(x => x.OgrenciNo == kullaniciAdi && x.AktifMi == true && x.OgrenciSifreleri.FirstOrDefault().KullaniciSifre == sifre && x.OgrenciSifreleri.FirstOrDefault().AktifMi == true).FirstOrDefault();

            if (ogrenci != null)
            {
                return true;
            }
            return false;
        }

        public ICollection<Ogrenci> ArananOgrenci(string isim)
        {
            return isim == null ?
                _db.Ogrenci.ToList() :
                _db.Ogrenci.SqlQuery("select * from Ogrenci where Adi Like '%" + isim + "%'").ToList();
        }
    }
}
