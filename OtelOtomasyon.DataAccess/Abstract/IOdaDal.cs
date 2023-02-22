using OtelOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.DataAccess.Abstract
{
    public interface IOdaDal: IGenericDal<Oda>
    {
        DataTable GetWithOzellikler();
        DataTable GetWithOzelliklerByWithId(int id);
    }
}
