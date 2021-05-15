using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Funcionalidad_Formularios;
using System.Windows.Forms;

namespace GestionGeneros
{
    public partial class frmGestionarGeneros : Form
    {
        public frmGestionarGeneros()
        {
            InitializeComponent();
        }

        private void pnlContenedor_MouseMove(object sender, MouseEventArgs e)
        {
            Arrastre_Formularios.Llama_ReleaseCapture();
            Arrastre_Formularios.Llama_SendMessage(ParentForm.Handle, 0x112, 0xf012, 0);
        }
    }
}
