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
using Funcionalidad_Formularios;

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

            if (obj.InsertarEditorial(DevolverEditorial()))
                MessageBox.Show("Registro realizado exitosamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("El registro no fue realizado", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ActualizarData();
            Clear();
        }

        private void Clear()
        {
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
        }

        private void ActualizarData()
        {
            ModeloDUsuario obj = new ModeloDUsuario();
            dvgEditoriales.DataSource =  obj.MostrarEditoriales();
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
                    obj.Nombre = txtNombre.Text;
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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Arrastre_Formularios.Llama_ReleaseCapture();
            Arrastre_Formularios.Llama_SendMessage(ParentForm.Handle, 0x112, 0xf012, 0);
        }

        private void frmGestionarEditoriales_Load(object sender, EventArgs e)
        {
            dvgEditoriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ActualizarData();
        }

        private void dvgEditoriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex != -1)
                {
                    string cod = Convert.ToString(dvgEditoriales.Rows[0].Cells[0].Value);
                    string nombre = Convert.ToString(dvgEditoriales.Rows[0].Cells[1].Value);
                    txtNombre.Text = nombre;
                    txtCodigo.Text = cod;

                    ModeloDUsuario Obj = new ModeloDUsuario();
                    DataTable tabla = Obj.MostrarEditorial(cod, nombre);

                    foreach (DataRow row in tabla.Rows)
                    {
                        txtCorreo.Text = Convert.ToString(row["Correo"]);
                        txtDireccion.Text = Convert.ToString(row["Direccion"]);
                        txtTelefono.Text = Convert.ToString(row["Telefono"]);
                    }
                    txtCodigo.Enabled = false;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text!="")
                {
                    ObjetoEditorial editorial = new ObjetoEditorial();
                    editorial.Codigo = txtCodigo.Text;
                    editorial.Correo = txtCorreo.Text;
                    editorial.Direccion = txtDireccion.Text;
                    editorial.Nombre = txtNombre.Text;
                    editorial.Telefono = txtTelefono.Text;

                    ModeloDUsuario Obj = new ModeloDUsuario();

                    if (Obj.ActualizarEditorial(editorial))
                        MessageBox.Show("Cambio realizado exitosamnte");
                    else
                        MessageBox.Show("No se pudo realizar el cambio");

                    ActualizarData();
                    Clear();
                }
                else
                {
                    MessageBox.Show("El campo nombre no puede ir vacio");
                }

                txtCodigo.Enabled = true;
            }
            catch (Exception exception)
            {
                txtCodigo.Enabled = true;
                Console.WriteLine(exception.Message);
                throw;
            }


        }
    }
}
