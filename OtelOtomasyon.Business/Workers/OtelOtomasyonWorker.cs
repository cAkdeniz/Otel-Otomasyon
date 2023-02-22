using OtelOtomasyon.Business.Abstract;
using OtelOtomasyon.Business.Concrete;
using OtelOtomasyon.DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.Business.Workers
{
    public class OtelOtomasyonWorker: IWorker
    {
        private OtelOtomasyonUnitOfWork _unitOfWork;

        public IUrunService UrunService { get; set; }
        public ITedarikciService TedarikciService { get; set; }
        public IKategoriService KategoriService { get; set; }
        public IBirimTipService BirimTipService { get; set; }
        public IOdaTurService OdaTurService { get; set; }
        public IOdaService OdaService { get; set; }
        public IOdaOzellikService OdaOzellikService { get; set; }
        public IOzellikService OzellikService { get; set; }
        public IPersonelService PersonelService { get; set; }
        public IMusteriService MusteriService { get; set; }

        public OtelOtomasyonWorker()
        {
            _unitOfWork = new OtelOtomasyonUnitOfWork(null);

            UrunService = new UrunManager(_unitOfWork);
            TedarikciService = new TedarikciManager(_unitOfWork);
            KategoriService = new KategoriManager(_unitOfWork);
            BirimTipService = new BirimTipManager(_unitOfWork);
            OdaTurService = new OdaTurManager(_unitOfWork);
            OdaService = new OdaManager(_unitOfWork);
            OdaOzellikService = new OdaOzellikManager(_unitOfWork);
            OzellikService = new OzellikManager(_unitOfWork);
            PersonelService = new PersonelManager(_unitOfWork);
            MusteriService = new MusteriManager(_unitOfWork);
        }
    }
}
