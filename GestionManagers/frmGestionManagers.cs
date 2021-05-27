using System;
using Dominio;
using BibliotecaDeClases;
using System.Windows.Forms;
using Funcionalidad_Formularios;

namespace GestionManagers
{
    public partial class frmGestionManagers : Form
    {
        public frmGestionManagers()
        {
            InitializeComponent();
            dgvManagers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private string SelectorRol()
        {
            string caso;

            switch (cboRol.SelectedItem.ToString())
            {
                case "Gestor":
                    caso = "MANAGER";
                    break;

                case "Usuario":
                    caso = "USER";
                    break;

                case "Invitado":
                    caso= "GUEST";
                    break;

                default:
                    caso = "nada";
                    break;
            }

            return caso;
        }

        private bool VerificarTextBox()
        {
            if (txtNombre.Text!=""&txtContraseña.Text!=""&txtConfirm.Text!=""&cboRol.Text!="")
                return true;
            else
                return false;
        }

        private bool VerificarContraseñas()
        {
            return txtContraseña.Text==txtConfirm.Text;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificarTextBox())
                {
                    if (SelectorRol()!="nada")
                    {
                        if (VerificarContraseñas())
                        {
                            ModeloDUsuario model = new ModeloDUsuario();
                            
                            if (model.InsertarManager(txtNombre.Text, txtContraseña.Text, SelectorRol()))
                                MessageBox.Show($"Se ha registrado al usuario {txtNombre.Text}", "Registro Exitoso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show($"No se ha registrado al usuario {txtNombre.Text}", $"Registro Incompleto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            LimpiarCuadros();
                            FillAllData();
                        }
                        else
                        {
                            MessageBox.Show("Porfavor verifique las contraseñas", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtConfirm.Text = "";
                            txtConfirm.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Porfavor seleccione un rol", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboRol.Focus();
                    }
                }
                else
                    MessageBox.Show("Los campos no pueden estar vacios", "Atencion!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void LimpiarCuadros()
        {
            txtNombre.Text = "";
            txtContraseña.Text = "";
            txtConfirm.Text = "";
            cboRol.Text = "";
        }


        private string codigo;

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ObjectManager manager = new ObjectManager();
            ModeloDUsuario model = new ModeloDUsuario();

            if (txtNombre.Text!="")
            {
                manager.Nombre = txtNombre.Text;
                
                if (txtContraseña.Text!=""&txtConfirm.Text!="")
                {
                    if (txtContraseña.Text==txtConfirm.Text)
                    {
                        manager.Contraseña = txtContraseña.Text;

                        if (cboRol.Text!="")
                        {
                            manager.Rol = SelectorRol();

                            if (codigo != "" & codigo != null)
                            {
                                manager.Codigo = codigo;

                                if (model.ActualizarManager(manager))
                                    MessageBox.Show("Elemento actualizado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else
                                    MessageBox.Show("No se pudo realizar el cambio", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                                codigo = null;
                            }
                            else
                                MessageBox.Show("Porfavor seleccione un usuario a modificar en la tabla", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Seleccione un rol", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Las contraseñas no coinciden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Los campos contraseña no pueden ir vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("El campo nombre no puede ir vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            FillAllData();
            LimpiarCuadros();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Arrastre_Formularios.Llama_ReleaseCapture();
            Arrastre_Formularios.Llama_SendMessage(ParentForm.Handle, 0x112, 0xf012, 0);
        }

        private void FillAllData()
        {
            ModeloDUsuario model = new ModeloDUsuario();
            dgvManagers.DataSource = model.MostrarManagers();
        }

        private void frmGestionManagers_Load(object sender, EventArgs e)
        {
            FillAllData();   
        }

        private void frmGestionManagers_Enter(object sender, EventArgs e)
        {
            FillAllData();
        }

        private void LlenarCampos(ObjectManager LoadedManager)
        {
            codigo = LoadedManager.Codigo;
            txtNombre.Text = LoadedManager.Nombre;
            txtContraseña.Text = LoadedManager.Contraseña;
            txtConfirm.Text = LoadedManager.Contraseña;
        }

        private void dgvManagers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ModeloDUsuario obj = new ModeloDUsuario();
                LlenarCampos(obj.MostrarManager(dgvManagers.SelectedCells[0].Value.ToString()));
            }
        }
    }
}
