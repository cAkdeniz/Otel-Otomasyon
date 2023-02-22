using OtelOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.Business.Abstract
{
    public interface IKasaHareketTipService
    {
        DataTable GetAll();
        void Add(KasaHareketTip kasaHareketTip);
        void Update(KasaHareketTip kasaHareketTip);
        void Delete(int id);
    }
}
