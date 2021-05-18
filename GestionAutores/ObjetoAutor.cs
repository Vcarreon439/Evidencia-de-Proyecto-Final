using System;
using Dominio;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAutores
{
    class ObjetoAutor
    {
        private string codigo;
        private string nombres;
        private string apellidos;
        private string pais;
        private string ciudad;
        private string comentarios;
        private Bitmap imagen;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }
        public Bitmap Imagen { get => imagen; set => imagen = value; }

        private void ObtenerInfo() 
        {
            ModeloDUsuario OBJ = new ModeloDUsuario();


        
        
        }

    }
}
