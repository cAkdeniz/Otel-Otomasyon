using OtelOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.Business.Abstract
{
    public interface IOdaTurService
    {
        DataTable GetAll();
        void Add(OdaTur odaTur);
        void Update(OdaTur odaTur);
        void Delete(int id);
    }
}
