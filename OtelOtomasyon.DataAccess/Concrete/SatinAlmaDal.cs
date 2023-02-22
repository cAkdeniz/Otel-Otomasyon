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
    public class SatinAlmaDal: GenericDal<SatinAlma>, ISatinAlmaDal
    {
        private OtelOtomasyonContext _context;
        public SatinAlmaDal(OtelOtomasyonContext context) : base(context, "SatinAlmalar")
        {
            _context = context;
        }
    }
}
