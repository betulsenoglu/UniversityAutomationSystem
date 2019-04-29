using BAUOtomasyon.Entities.Models.EnumTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAUOtomasyon.Entities.Models
{
    public class DersAtama : BaseEntity
    {
        public int OgrenciID { get; set; }
        public int DersID { get; set; }
        public int AkademisyenID { get; set; }
        public Donem OgrenimDonemi { get; set; }

        public virtual Ogrenci Ogrenci { get; set; }
        public virtual Ders Ders { get; set; }
        public virtual Akademisyen Akademisyen { get; set; }
    }
}
