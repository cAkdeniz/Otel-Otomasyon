using OtelOtomasyon.DataAccess.Abstract;
using OtelOtomasyon.DataAccess.Context.MsSqlContext;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.DataAccess.Concrete
{
    public class GenericDal<TEntity> : IGenericDal<TEntity> where TEntity : class, new()
    {
        private OtelOtomasyonContext _context;
        private string _paramName;
        public GenericDal(OtelOtomasyonContext context, string paramName)
        {
            _context = context;
            _paramName = paramName;
        }

        public void Add(TEntity entity)
        {
            _context.ConnectionString.Open();
            string command = $"Insert Into {_paramName} (";
            PropertyInfo[] properties = typeof(TEntity).GetProperties();

            for (int i = 1; i < properties.Length+1; i++)
            {
                if (properties[i - 1].Name == "Id")
                {
                    continue;
                }
                else
                {
                    command += properties[i-1].Name;
                    if (i == properties.Length)
                    {
                        break;
                    }
                }
                command += ",";
            }
            command += ") VALUES(";

            for (int i = 1; i < properties.Length + 1; i++)
            {
                if (properties[i - 1].Name == "Id")
                {
                    continue;
                }
                else
                {
                    command += "@p" + i;
                    if (i == properties.Length)
                    {
                        break;
                    }
                }
                command += ",";
            }
            command += ")";
            
            SqlCommand sqlCommand = new SqlCommand(command, _context.ConnectionString);

            for (int i = 1; i < properties.Length+1; i++)
            {
                if (properties[i-1].Name == "Id")
                {
                    continue;
                }
                if(properties[i - 1].GetValue(entity) == null)
                {
                    sqlCommand.Parameters.AddWithValue("@p" + i, "");
                }
                else
                {
                    sqlCommand.Parameters.AddWithValue("@p" + i, properties[i-1].GetValue(entity));
                }
            }

            sqlCommand.ExecuteNonQuery();

            _context.ConnectionString.Close();
        }

        public void Delete(int id)
        {
            _context.ConnectionString.Open();

            string command = $"Delete from {_paramName} where Id = {id}";
            SqlCommand sqlCommand = new SqlCommand(command, _context.ConnectionString);
            sqlCommand.ExecuteNonQuery();

            _context.ConnectionString.Close();
        }

        public void Update(TEntity entity)
        {
            _context.ConnectionString.Open();

            string command = $"Update {_paramName} Set ";
            PropertyInfo[] properties = typeof(TEntity).GetProperties();

            for (int i = 1; i < properties.Length+1; i++)
            {
                if (properties[i - 1].Name == "Id")
                {
                    continue;
                }
                else
                {
                    command += $"{properties[i-1].Name}='" + properties[i-1].GetValue(entity) +"'";
                    if (i == properties.Length)
                    {
                        break;
                    }
                    command += ", ";
                }
            }

            for (int i = 1; i < properties.Length + 1; i++)
            {
                if (properties[i - 1].Name == "Id")
                {
                    command += " Where Id=" + properties[i - 1].GetValue(entity);
                    break;
                }
            }

            SqlCommand sqlCommand = new SqlCommand(command, _context.ConnectionString);
            sqlCommand.ExecuteNonQuery();

            _context.ConnectionString.Close();
        }

        public DataTable GetAll()
        {
            _context.ConnectionString.Open();

            DataTable dt = new DataTable();
            string command = $"Select * from {_paramName}";
            SqlDataAdapter da = new SqlDataAdapter(command, _context.ConnectionString);
            da.Fill(dt);

            _context.ConnectionString.Close();

            return dt;
        }

        public DataTable Get(int id)
        {
            _context.ConnectionString.Open();

            DataTable dt = new DataTable();
            string command = $"Select * from {_paramName} where Id = {id}";
            SqlDataAdapter da = new SqlDataAdapter(command, _context.ConnectionString);
            da.Fill(dt);

            _context.ConnectionString.Close();

            return dt;
        }
    }
}
