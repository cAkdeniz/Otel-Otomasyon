using OtelOtomasyon.DataAccess.Abstract;
using OtelOtomasyon.DataAccess.Concrete;
using OtelOtomasyon.DataAccess.Context.MsSqlContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.DataAccess.UnitOfWork
{
    public class OtelOtomasyonUnitOfWork
    {
        private readonly OtelOtomasyonContext _context;

        public IUrunDal UrunDal { get; set; }
        public ITedarikciDal TedarikciDal { get; set; }
        public ISatisDetayDal SatisDetayDal { get; set; }
        public ISatisDal SatisDal { get; set; }
        public IMusteriDal MusteriDal { get; set; }
        public ISatinAlmaDetayDal SatinAlmaDetayDal { get; set; }
        public ISatinAlmaDal SatinAlmaDal { get; set; }
        public IOzellikDal OzellikDal { get; set; }
        public IOdaOzellikDal OdaOzellikDal { get; set; }
        public IOdaDal OdaDal { get; set; }
        public IOdaTurDal OdaTurDal { get; set; }
        public IPersonelDal PersonelDal { get; set; }
        public IKategoriDal KategoriDal { get; set; }
        public IKasaHareketTipDal KasaHareketTipDal { get; set; }
        public IKasaHareketDal KasaHareketDal { get; set; }
        public IKasaDal KasaDal { get; set; }
        public IBirimTipDal BirimTipDal { get; set; }

        public OtelOtomasyonUnitOfWork(string connectionString = null)
        {
            _context = new OtelOtomasyonContext();

            UrunDal = new UrunDal(_context);
            TedarikciDal = new TedarikciDal(_context);
            SatisDetayDal = new SatisDetayDal(_context);
            SatisDal = new SatisDal(_context);
            MusteriDal = new MusteriDal(_context);
            SatinAlmaDetayDal = new SatinAlmaDetayDal(_context);
            SatinAlmaDal = new SatinAlmaDal(_context);
            OzellikDal = new OzellikDal(_context);
            OdaOzellikDal = new OdaOzellikDal(_context);
            OdaDal = new OdaDal(_context);
            OdaTurDal = new OdaTurDal(_context);
            PersonelDal = new PersonelDal(_context);
            KategoriDal = new KategoriDal(_context);
            KasaHareketTipDal = new KasaHareketTipDal(_context);
            KasaHareketDal = new KasaHareketDal(_context);
            KasaDal = new KasaDal(_context);
            BirimTipDal = new BirimTipDal(_context);
        }
    }
}
