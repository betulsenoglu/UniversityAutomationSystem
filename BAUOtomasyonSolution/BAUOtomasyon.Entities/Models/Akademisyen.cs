using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAUOtomasyon.Entities.Models
{
    public class Akademisyen : BaseInsan
    {
        public Akademisyen()
        {
            AkademisyenIletisimleri = new List<Iletisim>();
            Bolumler = new List<Bolum>();
            AkademisyenDersAtamalari = new List<DersAtama>();
            AkademisyenUnvanlari = new List<Unvan>();
            AkademisyenSifreleri = new List<Sifre>();
        }

        public virtual ICollection<Iletisim> AkademisyenIletisimleri { get; set; }
        public virtual ICollection<Bolum> Bolumler { get; set; }
        public virtual ICollection<DersAtama> AkademisyenDersAtamalari { get; set; }
        public virtual ICollection<Unvan> AkademisyenUnvanlari { get; set; }
        public virtual ICollection<Sifre> AkademisyenSifreleri { get; set; }
    }
}
