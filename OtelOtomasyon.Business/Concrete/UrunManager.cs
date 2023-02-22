using OtelOtomasyon.Business.Abstract;
using OtelOtomasyon.DataAccess.Abstract;
using OtelOtomasyon.DataAccess.UnitOfWork;
using OtelOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.Business.Concrete
{
    public class UrunManager: IUrunService
    {
        private OtelOtomasyonUnitOfWork _unitOfWork;
        public UrunManager(OtelOtomasyonUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Urun urun)
        {
            _unitOfWork.UrunDal.Add(urun);
        }

        public void Delete(int id)
        {
            _unitOfWork.UrunDal.Delete(id);
        }

        public DataTable Get(int id)
        {
            return _unitOfWork.UrunDal.Get(id);
        }

        public DataTable GetAll()
        {
            return _unitOfWork.UrunDal.GetAll();
        }

        public void Update(Urun urun)
        {
            _unitOfWork.UrunDal.Update(urun);
        }
    }
}
