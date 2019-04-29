using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAUOtomasyon.Entities.Models
{
    public class Fakulte: BaseEntity
    {
        public Fakulte()
        {
            Bolumler = new List<Bolum>();
        }
        public string FakulteAdi { get; set; }

        public virtual ICollection<Bolum> Bolumler { get; set; }
    }
}
