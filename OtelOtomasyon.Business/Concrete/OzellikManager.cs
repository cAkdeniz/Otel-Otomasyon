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
    public class OzellikManager: IOzellikService
    {
        private OtelOtomasyonUnitOfWork _unitOfWork;
        public OzellikManager(OtelOtomasyonUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Ozellik ozellik)
        {
            _unitOfWork.OzellikDal.Add(ozellik);
        }

        public void Delete(int id)
        {
            _unitOfWork.OzellikDal.Delete(id);
        }

        public DataTable GetAll()
        {
            return _unitOfWork.OzellikDal.GetAll();
        }

        public void Update(Ozellik ozellik)
        {
            _unitOfWork.OzellikDal.Update(ozellik);
        }
    }
}
