using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAUOtomasyon.Entities.Models
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public DateTime? OlusuturulmaTarihi { get; set; }
        public int? OlusturanPersonelID { get; set; }
        public bool? AktifMi { get; set; }
    }
}
