using OtelOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.Business.Abstract
{
    public interface ISatisService
    {
        DataTable GetAll();
        void Add(Satis satis);
        void Update(Satis satis);
        void Delete(int id);
    }
}
