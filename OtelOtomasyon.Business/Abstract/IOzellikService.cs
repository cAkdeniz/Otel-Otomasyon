using OtelOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.Business.Abstract
{
    public interface IOzellikService
    {
        DataTable GetAll();
        void Add(Ozellik ozellik);
        void Update(Ozellik ozellik);
        void Delete(int id);
    }
}
