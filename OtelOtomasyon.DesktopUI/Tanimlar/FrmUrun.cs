using OtelOtomasyon.Business.Workers;
using OtelOtomasyon.DesktopUI.Models;
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
    public partial class FrmUrun : Form
    {
        private OtelOtomasyonWorker _worker;
        public FrmUrun(OtelOtomasyonWorker worker)
        {
            InitializeComponent();
            _worker = worker;
        }

        private void FillComboBox()
        {
            DataTable kategoriler = _worker.KategoriService.GetAll();
            for (int i = 0; i < kategoriler.Rows.Count; i++)
            {
                ComboBoxItem comboBox = new ComboBoxItem();
                comboBox.Key = kategoriler.Rows[i]["Id"].ToString();
                comboBox.Value = kategoriler.Rows[i]["Adi"].ToString();

                cmbKategori.Items.Add(comboBox);
            }

            DataTable birimTipler = _worker.BirimTipService.GetAll();
            for (int i = 0; i < birimTipler.Rows.Count; i++)
            {
                ComboBoxItem comboBox = new ComboBoxItem();
                comboBox.Key = birimTipler.Rows[i]["Id"].ToString();
                comboBox.Value = birimTipler.Rows[i]["Adi"].ToString();

                cmbBirim.Items.Add(comboBox);
            }
        }

        private void DoldurTablo()
        {
            var urunler = _worker.UrunService.GetAll();
            dgwUrun.DataSource = urunler;
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            FillComboBox();
            DoldurTablo();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun()
            {
                Adi = txtUrunAdi.Text,
                Miktar = (double?)txtMiktar.Value,
                Fiyat = txtFiyat.Value,
                KategoriId = int.Parse((cmbKategori.SelectedItem as ComboBoxItem).Key),
                BirimTipId = int.Parse((cmbBirim.SelectedItem as ComboBoxItem).Key),
            };

            _worker.UrunService.Add(urun);

            DoldurTablo();
        }
    }
}
