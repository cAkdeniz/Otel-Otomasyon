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
    public class PersonelManager: IPersonelService
    {
        private OtelOtomasyonUnitOfWork _unitOfWork;
        public PersonelManager(OtelOtomasyonUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Personel personel)
        {
            _unitOfWork.PersonelDal.Add(personel);
        }

        public void Delete(int id)
        {
            _unitOfWork.PersonelDal.Delete(id);
        }

        public DataTable GetAll()
        {
            return _unitOfWork.PersonelDal.GetAll();
        }

        public void Update(Personel personel)
        {
            _unitOfWork.PersonelDal.Update(personel);
        }
    }
}
