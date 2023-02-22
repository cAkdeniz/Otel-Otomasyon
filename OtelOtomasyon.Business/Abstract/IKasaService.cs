using OtelOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.Business.Abstract
{
    public interface IKasaService
    {
        DataTable GetAll();
        void Add(Kasa kasa);
        void Update(Kasa kasa);
        void Delete(int id);
    }
}
