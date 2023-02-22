using OtelOtomasyon.Business.Workers;
using OtelOtomasyon.DataAccess.Concrete;
using OtelOtomasyon.DataAccess.Context.MsSqlContext;
using OtelOtomasyon.DesktopUI.Musteriler;
using OtelOtomasyon.DesktopUI.Personeller;
using OtelOtomasyon.DesktopUI.Satislar;
using OtelOtomasyon.DesktopUI.Tanimlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyon.DesktopUI
{
    public partial class Form1 : Form
    {
        OtelOtomasyonWorker worker = new OtelOtomasyonWorker();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //OtelOtomasyonContext context = new OtelOtomasyonContext();
            //UrunDal aga = new UrunDal(context);
            //var cagatay = aga.GetAll();
            var cagatay = worker.UrunService.GetAll();
            return;
        }

        private void KategoriStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKategori frmKategori = new FrmKategori(worker);
            frmKategori.MdiParent = this;
            frmKategori.Show();
        }

        private void BirimTiplerStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBirimTip frmBirimTip = new FrmBirimTip(worker);
            frmBirimTip.MdiParent = this;
            frmBirimTip.Show();
        }

        private void UrunlerStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUrun frmUrun = new FrmUrun(worker);
            frmUrun.MdiParent = this;
            frmUrun.Show();
        }

        private void OdaTurlerStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOdaTur frmOdaTur = new FrmOdaTur(worker);
            frmOdaTur.MdiParent = this;
            frmOdaTur.Show();
        }

        private void OdalarStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOda frmOda = new FrmOda(worker);
            frmOda.MdiParent = this;
            frmOda.Show();
        }

        private void OzellikStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOzellik frmOzellik = new FrmOzellik(worker);
            frmOzellik.MdiParent = this;
            frmOzellik.Show();
        }

        private void OdaOzellikStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOdaOzellik frmOdaOzellik = new FrmOdaOzellik(worker);
            frmOdaOzellik.MdiParent = this;
            frmOdaOzellik.Show();
        }

        private void MusterilerStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMusteri frmMusteri = new FrmMusteri(worker);
            frmMusteri.MdiParent = this;
            frmMusteri.Show();
        }

        private void PersonellerStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonel frmPersonel = new FrmPersonel(worker);
            frmPersonel.MdiParent = this;
            frmPersonel.Show();
        }

        private void SatisStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSatis frmSatis = new FrmSatis(worker);
            frmSatis.MdiParent = this;
            frmSatis.Show();
        }
    }
}
