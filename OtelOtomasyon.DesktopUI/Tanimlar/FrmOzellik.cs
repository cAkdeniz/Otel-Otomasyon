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
    public partial class FrmOzellik : Form
    {
        private OtelOtomasyonWorker _worker;
        public FrmOzellik(OtelOtomasyonWorker worker)
        {
            InitializeComponent();
            _worker = worker;
        }

        private void DoldurTablo()
        {
            var ozellikler = _worker.OzellikService.GetAll();
            dgwOzellik.DataSource = ozellikler;
        }

        private void FrmOzellik_Load(object sender, EventArgs e)
        {
            DoldurTablo();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ozellik ozellik = new Ozellik()
            {
                Adi = txtAdi.Text,
                Aciklama = txtAciklama.Text
            };

            _worker.OzellikService.Add(ozellik);

            DoldurTablo();
        }
    }
}
