using System.Collections.Generic;

namespace BAUOtomasyon.Entities.Models
{
    public class Unvan : BaseEntity
    {
        public Unvan()
        {
            Akademisyenler = new List<Akademisyen>();
        }
        public string UnvanAdi { get; set; }

        public virtual ICollection<Akademisyen> Akademisyenler { get; set; }
    }
}
