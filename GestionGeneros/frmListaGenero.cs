using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using  Funcionalidad_Formularios;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace GestionGeneros
{
    public partial class frmListaGenero : Form
    {
        public frmListaGenero()
        {
            InitializeComponent();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            FillData();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarCant(Convert.ToInt32(numUpDnCantidad.Value));
        }

        private void MostrarCant(int cant)
        {
            try
            {
                ModeloDUsuario OBJ = new ModeloDUsuario();
                dgvGenero.DataSource = OBJ.MostrarGenerosCant(cant);
                dgvGenero.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillData()
        {
            try
            {
                ModeloDUsuario OBJ = new ModeloDUsuario();
                dgvGenero.DataSource = OBJ.MostrarGeneros();
                dgvGenero.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Arrastre_Formularios.Llama_ReleaseCapture();
            Arrastre_Formularios.Llama_SendMessage(ParentForm.Handle, 0x112, 0xf012, 0);
        }



    }
}
