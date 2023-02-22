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
    public class KasaDal: GenericDal<Kasa>, IKasaDal
    {
        private OtelOtomasyonContext _context;
        public KasaDal(OtelOtomasyonContext context) : base(context, "Kasalar")
        {
            _context = context;
        }
    }
}
