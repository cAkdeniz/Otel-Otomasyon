using OtelOtomasyon.Business.Abstract;
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
    public class MusteriManager: IMusteriService
    {
        private OtelOtomasyonUnitOfWork _unitOfWork;
        public MusteriManager(OtelOtomasyonUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Musteri musteri)
        {
            _unitOfWork.MusteriDal.Add(musteri);
        }

        public void Delete(int id)
        {
            _unitOfWork.MusteriDal.Delete(id);
        }

        public DataTable GetAll()
        {
            return _unitOfWork.MusteriDal.GetAll();
        }

        public void Update(Musteri musteri)
        {
            _unitOfWork.MusteriDal.Update(musteri);
        }
    }
}
