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
    public class BirimTipDal: GenericDal<BirimTip>, IBirimTipDal
    {
        private OtelOtomasyonContext _context;
        public BirimTipDal(OtelOtomasyonContext context) : base(context, "BirimTipler")
        {
            _context = context;
        }
    }
}
