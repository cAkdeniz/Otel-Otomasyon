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
    public class KategoriDal: GenericDal<Kategori>, IKategoriDal
    {
        private OtelOtomasyonContext _context;
        public KategoriDal(OtelOtomasyonContext context) : base(context, "Kategoriler")
        {
            _context = context;
        }
    }
}
