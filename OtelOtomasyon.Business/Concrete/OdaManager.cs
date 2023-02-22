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
    public class OdaManager: IOdaService
    {
        private OtelOtomasyonUnitOfWork _unitOfWork;
        public OdaManager(OtelOtomasyonUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Oda oda)
        {
            _unitOfWork.OdaDal.Add(oda);
        }

        public void Delete(int id)
        {
            _unitOfWork.OdaDal.Delete(id);
        }

        public DataTable GetAll()
        {
            return _unitOfWork.OdaDal.GetAll();
        }

        public DataTable GetWithOzellikler()
        {
            return _unitOfWork.OdaDal.GetWithOzellikler();
        }

        public DataTable GetWithOzelliklerByWithId(int id)
        {
            return _unitOfWork.OdaDal.GetWithOzelliklerByWithId(id);
        }

        public void Update(Oda oda)
        {
            _unitOfWork.OdaDal.Update(oda);
        }
    }
}
