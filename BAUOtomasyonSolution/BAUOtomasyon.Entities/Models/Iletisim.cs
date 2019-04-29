using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAUOtomasyon.Entities.Models
{
    public class Iletisim : BaseEntity
    {
        public int AkademisyenID { get; set; }
        public int OgrenciID { get; set; }
        public string Telefon { get; set; }
        public string EMail { get; set; }
        public string Adres { get; set; }

        public virtual Akademisyen Akademisyen { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }
    }
}

