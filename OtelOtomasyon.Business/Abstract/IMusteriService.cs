using OtelOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.Business.Abstract
{
    public interface IMusteriService
    {
        DataTable GetAll();
        void Add(Musteri musteri);
        void Update(Musteri musteri);
        void Delete(int id);
    }
}
