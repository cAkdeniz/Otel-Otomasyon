using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.DataAccess.Abstract
{
    public interface IGenericDal<TEntity> where TEntity: class, new()
    {
        DataTable GetAll();
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
        DataTable Get(int id);
    }
}
