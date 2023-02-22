using OtelOtomasyon.Business.Workers;
using OtelOtomasyon.DesktopUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyon.DesktopUI.Satislar
{
    public partial class FrmSatis : Form
    {
        private OtelOtomasyonWorker _worker;
        public FrmSatis(OtelOtomasyonWorker worker)
        {
            InitializeComponent();
            _worker = worker;
        }

        private void DoldurTablo()
        {
            var urunler = _worker.UrunService.GetAll();
            dgwUrunler.DataSource = urunler;
        }

        private void FillComboBox()
        {
            DataTable musteriler = _worker.MusteriService.GetAll();
            for (int i = 0; i < musteriler.Rows.Count; i++)
            {
                ComboBoxItem comboBox = new ComboBoxItem();
                comboBox.Key = musteriler.Rows[i]["Id"].ToString();
                comboBox.Value = musteriler.Rows[i]["Adi"].ToString();

                cmbMusteri.Items.Add(comboBox);
            }

            DataTable odalar = _worker.OdaService.GetAll();
            for (int i = 0; i < odalar.Rows.Count; i++)
            {
                ComboBoxItem comboBox = new ComboBoxItem();
                comboBox.Key = odalar.Rows[i]["Id"].ToString();
                comboBox.Value = odalar.Rows[i]["Adi"].ToString();

                cmbOda.Items.Add(comboBox);
            }
        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            DoldurTablo();
            FillComboBox();
        }

        private int FiyatHesapla()
        {
            int fiyat = (int)txtUrunFiyat.Value;
            int miktar = (int)txtUrunMiktar.Value;
            int indirim = (int)txtIndirim.Value;

            var indirimFiyat = (fiyat * indirim) / 100;

            return (fiyat - indirimFiyat) * miktar;
        }

        private void btnSatisaEkle_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();

            lvi.Text = (listSatislar.Items.Count + 1).ToString();
            lvi.SubItems.Add(dgwUrunler.CurrentRow.Cells["Adi"].Value.ToString());
            lvi.SubItems.Add(txtUrunMiktar.Value.ToString());
            lvi.SubItems.Add(txtIndirim.Value.ToString());
            lvi.SubItems.Add(FiyatHesapla().ToString());
            lvi.Tag = dgwUrunler.CurrentRow.Cells["Id"].Value.ToString();

            listSatislar.Items.Add(lvi);
        }

        private void dgwUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunFiyat.Value = (decimal)dgwUrunler.CurrentRow.Cells["Fiyat"].Value;
        }
    }
}
