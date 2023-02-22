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
    public class KategoriManager : IKategoriService
    {
        private OtelOtomasyonUnitOfWork _unitOfWork;
        public KategoriManager(OtelOtomasyonUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Kategori kategori)
        {
            _unitOfWork.KategoriDal.Add(kategori);
        }

        public void Delete(int id)
        {
            _unitOfWork.KategoriDal.Delete(id);
        }

        public DataTable GetAll()
        {
            return _unitOfWork.KategoriDal.GetAll();
        }

        public void Update(Kategori kategori)
        {
            _unitOfWork.KategoriDal.Update(kategori);
        }
    }
}
