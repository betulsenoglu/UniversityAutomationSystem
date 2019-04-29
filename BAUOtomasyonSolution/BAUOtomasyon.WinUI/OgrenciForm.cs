using BAUOtomasyon.BLL.BAUOtomasyonService;
using BAUOtomasyon.Entities.Models;
using BAUOtomasyon.Entities.Models.EnumTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAUOtomasyon.WinUI
{
    public partial class OgrenciForm : Form
    {
        OgrenciService _ogrenciService;
        public OgrenciForm()
        {
            InitializeComponent();
            _ogrenciService = new OgrenciService();
        }

        private void btnOgrenciKaydet_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Adi = txtAd.Text;
            ogrenci.Soyadi = txtSoyad.Text;
            ogrenci.OgrenciNo = Guid.NewGuid().ToString().Substring(0, 11);
            ogrenci.KimlikNo = txtKimlik.Text;
            ogrenci.Cinsiyeti = rdbErkek.Checked == true ? Cinsiyet.Erkek : Cinsiyet.Kadin;
            ogrenci.DogumTarihi = dateDogumTarihi.Value;
            ogrenci.OlusuturulmaTarihi = DateTime.Now;
            ogrenci.AktifMi = true;
            int sayi = _ogrenciService.AddOgrenciService(ogrenci);
            if (sayi > 0)
            {
                MessageBox.Show("Öğrenci başarıyla eklendi");
            }
            else
            {
                MessageBox.Show("Eklenemedi");
            }
        }
    }
}
