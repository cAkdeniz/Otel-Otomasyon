using OtelOtomasyon.DataAccess.Abstract;
using OtelOtomasyon.DataAccess.Context.MsSqlContext;
using OtelOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.DataAccess.Concrete
{
    public class SatisDetayDal: GenericDal<SatisDetay>, ISatisDetayDal
    {
        private OtelOtomasyonContext _context;
        public SatisDetayDal(OtelOtomasyonContext context) : base(context, "SatisDetaylar")
        {
            _context = context;
        }
    }
}
