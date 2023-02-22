using OtelOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.Business.Abstract
{
    public interface ISatisDetayService
    {
        DataTable GetAll();
        void Add(SatisDetay satisDetay);
        void Update(SatisDetay satisDetay);
        void Delete(int id);
    }
}
