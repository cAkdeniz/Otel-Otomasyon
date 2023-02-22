using OtelOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.Business.Abstract
{
    public interface IKasaHareketService
    {
        DataTable GetAll();
        void Add(KasaHareket kasaHareket);
        void Update(KasaHareket kasaHareket);
        void Delete(int id);
    }
}
