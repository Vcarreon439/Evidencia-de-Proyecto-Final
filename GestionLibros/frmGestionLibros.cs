using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
