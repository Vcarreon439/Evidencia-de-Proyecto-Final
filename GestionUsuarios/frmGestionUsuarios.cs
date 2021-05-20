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

namespace GestionUsuarios
{
    public partial class frmGestionUsuarios : Form
    {
        public frmGestionUsuarios()
        {
            InitializeComponent();
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
    }
}
