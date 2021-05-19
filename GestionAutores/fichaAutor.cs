using System;
using Funcionalidad_Formularios;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAutores
{
    public partial class fichaAutor : Form
    {
        ObjetoAutor Autor;

        public fichaAutor(ObjetoAutor autor)
        {
            InitializeComponent();
            this.Autor = autor;
        }

        private void fichaAutor_Load(object sender, EventArgs e)
        {
            this.txtID.Text = Autor.Codigo;
            this.txtNombres.Text = Autor.Nombres;
            this.txtApellidos.Text = Autor.Apellidos;
            this.txtCiudad.Text = Autor.Apellidos;
            this.txtComentarios.Text = Autor.Comentarios;
            this.cboPais.SelectedItem = Autor.Pais;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Arrastre_Formularios.Llama_ReleaseCapture();
            Arrastre_Formularios.Llama_SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
