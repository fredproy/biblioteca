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
        SqlConnection cnx;

        public UsuarioDAL() {
            cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConexion"].ConnectionString);
        }

        public List<UsuarioBE> ListarUsuarios()
        {
            cnx.Open();
            var lista = new List<UsuarioBE>();
            var sql = "Select IdUsuario, Nombre, Apellido, Direccion, Telefono, Dni From USUARIO";
            SqlCommand cmd = new SqlCommand(sql, cnx);

            

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
	        {
                while(reader.Read()){
                    lista.Add(new UsuarioBE(reader.GetInt32(0),reader.GetString(1),reader.GetString(2),reader.GetString(3),reader.GetString(4),reader.GetString(5)));
                }
	        }else{
                Console.WriteLine("No has registros");
            }

            reader.Close();
            return lista;
        }

        public void InsertarUsuario(UsuarioBE usuario)
        {
            cnx.Open();
            var sql = "Insert Into USUARIO(Nombre, Apellido, Direccion, Telefono, Dni) VALUES('"+usuario.Nombre+"','"+usuario.Apellido+"','"+usuario.Direccion+"','"+usuario.Telefono+"','"+usuario.Dni+"')";
            var cmd = new SqlCommand(sql, cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        public void EliminarUsuario(int id)
        {
            cnx.Open();
            var sql = "Delete From USUARIO Where IdUsuario=" + id;
            var cmd = new SqlCommand(sql,cnx);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            cnx.Close();
        }
    }
}
