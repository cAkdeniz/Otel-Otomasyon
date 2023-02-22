using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.DataAccess.Context.MsSqlContext
{
    public class OtelOtomasyonContext
    {
        public SqlConnection ConnectionString { get; set; }

        public OtelOtomasyonContext()
        {
            var connectionString = "Server=.\\sqlexpress; database=OtelOtomasyonDB; User Id=sa; Password=123";
            ConnectionString = new SqlConnection(connectionString);
        }
    }
}
