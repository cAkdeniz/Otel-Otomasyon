using OtelOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.Business.Abstract
{
    public interface IOdaOzellikService
    {
        DataTable GetAll();
        void Add(OdaOzellik odaOzellik);
        void Update(OdaOzellik odaOzellik);
        void Delete(int id);
    }
}
