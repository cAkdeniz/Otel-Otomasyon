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

namespace OtelOtomasyon.DesktopUI.Musteriler
{
    public partial class FrmMusteri : Form
    {
        private OtelOtomasyonWorker _worker;
        public FrmMusteri(OtelOtomasyonWorker worker)
        {
            InitializeComponent();
            _worker = worker;
        }

        private void DoldurTablo()
        {
            var musteriler = _worker.MusteriService.GetAll();
            dgwMusteri.DataSource = musteriler;
        }

        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            DoldurTablo();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri()
            {
                Adi = txtAdi.Text,
                SirketAdi = txtSirketAdi.Text,
                Soyadi = txtSoyad.Text,
                TcNo = txtTcKn.Text,
                TelNo = txtTelNo.Text,
                DogumTarih = txtDogumTarih.Value,
                MedeniDurum = cmbCinsiyet.Text,
                Cinsiyet = cmbMedeniDurum.Text
            };

            _worker.MusteriService.Add(musteri);

            DoldurTablo();
        }
    }
}
