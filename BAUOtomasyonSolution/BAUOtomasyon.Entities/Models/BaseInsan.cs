using BAUOtomasyon.Entities.Models.EnumTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAUOtomasyon.Entities.Models
{
    public class BaseInsan : BaseEntity
    {
        public string KimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public Cinsiyet? Cinsiyeti { get; set; }
        public DateTime? DogumTarihi { get; set; }
    }
}
