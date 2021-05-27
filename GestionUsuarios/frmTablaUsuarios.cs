using System;
using Dominio;
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
    public partial class frmTablaUsuarios : Form
    {
        public frmTablaUsuarios()
        {
            InitializeComponent();
        }

        private void frmTablaUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void ShowAll() 
        {
            try
            {
                ModeloDUsuario Obj = new ModeloDUsuario();
                DataTable tabla = Obj.MostrarUsuarios();
                dgvUsuarios.DataSource = tabla;
                dgvUsuarios.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Arrastre_Formularios.Llama_ReleaseCapture();
            Arrastre_Formularios.Llama_SendMessage(ParentForm.Handle, 0x112, 0xf012, 0);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ModeloDUsuario Obj = new ModeloDUsuario();
            DataTable tabla = Obj.UsuariosCant(Convert.ToInt32(numUpDnCantidad.Value));
            dgvUsuarios.DataSource = tabla;
            dgvUsuarios.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
