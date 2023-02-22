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
    public partial class FrmOda : Form
    {
        private OtelOtomasyonWorker _worker;
        public FrmOda(OtelOtomasyonWorker worker)
        {
            InitializeComponent();
            _worker = worker;
        }

        private void FillComboBox()
        {
            DataTable odaTurler = _worker.OdaTurService.GetAll();
            for (int i = 0; i < odaTurler.Rows.Count; i++)
            {
                ComboBoxItem comboBox = new ComboBoxItem();
                comboBox.Key = odaTurler.Rows[i]["Id"].ToString();
                comboBox.Value = odaTurler.Rows[i]["Adi"].ToString();

                cmbOdaTur.Items.Add(comboBox);
            }

            DataTable odalar = _worker.OdaService.GetAll();
            for (int i = 0; i < odalar.Rows.Count; i++)
            {
                ComboBoxItem comboBox = new ComboBoxItem();
                comboBox.Key = odalar.Rows[i]["Id"].ToString();
                comboBox.Value = odalar.Rows[i]["Adi"].ToString();

                cmbAra.Items.Add(comboBox);
            }
        }

        private void DoldurTablo()
        {
            var odalar = _worker.OdaService.GetWithOzellikler();
            dgwOdalar.DataSource = odalar;
        }

        private void FrmOda_Load(object sender, EventArgs e)
        {
            DoldurTablo();
            FillComboBox();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Oda oda = new Oda()
            {
                Adi = txtAdi.Text,
                Aciklama = txtAciklama.Text,
                OdaTurId = int.Parse((cmbOdaTur.SelectedItem as ComboBoxItem).Key)
            };

            _worker.OdaService.Add(oda);

            DoldurTablo();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            var odaId = int.Parse((cmbAra.SelectedItem as ComboBoxItem).Key);
            var oda = _worker.OdaService.GetWithOzelliklerByWithId(odaId);

            dgwOdalar.DataSource = oda;
        }
    }
}
