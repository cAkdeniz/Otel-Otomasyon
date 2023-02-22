using OtelOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.Business.Abstract
{
    public interface ITedarikciService
    {
        DataTable GetAll();
        void Add(Tedarikci tedarikci);
        void Update(Tedarikci tedarikci);
        void Delete(int id);
    }
}
