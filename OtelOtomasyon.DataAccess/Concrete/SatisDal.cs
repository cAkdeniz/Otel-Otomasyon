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
    public class SatisDal: GenericDal<Satis>, ISatisDal
    {
        private OtelOtomasyonContext _context;
        public SatisDal(OtelOtomasyonContext context) : base(context, "Satislar")
        {
            _context = context;
        }
    }
}
