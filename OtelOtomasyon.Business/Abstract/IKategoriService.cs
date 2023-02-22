using OtelOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.Business.Abstract
{
    public interface IKategoriService
    {
        DataTable GetAll();
        void Add(Kategori kategori);
        void Update(Kategori kategori);
        void Delete(int id);
    }
}
