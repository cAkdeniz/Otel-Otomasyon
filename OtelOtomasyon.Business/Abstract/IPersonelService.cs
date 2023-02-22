using OtelOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.Business.Abstract
{
    public interface IPersonelService
    {
        DataTable GetAll();
        void Add(Personel personel);
        void Update(Personel personel);
        void Delete(int id);
    }
}
