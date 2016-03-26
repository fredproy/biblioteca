using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca.BE;
using Biblioteca.BC;

namespace Biblioteca.Web
{
    public partial class Usuario : System.Web.UI.Page
    {
        UsuarioBC usuarioBC = new UsuarioBC();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public List<UsuarioBE> getAllUsuario() 
        {
            return usuarioBC.ListarUsuarios();
        }
    }
}