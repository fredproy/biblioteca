using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Biblioteca.DAL
{
    public class Conexion
    {
        public SqlConnection cnx;
        public SqlCommand cmd;
        public SqlDataReader rs;

        public Conexion()
        { 
        }

        public string GetConex() 
        {
            string cnx = ConfigurationManager.ConnectionStrings["DbConexion"].ConnectionString;
            if (Object.ReferenceEquals(cnx, String.Empty))
            {
                return string.Empty;
            }
            else 
            {
                return cnx;
            }
        }
    }
}
