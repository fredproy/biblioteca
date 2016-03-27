using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BE
{

    public class LibroBE
    {

        public LibroBE() { }

        public LibroBE(int IdLibro, String Titulo, String Autor, String Editorial,  DateTime Anho)
        {
            this.IdLibro = IdLibro;
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.Editorial = Editorial;
            this.Anho = Anho;

        }

        public LibroBE(String Titulo, String Autor, String Editorial, DateTime Anho)
        {
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.Editorial = Editorial;
            this.Anho = Anho;
        }
             
            public int IdLibro { get; set; }
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public string Editorial { get; set; }
            public DateTime Anho { get; set; }
       }
}
