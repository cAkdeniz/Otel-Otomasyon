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
    public class TedarikciDal: GenericDal<Tedarikci>, ITedarikciDal
    {
        private OtelOtomasyonContext _context;
        public TedarikciDal(OtelOtomasyonContext context) : base(context, "Tedarikciler")
        {
            _context = context;
        }
    }
}
