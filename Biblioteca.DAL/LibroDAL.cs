using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Biblioteca.BE;

namespace Biblioteca.DAL
{
    public class LibroDAL
    {
        SqlConnection cnx;

        public LibroDAL()
        {
            cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConexion"].ConnectionString);
        }

        public List<LibroBE> ListarLibros()
        {
            cnx.Open();
            var lista = new List<LibroBE>();
            var sql = "Select IdLibro, Titulo, Autor, Editorial, Anho From LIBRO";
            SqlCommand cmd = new SqlCommand(sql, cnx);



            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lista.Add(new LibroBE(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4)));
                }
            }
            else
            {
                Console.WriteLine("No has registros");
            }

            reader.Close();
            return lista;
        }

        public void InsertarLibro(LibroBE libro)
        {
            cnx.Open();
            var sql = "Insert Into LIBRO(Titulo, Autor, Editorial, Anho) VALUES('" + libro.Titulo + "','" + libro.Autor + "','" + libro.Editorial + "','" + libro.Anho + "')";
            var cmd = new SqlCommand(sql, cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
    }
}