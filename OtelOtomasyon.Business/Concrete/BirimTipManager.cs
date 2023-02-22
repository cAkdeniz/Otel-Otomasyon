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
    public class BirimTipManager: IBirimTipService
    {
        private OtelOtomasyonUnitOfWork _unitOfWork;
        public BirimTipManager(OtelOtomasyonUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(BirimTip birimTip)
        {
            _unitOfWork.BirimTipDal.Add(birimTip);
        }

        public void Delete(int id)
        {
            _unitOfWork.BirimTipDal.Delete(id);
        }

        public DataTable GetAll()
        {
            return _unitOfWork.BirimTipDal.GetAll();
        }

        public void Update(BirimTip birimTip)
        {
            _unitOfWork.BirimTipDal.Update(birimTip);
        }
    }
}
