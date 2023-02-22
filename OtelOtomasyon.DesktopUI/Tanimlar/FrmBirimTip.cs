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
    public partial class FrmBirimTip : Form
    {
        private OtelOtomasyonWorker _worker;
        public FrmBirimTip(OtelOtomasyonWorker worker)
        {
            InitializeComponent();
            _worker = worker;
        }

        private void DoldurTablo()
        {
            var birimTipler = _worker.BirimTipService.GetAll();
            dgwBirimTip.DataSource = birimTipler;
        }

        private void FrmBirimTip_Load(object sender, EventArgs e)
        {
            DoldurTablo();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            BirimTip birimTip = new BirimTip()
            {
                Adi = txtBirimTip.Text
            };

            _worker.BirimTipService.Add(birimTip);

            DoldurTablo();
        }
    }
}
