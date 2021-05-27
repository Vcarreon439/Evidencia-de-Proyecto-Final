using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;
using Dominio;

namespace GestionEditorial
{
    public partial class frmGestionarEditoriales : Form
    {
        public frmGestionarEditoriales()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ModeloDUsuario obj = new ModeloDUsuario();
            obj.InsertarEditorial(DevolverEditorial());
        }

        private ObjetoEditorial DevolverEditorial()
        {
            ObjetoEditorial obj = new ObjetoEditorial();

            if (txtCodigo.Text != null)
            {
                obj.Codigo = txtCodigo.Text;

                if (txtNombre.Text != null)
                {
                    obj.Codigo = txtCodigo.Text;
                    
                    obj.Correo = txtCorreo.Text;
                    obj.Direccion = txtDireccion.Text;
                    obj.Telefono = txtTelefono.Text;
                }
                else
                {
                    MessageBox.Show("El campo codigo no puede ir vacio", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El campo codigo no puede ir vacio", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return obj;
        }

    }
}
