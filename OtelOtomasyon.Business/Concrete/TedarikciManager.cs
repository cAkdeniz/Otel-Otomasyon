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
    public class TedarikciManager : ITedarikciService
    {
        private OtelOtomasyonUnitOfWork _unitOfWork;
        public TedarikciManager(OtelOtomasyonUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Tedarikci tedarikci)
        {
            _unitOfWork.TedarikciDal.Add(tedarikci);
        }

        public void Delete(int id)
        {
            _unitOfWork.TedarikciDal.Delete(id);
        }

        public DataTable GetAll()
        {
            return _unitOfWork.TedarikciDal.GetAll();
        }

        public void Update(Tedarikci tedarikci)
        {
            _unitOfWork.TedarikciDal.Update(tedarikci);
        }
    }
}
