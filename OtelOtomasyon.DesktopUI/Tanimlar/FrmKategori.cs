using OtelOtomasyon.Business.Workers;
using OtelOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyon.DesktopUI.Tanimlar
{
    public partial class FrmKategori : Form
    {
        private OtelOtomasyonWorker _worker;
        public FrmKategori(OtelOtomasyonWorker worker)
        {
            InitializeComponent();
            _worker = worker;
        }

        private void DoldurTablo()
        {
            var kategoriler = _worker.KategoriService.GetAll();
            dgwKategori.DataSource = kategoriler;
        }

        private void FrmKategori_Load(object sender, EventArgs e)
        {
            DoldurTablo();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori()
            {
                Adi = txtKategoriAd.Text
            };

            _worker.KategoriService.Add(kategori);

            DoldurTablo();
        }
    }
}
