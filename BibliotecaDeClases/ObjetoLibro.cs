using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class ObjetoLibro
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Editorial { get; set; }
        public string Autor { get; set; }
        public string Año { get; set; }
        public string Lugar { get; set; }
        public int Numero { get; set; }
        public string Tema { get; set; }
        public int Copias { get; set; }
        public bool Disponibilidad { get; set; }
        public int Circulacion { get; set; }
        public string Imagen { get; set; }
    }
}
