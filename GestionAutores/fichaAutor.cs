using System;
using Funcionalidad_Formularios;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;
using Dominio;

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

        private void FichaAutor_Load(object sender, EventArgs e)
        {
            LoadAutor();
            pictureBox1.AllowDrop = true;
        }

        private void LoadAutor(ObjetoAutor autor)
        {
            Autor = autor;
            LoadAutor();
        }

        private void LoadAutor()
        {
            this.txtID.Text = Autor.Codigo;
            this.txtNombres.Text = Autor.Nombres;
            this.txtApellidos.Text = Autor.Apellidos;
            this.txtCiudad.Text = Autor.Ciudad;
            this.txtComentarios.Text = Autor.Comentarios;

            char[] separadores = { '[', ']', ',' };
            string pais = Autor.Pais.Split(separadores)[1];

            this.cboPais.SelectedRegion = new RegionInfo(pais);

            this.pictureBox1.Image = ImagenAutor.Base64ToImage(Autor.Imagen);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Arrastre_Formularios.Llama_ReleaseCapture();
            Arrastre_Formularios.Llama_SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ModeloDUsuario obj = new ModeloDUsuario();
            ObjetoAutor autorinterno = CrearAutor();
            obj.ActualizarAutor(autorinterno);
            LoadAutor(autorinterno);

            this.DialogResult = DialogResult.Yes;

            this.Close();
        }

        private ObjetoAutor CrearAutor()
        {
            ObjetoAutor autor = new ObjetoAutor();
            autor.Codigo = txtID.Text;
            autor.Nombres = txtNombres.Text;
            autor.Apellidos = txtApellidos.Text;
            autor.Pais = cboPais.Text;
            autor.Ciudad = txtCiudad.Text;
            autor.Comentarios = txtComentarios.Text;
            autor.Imagen = ImagenAutor.ImageToBase64(pictureBox1.Image, ImageFormat.Jpeg);

            return autor;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ModeloDUsuario OBJ = new ModeloDUsuario();
            ObjetoAutor temp = CrearAutor();

            if (OBJ.EliminarAutor(temp))
            {
                MessageBox.Show($"El autor {temp.Nombres} ha sido eliminado correctamente","Cambio Realizado",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.No;
                this.Close();
            }
            else
                MessageBox.Show($"El autor {temp.Nombres} no ha podido ser eliminado", "Cambio Invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            
        }

        private string imgLocation;
        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (data != null)
            {
                var filename = data as string[];

                if (filename.Length > 0)
                {
                    pictureBox1.Image = Image.FromFile((filename[0]));
                    imgLocation = fileList[0];
                }
            }
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
