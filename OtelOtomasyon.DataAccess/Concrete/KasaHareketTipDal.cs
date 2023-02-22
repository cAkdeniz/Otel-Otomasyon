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
    public class KasaHareketTipDal: GenericDal<KasaHareketTip>, IKasaHareketTipDal
    {
        private OtelOtomasyonContext _context;
        public KasaHareketTipDal(OtelOtomasyonContext context) : base(context, "KasaHareketTipler")
        {
            _context = context;
        }
    }
}
