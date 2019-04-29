using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAUOtomasyon.Entities.Models
{
    public class Ders : BaseEntity
    {
        public Ders()
        {
            Bolumler = new List<Bolum>();
            Notlar = new List<Not>();
            DersAtamalari = new List<DersAtama>();
        }

        public string DersAdi { get; set; }
        public int Kredi { get; set; }
        public int Saat { get; set; }

        public virtual ICollection<Bolum> Bolumler { get; set; }
        public virtual ICollection<Not> Notlar { get; set; }
        public virtual ICollection<DersAtama> DersAtamalari { get; set; }
    }
}
