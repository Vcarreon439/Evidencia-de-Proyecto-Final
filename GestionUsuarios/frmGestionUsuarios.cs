using System;
using Funcionalidad_Formularios;
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

namespace GestionUsuarios
{
    public partial class frmGestionUsuarios : Form
    {
        public frmGestionUsuarios()
        {
            InitializeComponent();
            pctUsuario.AllowDrop = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Arrastre_Formularios.Llama_ReleaseCapture();
            Arrastre_Formularios.Llama_SendMessage(ParentForm.Handle, 0x112, 0xf012, 0);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Vaciar();
        }

        private void Vaciar() 
        {
            cURPTextBox.Text = "";
            entidadComboBox.Text = "";
            nombreTextBox.Text = "";
            apellidosTextBox.Text = "";
            nacimientoDateTimePicker.Value = DateTime.Now;
            domicilioTextBox.Text = "";
            pctUsuario.Image = null;
        }

        private string imgLocation;

        private void pctUsuario_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (data != null)
            {
                var filename = data as string[];

                if (filename.Length > 0)
                {
                    pctUsuario.Image = Image.FromFile((filename[0]));
                    imgLocation = fileList[0];
                }
            }
        }

        private void pctUsuario_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnAddFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pctUsuario.Image = new Bitmap(open.FileName);
                imgLocation = open.FileName;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            ModeloDUsuario Obj = new ModeloDUsuario();

            if (Obj.InsertarMiembro(crearMiembro()))
                MessageBox.Show($"Se ha ingresado al miembro {nombreTextBox.Text} correctamente", "Registro Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private ObjetoMiembro crearMiembro()
        {
            ObjetoMiembro miembro = new ObjetoMiembro();
            miembro.CURP = cURPTextBox.Text;
            miembro.Nombres = nombreTextBox.Text;
            miembro.Apellidos = apellidosTextBox.Text;
            miembro.Entidad = entidadComboBox.SelectedItem.ToString();
            miembro.Sexo = cboSexo.SelectedIndex.ToString();
            miembro.Domicilio = domicilioTextBox.Text;

            if (pctUsuario.Image != null)
                miembro.Imagen = ImagenAutor.ImageToBase64(pctUsuario.Image, ImageFormat.Jpeg);
            else
                miembro.Imagen = null;

            if (nacimientoDateTimePicker.Value == DateTime.Today)
                MessageBox.Show("Atencion!", "Por favor seleccione una fecha");
            else
            {
                DateTime fechaNac = nacimientoDateTimePicker.Value;
                string fecha = ($"{fechaNac.Month.ToString()}-{fechaNac.Day.ToString()}-{fechaNac.Year.ToString()}");
                miembro.FechaNac = fecha;
            }


            return miembro;
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}

