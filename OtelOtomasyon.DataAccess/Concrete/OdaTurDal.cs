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
    public class OdaTurDal : GenericDal<OdaTur>, IOdaTurDal
    {
        private OtelOtomasyonContext _context;
        public OdaTurDal(OtelOtomasyonContext context) : base(context, "OdaTurler")
        {
            _context = context;
        }
    }
}
