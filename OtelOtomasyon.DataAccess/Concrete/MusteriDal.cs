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
    public class MusteriDal: GenericDal<Musteri>, IMusteriDal
    {
        private OtelOtomasyonContext _context;
        public MusteriDal(OtelOtomasyonContext context) : base(context, "Musteriler")
        {
            _context = context;
        }
    }
}
