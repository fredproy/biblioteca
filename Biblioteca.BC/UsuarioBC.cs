using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.BE;
using Biblioteca.DAL;

namespace Biblioteca.BC
{
    public class UsuarioBC
    {
        UsuarioDAL usuarioDAL = new UsuarioDAL();

        public List<UsuarioBE> ListarUsuarios()
        {
            return usuarioDAL.ListarUsuarios();
        }
    }
}
