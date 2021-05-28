using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;
using Dominio;
using Funcionalidad_Formularios;

namespace GestionLibros
{
    public partial class frmGestionLibros : Form
    {
        public frmGestionLibros()
        {
            InitializeComponent();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Arrastre_Formularios.Llama_ReleaseCapture();
            Arrastre_Formularios.Llama_SendMessage(ParentForm.Handle, 0x112, 0xf012, 0);
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmGestionLibros_Load(object sender, EventArgs e)
        {
            FillData();

            pctImgLibro.AllowDrop = true;

            ModeloDUsuario model = new ModeloDUsuario();

            foreach (var VARIABLE in model.TemaCombo())
                cboTema.Items.Add(VARIABLE);

            foreach (var VARIABLE in model.EditorialesCombo())
                cboEditorial.Items.Add(VARIABLE);

        }

        private void cboTema_Enter(object sender, EventArgs e)
        {
            cboTema.Items.Clear();

            ModeloDUsuario model = new ModeloDUsuario();

            foreach (var VARIABLE in model.TemaCombo())
                cboTema.Items.Add(VARIABLE);
        }

        private void cboEditorial_Enter(object sender, EventArgs e)
        {
            cboEditorial.Items.Clear();

            ModeloDUsuario model = new ModeloDUsuario();

            foreach (var VARIABLE in model.EditorialesCombo())
                cboEditorial.Items.Add(VARIABLE);
        }


        private string imgLocation;
        private void pctImgLibro_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (data != null)
            {
                var filename = data as string[];

                if (filename.Length > 0)
                {
                    pctImgLibro.Image = Image.FromFile((filename[0]));
                    imgLocation = fileList[0];
                }
            }
        }

        private void pctImgLibro_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pctImgLibro.Image = new Bitmap(open.FileName);
                imgLocation = open.FileName;
            }
        }

        private void FillData()
        {
            try
            {
                ModeloDUsuario Obj = new ModeloDUsuario();
                dgvLibros.DataSource = Obj.MostrarLibros();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloDUsuario Obj = new ModeloDUsuario();
                ObjetoLibro libro = CrearLibro();

                if (Comprobar())
                    if (Obj.InsertarLibro(libro))
                        MessageBox.Show($"Se inserto el libro {libro.Titulo}", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show($"No se pudo insertar el libro {libro.Titulo}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                VaciarCampos();
                FillData();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        }

        private bool Comprobar()
        {
            if (txtTitulo.Text == "")
            {
                MessageBox.Show("El campo titulo no puede ir vacio");
                return false;
            }
            return true;
        }

        private void VaciarCampos()
        {
            txtTitulo.Text = "";
            cboEditorial.Text = "";
            txtISBN.Text = "";
            txtAño.Text = "";
            numCopias.Value = 1;
            cboTema.Text = "";
            numEdicion.Value = 1;
            txtCodAutor.Text = "";
            txtLugar.Text = "";
            pctImgLibro.Image = null;
        }

        private ObjetoLibro CrearLibro()
        {
            ObjetoLibro libro = new ObjetoLibro();
            libro.Titulo = txtTitulo.Text;
            libro.ISBN = txtISBN.Text;
            libro.Editorial = cboEditorial.Text;
            libro.Año = txtAño.Text;
            libro.Copias = Convert.ToInt16(numCopias.Value);
            libro.Numero = Convert.ToInt16(numEdicion.Value);
            libro.Tema = cboTema.Text;
            libro.Autor = txtCodAutor.Text;
            libro.Lugar = txtLugar.Text;

            if (pctImgLibro.Image!=null)
                libro.Imagen = ImagenAutor.ImageToBase64(pctImgLibro.Image, ImageFormat.Jpeg);
            else
                libro.Imagen = "";


            return libro;
        }
    }
}
