using System;
using System.Collections.Generic;
using System.Drawing;
using Dominio;
using BibliotecaDeClases;
using System.IO;
using Funcionalidad_Formularios;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Windows.Forms.VisualStyles;

namespace GestionAutores
{
    public partial class frmGestionAutores : Form
    {
        private string imgLocation;

        public frmGestionAutores()
        {
            InitializeComponent();
        }

        private void chkDesconocido_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDesconocido.Checked==true)
            {
                cboCountry.Enabled = false;
            }
            else
            {
                cboCountry.SelectedIndex = 0;
                cboCountry.Enabled = true;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            ModeloDUsuario objDUsuario = new ModeloDUsuario();

            if (objDUsuario.InsertarAutor(CrearAutor(imgLocation)))
                MessageBox.Show("El resgitro fue completado exitosamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("El resgitro no fue completado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            ActualizarData();
            Vaciar();
        }

        private void Vaciar()
        {
            pctAutor.Image = null;
            txtApellidos.Text = "";
            txtID.Text = "";
            txtCiudad.Text = "";
            txtComentarios.Text = "";
            txtNombre.Text = "";
        }

        private ObjetoAutor CrearAutor(string location)
        {
            ObjetoAutor obj = new ObjetoAutor();

            if (txtID.Text!="")
                obj.Codigo = txtID.Text;

            if (txtNombre.Text != "")
                obj.Nombres = txtNombre.Text;

            if (txtApellidos.Text != "")
                obj.Apellidos = txtApellidos.Text;

            if (chkDesconocido.CheckState == CheckState.Checked)
                obj.Pais = "Desconocido";
            else
                obj.Pais = cboCountry.Text;


            if (txtCiudad.Text != "")
                obj.Ciudad = txtCiudad.Text;

            if (txtComentarios.Text != "")
                obj.Comentarios = txtComentarios.Text;

            if (pctAutor.Image != null)
                obj.Imagen = ImagenAutor.ImageToBase64(pctAutor.Image, ImageFormat.Jpeg);
            else
                obj.Imagen = null;

            return obj;
        }

        private void ActualizarData()
        {
            try
            {
                ModeloDUsuario OBJ = new ModeloDUsuario();
                dgvAutores.DataSource = OBJ.MostrarAutores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmGestionAutores_Load(object sender, EventArgs e)
        {
            ActualizarData();
            dgvAutores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pctAutor.AllowDrop = true;
        }

        private void dgvAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                ModeloDUsuario obj = new ModeloDUsuario();
                fichaAutor forma = new fichaAutor(obj.MostrarAutor(dgvAutores.SelectedCells[0].Value.ToString()));

                switch (forma.ShowDialog())
                {
                    case DialogResult.Yes:
                        ActualizarData();
                        break;
                    
                    case DialogResult.No:
                        ActualizarData();
                        break;

                    default:
                        ActualizarData();
                        break;
                }
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Arrastre_Formularios.Llama_ReleaseCapture();
            Arrastre_Formularios.Llama_SendMessage(ParentForm.Handle, 0x112, 0xf012, 0);
        }

        private void pctAutor_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            string[] fileList = (string[]) e.Data.GetData(DataFormats.FileDrop, false);

            if (data != null)
            {
                var filename = data as string[];

                if (filename.Length > 0)
                {
                    pctAutor.Image = Image.FromFile((filename[0]));
                    imgLocation = fileList[0];
                }
            }
        }

        private void pctAutor_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pctAutor.Image = new Bitmap(open.FileName);
                imgLocation = open.FileName;
            }
        }
    }
}
