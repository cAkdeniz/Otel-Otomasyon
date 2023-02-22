using OtelOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.Business.Abstract
{
    public interface IUrunService
    {
        DataTable GetAll();
        void Add(Urun urun);
        void Update(Urun urun);
        void Delete(int id);
        DataTable Get(int id);
    }
}
