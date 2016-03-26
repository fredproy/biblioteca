using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

//agrego referencias
using System.Data.SqlClient;
using System.Configuration;
using Biblioteca.BE;

namespace Biblioteca.DAL
{
    public class UsuarioDAL
    {      

        public UsuarioDAL() {            
            
        }

        public List<UsuarioBE> ListarUsuarios()
        {
            var lista = new List<UsuarioBE>();
            var cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConexion"].ConnectionString);
            var sql = "Select IdUsuario, Nombre, Apellido, Direccion, Telefono, Dni From USUARIO";
            SqlCommand cmd = new SqlCommand(sql);

            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read()){
                lista.Add(reader.GetString(0),reader.GetString(1),reader.GetString(2),reader.GetString(3),);
            }


            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();

            return lista;
        }

        public Boolean InsertarUsuario(UsuarioBE usuario)
        {
            Boolean bandera = true;
            var cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConexion"].ConnectionString);
            var sql = "Insert Into Usuario(Nombre, Apellido, Direccion, Telefono) VALUES("+usuario.Nombre+","+usuario.Apellido+","+usuario.Direccion+","+usuario.Telefono+")";
            var cmd = new SqlCommand(sql, cnx);
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
            return bandera;
        }
    }
}
