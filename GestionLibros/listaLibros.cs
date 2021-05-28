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
    public partial class listaLibros : Form
    {
        public listaLibros()
        {
            InitializeComponent();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Arrastre_Formularios.Llama_ReleaseCapture();
            Arrastre_Formularios.Llama_SendMessage(ParentForm.Handle, 0x112, 0xf012, 0);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            FillData();
        }

        private void FillDataCant(int cantidad)
        {
            try
            {
                ModeloDUsuario Obj = new ModeloDUsuario();
                dgvLibros.DataSource = Obj.MostrarLibrosCant(cantidad);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
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
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            FillDataCant(Convert.ToInt16(numUpDnCantidad.Value));
        }
    }
}
