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
    public class OdaOzellikDal: GenericDal<OdaOzellik>, IOdaOzellikDal
    {
        private OtelOtomasyonContext _context;
        public OdaOzellikDal(OtelOtomasyonContext context) : base(context, "OdaOzellikler")
        {
            _context = context;
        }
    }
}
