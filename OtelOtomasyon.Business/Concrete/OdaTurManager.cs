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
    public class OdaTurManager: IOdaTurService
    {
        private OtelOtomasyonUnitOfWork _unitOfWork;
        public OdaTurManager(OtelOtomasyonUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(OdaTur odaTur)
        {
            _unitOfWork.OdaTurDal.Add(odaTur);
        }

        public void Delete(int id)
        {
            _unitOfWork.OdaTurDal.Delete(id);
        }

        public DataTable GetAll()
        {
            return _unitOfWork.OdaTurDal.GetAll();
        }

        public void Update(OdaTur odaTur)
        {
            _unitOfWork.OdaTurDal.Update(odaTur);
        }
    }
}
