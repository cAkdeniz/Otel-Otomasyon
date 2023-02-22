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
    public class KasaHareketDal: GenericDal<KasaHareket>, IKasaHareketDal
    {
        private OtelOtomasyonContext _context;
        public KasaHareketDal(OtelOtomasyonContext context) : base(context, "KasaHareketler")
        {
            _context = context;
        }
    }
}
