using OtelOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.Business.Abstract
{
    public interface ISatinAlmaService
    {
        DataTable GetAll();
        void Add(SatinAlma satinAlma);
        void Update(SatinAlma satinAlma);
        void Delete(int id);
    }
}
