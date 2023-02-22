using OtelOtomasyon.DataAccess.Abstract;
using OtelOtomasyon.DataAccess.Context.MsSqlContext;
using OtelOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.DataAccess.Concrete
{
    public class UrunDal: GenericDal<Urun>, IUrunDal
    {
        private OtelOtomasyonContext _context;
        public UrunDal(OtelOtomasyonContext context): base(context, "Urunler")
        {
            _context = context;
        }
    }
}
