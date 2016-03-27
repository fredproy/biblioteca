using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca.BC;
using Biblioteca.BE;

namespace Biblioteca.Web
{
    public partial class Libro : System.Web.UI.Page
    {
        LibroBC libroBC = new LibroBC();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            LibroBE libro = new LibroBE() 
            {
                Titulo = txtTitulo.Text,
                Autor = txtAutor.Text,
                Editorial = txtEditorial.Text,
                Anho = DateTime.Parse(txtAnho.Text)
            };

            libroBC.InsertaLibro(libro);
            lvLibro.DataBind();
        }

        public List<LibroBE> getAllLibro()
        {
            return libroBC.ListarLibros();
        }
    }
}