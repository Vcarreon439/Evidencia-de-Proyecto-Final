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

            VaciarTextBox();
        }

        private void VaciarTextBox()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtCodigo.Focus();
            txtCodigo.Select();
        }

        private void ActualizarData() 
        {
            try
            {
                ModeloDUsuario OBJ = new ModeloDUsuario();
                dgvGeneros.DataSource = OBJ.MostrarGeneros();
                dgvGeneros.ReadOnly = true;
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
                        MessageBox.Show("Los cambios se realizaron correctamente","Correcto",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El registro no existe en la base de datos",  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            VaciarTextBox();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloDUsuario Obj = new ModeloDUsuario();

                if (txtCodigo.Text != "" && txtDescripcion.Text != "")
                {
                    ModeloDUsuario OBJ = new ModeloDUsuario();
                    if (OBJ.EliminarTema(txtCodigo.Text))
                        MessageBox.Show("Los cambios se realizaron correctamente");
                    else
                        MessageBox.Show("Este registro no existe en la base de datos","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            VaciarTextBox();
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

            if (this.dgvGeneros.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell c in this.dgvGeneros.SelectedCells)
                    c.Selected = false;
            }


            txtCodigo.Focus();
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            txtCodigo.Text = txtCodigo.Text.ToUpper();
        }
    }
}
