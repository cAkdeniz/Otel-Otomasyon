using OtelOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.Business.Abstract
{
    public interface IOdaService
    {
        DataTable GetAll();
        void Add(Oda oda);
        void Update(Oda oda);
        void Delete(int id);
        DataTable GetWithOzellikler();
        DataTable GetWithOzelliklerByWithId(int id);
    }
}
