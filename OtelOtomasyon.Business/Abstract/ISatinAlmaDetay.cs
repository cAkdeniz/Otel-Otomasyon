using OtelOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.Business.Abstract
{
    public interface ISatinAlmaDetay
    {
        DataTable GetAll();
        void Add(SatinAlmaDetay satinAlmaDetay);
        void Update(SatinAlmaDetay satinAlmaDetay);
        void Delete(int id);
    }
}
