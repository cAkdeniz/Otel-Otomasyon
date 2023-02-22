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
    public class SatinAlmaDetayDal: GenericDal<SatinAlmaDetay>, ISatinAlmaDetayDal
    {
        private OtelOtomasyonContext _context;
        public SatinAlmaDetayDal(OtelOtomasyonContext context) : base(context, "SatinAlmaDetaylar")
        {
            _context = context;
        }
    }
}
