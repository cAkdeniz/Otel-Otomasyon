using OtelOtomasyon.DataAccess.Abstract;
using OtelOtomasyon.DataAccess.Context.MsSqlContext;
using OtelOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.DataAccess.Concrete
{
    public class OdaDal: GenericDal<Oda>, IOdaDal
    {
        private OtelOtomasyonContext _context;
        public OdaDal(OtelOtomasyonContext context) : base(context, "Odalar")
        {
            _context = context;
        }

        public DataTable GetWithOzellikler()
        {
            _context.ConnectionString.Open();

            DataTable dt = new DataTable();
            string command = $"SELECT O.Adi AS ADI,OT.Adi AS TUR,OZ.Adi AS OZELLIK,OO.Deger AS DEGER FROM Odalar O "+
                            "INNER JOIN OdaOzellikler OO ON OO.OdaId = O.Id "+
                            "INNER JOIN Ozellikler OZ ON OZ.Id = OO.OzellikId "+
                            "INNER JOIN OdaTurler OT ON OT.Id = O.OdaTurId ";
            SqlDataAdapter da = new SqlDataAdapter(command, _context.ConnectionString);
            da.Fill(dt);

            _context.ConnectionString.Close();

            return dt;
        }

        public DataTable GetWithOzelliklerByWithId(int id)
        {
            _context.ConnectionString.Open();

            DataTable dt = new DataTable();
            string command = $"SELECT O.Adi AS ADI,OT.Adi AS TUR,OZ.Adi AS OZELLIK,OO.Deger AS DEGER FROM Odalar O " +
                            "INNER JOIN OdaOzellikler OO ON OO.OdaId = O.Id " +
                            "INNER JOIN Ozellikler OZ ON OZ.Id = OO.OzellikId " +
                            "INNER JOIN OdaTurler OT ON OT.Id = O.OdaTurId " +
                            $"WHERE O.Id = {id}";
            SqlDataAdapter da = new SqlDataAdapter(command, _context.ConnectionString);
            da.Fill(dt);

            _context.ConnectionString.Close();

            return dt;
        }
    }
}
