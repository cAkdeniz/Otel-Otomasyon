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
    public partial class FrmOdaOzellik : Form
    {
        private OtelOtomasyonWorker _worker;
        public FrmOdaOzellik(OtelOtomasyonWorker worker)
        {
            InitializeComponent();
            _worker = worker;
        }

        private void FillAll()
        {
            DataTable odalar = _worker.OdaService.GetAll();
            for (int i = 0; i < odalar.Rows.Count; i++)
            {
                ComboBoxItem comboBox = new ComboBoxItem();
                comboBox.Key = odalar.Rows[i]["Id"].ToString();
                comboBox.Value = odalar.Rows[i]["Adi"].ToString();

                cmbOda.Items.Add(comboBox);
            }

            DataTable ozellikler = _worker.OzellikService.GetAll();
            for (int i = 0; i < ozellikler.Rows.Count; i++)
            {
                ListBoxItem listBox = new ListBoxItem();
                listBox.Key = ozellikler.Rows[i]["Id"].ToString();
                listBox.Value = ozellikler.Rows[i]["Adi"].ToString();

                listOzellik.Items.Add(listBox);
            }
        }

        private void ClearAll()
        {
            txtDeger.Text = "";
            cmbOda.Text = "";
            listOzellik.SelectedItem = null;
        }

        private void FrmOdaOzellik_Load(object sender, EventArgs e)
        {
            FillAll();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OdaOzellik odaOzellik = new OdaOzellik()
            {
                OdaId = int.Parse((cmbOda.SelectedItem as ComboBoxItem).Key),
                OzellikId = int.Parse((listOzellik.SelectedItem as ListBoxItem).Key),
                Deger = txtDeger.Text.ToString()
            };

            _worker.OdaOzellikService.Add(odaOzellik);

            MessageBox.Show("Seçili odaya özellik eklendi.");

            ClearAll();
        }
    }
}
