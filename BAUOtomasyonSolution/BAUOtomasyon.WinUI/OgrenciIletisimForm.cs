using BAUOtomasyon.BLL.BAUOtomasyonService;
using BAUOtomasyon.Entities.Models;
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
    public partial class OgrenciIletisimForm : Form
    {
        OgrenciService _ogrenciService;
        public OgrenciIletisimForm()
        {
            InitializeComponent();
            _ogrenciService = new OgrenciService();
        }

        private void txtOgrenciAdi_TextChanged(object sender, EventArgs e)
        {
            dgrOgrenciListesi.DataSource = null;
            List<Ogrenci> ogrenciListesi = _ogrenciService.ArananOgrenciService(txtOgrenciAdi.Text);
            dgrOgrenciListesi.DataSource = ogrenciListesi;
        }

        public void OgrenciDoldur()
        {

        }
    }
}
