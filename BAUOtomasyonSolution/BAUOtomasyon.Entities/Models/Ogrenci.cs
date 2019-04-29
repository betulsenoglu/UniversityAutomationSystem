using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAUOtomasyon.Entities.Models
{
    public class Ogrenci : BaseInsan
    {
        public Ogrenci()
        {
            OgrenciIletisimleri = new List<Iletisim>();
            OgrenciBolumleri = new List<Bolum>();
            OgrenciNotlari = new List<Not>();
            OgrenciDersAtamalari = new List<DersAtama>();
            OgrenciSifreleri = new List<Sifre>();
        }

        public string OgrenciNo { get; set; }

        public virtual ICollection<Iletisim> OgrenciIletisimleri { get; set; }
        public virtual ICollection<Bolum> OgrenciBolumleri { get; set; }
        public virtual ICollection<Not> OgrenciNotlari { get; set; }
        public virtual ICollection<DersAtama> OgrenciDersAtamalari { get; set; }
        public virtual ICollection<Sifre> OgrenciSifreleri { get; set; }
    }
}
