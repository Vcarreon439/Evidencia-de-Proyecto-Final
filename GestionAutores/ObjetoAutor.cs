using System;
using Dominio;
using System.Drawing;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAutores
{
    public class ObjetoAutor
    {
        public ObjetoAutor(List<string> recividor) 
        {
            ObtenerInfo(recividor);
        }


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

        private void ObtenerInfo(List<string> sender) 
        {
            ModeloDUsuario OBJ = new ModeloDUsuario();
            DataTable values = OBJ.MostrarAutor_5(sender);
            codigo = values.Rows[0][0].ToString();
            nombres = values.Rows[0][1].ToString();
            apellidos = values.Rows[0][2].ToString();
            pais = values.Rows[0][3].ToString();
            ciudad = values.Rows[0][4].ToString();
            comentarios = values.Rows[0][5].ToString();

            if (values.Columns[6].ToString()==null)
                Imagen = null;
            else
                Imagen = null;
        }

    }
}
