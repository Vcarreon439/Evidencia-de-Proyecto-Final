using System;
using Dominio;
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

                if (tabla.Rows.Count!=0)
                    dgvUsuarios.DataSource = tabla;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

    }
}
