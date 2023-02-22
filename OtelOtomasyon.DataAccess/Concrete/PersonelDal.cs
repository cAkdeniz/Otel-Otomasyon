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
    public class PersonelDal: GenericDal<Personel>, IPersonelDal
    {
        private OtelOtomasyonContext _context;
        public PersonelDal(OtelOtomasyonContext context) : base(context, "Personeller")
        {
            _context = context;
        }
    }
}
