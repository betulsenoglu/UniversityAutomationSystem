using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAUOtomasyon.Entities.Models
{
    public class Bolum : BaseEntity
    {
        public Bolum()
        {
            Akademisyenler = new List<Akademisyen>();
            Ogrenciler = new List<Ogrenci>();
            Dersler = new List<Ders>();
        }
        public int FakulteID { get; set; }
        public string BolumAdi { get; set; }

        public virtual Fakulte Fakulte { get; set; }
        public virtual ICollection<Akademisyen> Akademisyenler { get; set; }
        public virtual ICollection<Ogrenci> Ogrenciler { get; set; }
        public virtual ICollection<Ders> Dersler { get; set; }
    }
}
