using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BE
{
    public class UsuarioBE
    {

        public UsuarioBE(int IdUsuario,String Nombre,String Apellido, String Direccion, String Telefono, String Dni) {
            this.IdUsuario = IdUsuario;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.Dni = Dni;
        }

        public UsuarioBE( String Nombre, String Apellido, String Direccion, String Telefono, String Dni)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.Dni = Dni;
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Dni { get; set; }
    }
}
