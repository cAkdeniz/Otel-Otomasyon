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
    public class OdaOzellikManager: IOdaOzellikService
    {
        private OtelOtomasyonUnitOfWork _unitOfWork;
        public OdaOzellikManager(OtelOtomasyonUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(OdaOzellik odaOzellik)
        {
            _unitOfWork.OdaOzellikDal.Add(odaOzellik);
        }

        public void Delete(int id)
        {
            _unitOfWork.OdaOzellikDal.Delete(id);
        }

        public DataTable GetAll()
        {
            return _unitOfWork.OdaOzellikDal.GetAll();
        }

        public void Update(OdaOzellik odaOzellik)
        {
            _unitOfWork.OdaOzellikDal.Update(odaOzellik);
        }
    }
}
