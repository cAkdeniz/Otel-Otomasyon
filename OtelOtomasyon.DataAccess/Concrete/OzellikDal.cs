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
    public class OzellikDal: GenericDal<Ozellik>, IOzellikDal
    {
        private OtelOtomasyonContext _context;
        public OzellikDal(OtelOtomasyonContext context) : base(context, "Ozellikler")
        {
            _context = context;
        }
    }
}
