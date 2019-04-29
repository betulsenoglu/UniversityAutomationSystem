namespace BAUOtomasyon.Entities.Models
{
    public class Sifre : BaseEntity
    {
        public string KullaniciSifre { get; set; }
        public int? OgrenciID { get; set; }
        public int? AkademisyenID { get; set; }

        public virtual Ogrenci Ogrenci { get; set; }
        public virtual Akademisyen Akademisyen { get; set; }
    }
}
