using System;
using System.Drawing;
using System.Data;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAutores
{
    public class ObjetoAutor
    {
        public ObjetoAutor()
        {


        }

        private string codigo;
        private string nombres;
        private string apellidos;
        private string pais;
        private string ciudad;
        private string comentarios;
        private string imagen;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }
        public string Imagen { get => imagen; set => imagen = value; }
    }
}
