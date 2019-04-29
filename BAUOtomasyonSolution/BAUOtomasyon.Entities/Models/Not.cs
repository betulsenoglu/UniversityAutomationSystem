using BAUOtomasyon.Entities.Models.EnumTypes;

namespace BAUOtomasyon.Entities.Models
{
    public class Not : BaseEntity
    {
        public int OgrenciID { get; set; }
        public int DersID { get; set; }
        public decimal Notu { get; set; }
        public SinavTipi SinavTip { get; set; }
        public Donem Donemi { get; set; }

        public virtual Ogrenci Ogrenci { get; set; }
        public virtual Ders Ders { get; set; }
    }
}
