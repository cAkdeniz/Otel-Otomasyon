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

namespace OtelOtomasyon.DesktopUI.Personeller
{
    public partial class FrmPersonel : Form
    {
        private OtelOtomasyonWorker _worker;
        public FrmPersonel(OtelOtomasyonWorker worker)
        {
            InitializeComponent();
            _worker = worker;
        }

        private void DoldurTablo()
        {
            DataTable personeller = _worker.PersonelService.GetAll();
            dgwPersonel.DataSource = personeller;
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            DoldurTablo();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel()
            {
                Adi = txtAdi.Text,
                Soyadi = txtSoyad.Text,
                DogumTarih = txtDogumTarih.Value,
                IseGirisTarih = txtIseGirisTarih.Value,
                TcKn = txtTcKn.Text,
                TelNo = txtTelNo.Text,
                Maas = txtMaas.Value,
                Adres = txtAdres.Text
            };

            _worker.PersonelService.Add(personel);

            DoldurTablo();
        }
    }
}
