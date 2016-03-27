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

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            UsuarioBE usuario = new UsuarioBE() 
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Dni = txtDni.Text
            };           

            usuarioBC.InsertarUsuario(usuario);
            lvUsuario.DataBind();
        }

        public List<UsuarioBE> getAllUsuario() 
        {
            return usuarioBC.ListarUsuarios();
        }        

        protected void btnEliminar_Click(object sender, EventArgs e) 
        {
            Button btn = (Button)sender;
            if (btn.CommandName == "Eliminar")
            {
                txtNombre.Text = btn.CommandArgument;
            }
        }
    }
}