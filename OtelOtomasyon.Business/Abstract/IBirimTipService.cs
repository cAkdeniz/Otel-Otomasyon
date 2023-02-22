using OtelOtomasyon.DataAccess.Abstract;
using OtelOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.Business.Abstract
{
    public interface IBirimTipService
    {
        DataTable GetAll();
        void Add(BirimTip birimTip);
        void Update(BirimTip birimTip);
        void Delete(int id);
    }
}
