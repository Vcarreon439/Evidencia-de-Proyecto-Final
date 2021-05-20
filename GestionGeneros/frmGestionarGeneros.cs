using System;
using Dominio;
using Funcionalidad_Formularios;
using System.Windows.Forms;
using System.Collections.Generic;

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text!=""&&txtDescripcion.Text!="")
                {
                    ModeloDUsuario OBJ = new ModeloDUsuario();
                    if (OBJ.InsercionTema(txtCodigo.Text, txtDescripcion.Text))
                        MessageBox.Show("Correcto");
                    else
                        MessageBox.Show("Incorrecto");
                }
                else
                {
                    MessageBox.Show("Los campos codigo y descripcion no pueden ir vacios", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                ActualizarData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarData() 
        {
            try
            {
                ModeloDUsuario OBJ = new ModeloDUsuario();
                dgvGeneros.DataSource = OBJ.MostrarGeneros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void frmGestionarGeneros_Load(object sender, EventArgs e)
        {
            ActualizarData();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloDUsuario Obj = new ModeloDUsuario();

                if (txtCodigo.Text != "" && txtDescripcion.Text != "")
                {
                    ModeloDUsuario OBJ = new ModeloDUsuario();
                    if (OBJ.ActualizarGenero(txtCodigo.Text, txtDescripcion.Text))
                        MessageBox.Show("Los cambios se realizaron correctamente");
                    else
                        MessageBox.Show("Incorrecto");
                }
                else
                {
                    MessageBox.Show("Los campos codigo y descripcion no pueden ir vacios", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ActualizarData();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void dgvGeneros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                List<string> message = new List<string>(2);
                DataGridViewRow reciever = dgvGeneros.Rows[e.RowIndex];

                for (int i = 0; i < 2; i++)
                {
                    message.Add(reciever.Cells[i].Value.ToString());
                }

                txtCodigo.Text = message[0];
                txtDescripcion.Text = message[1];
            }
        }
    }
}
