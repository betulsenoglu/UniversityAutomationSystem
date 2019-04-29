using BAUOtomasyon.BLL.BAUOtomasyonService;
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
    public partial class LoginForm : Form
    {
        OgrenciService _ogrenciService;
        public LoginForm()
        {
            InitializeComponent();
            _ogrenciService = new OgrenciService();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (rdbOgrenci.Checked)
            {
                if (string.IsNullOrEmpty(txtKullaniciAdi.Text))
                {
                    errorKullanici.SetError(txtKullaniciAdi, "Kullanıcı Adı Alanı Boş Geçilemez");
                }
                else
                {
                    bool girisDurum = _ogrenciService.OgrenciLoginKontrolService(txtKullaniciAdi.Text, txtSifre.Text);
                    if (girisDurum)
                    {
                        OgrenciAnaForm ogrenciAnaForm = new OgrenciAnaForm();
                        ogrenciAnaForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı ya da Şifreniz Yanlış!!");
                    }
                }
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {

        }
    }
}
