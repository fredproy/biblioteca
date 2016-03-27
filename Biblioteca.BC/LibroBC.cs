using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.BE;
using Biblioteca.DAL;

namespace Biblioteca.BC
{
    public class LibroBC
    {
        LibroDAL libroDAL = new LibroDAL();

        public List<LibroBE> ListarLibros()
        {
            return libroDAL.ListarLibros();
        }

        public void InsertaLibro(LibroBE libro)
        {
            libroDAL.InsertarLibro(libro);
        }
    }
}
