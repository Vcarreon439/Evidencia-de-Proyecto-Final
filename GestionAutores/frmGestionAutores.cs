using System;
using System.Collections.Generic;
using System.Drawing;
using Dominio;
using System.IO;
using Funcionalidad_Formularios;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;

namespace GestionAutores
{
    public partial class frmGestionAutores : Form
    {
        public frmGestionAutores()
        {
            InitializeComponent();
        }

        private void chkDesconocido_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDesconocido.Checked==true)
            {
                cboCountry.Enabled = false;
            }
            else
            {
                cboCountry.SelectedIndex = 0;
                cboCountry.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtApellidos.Text = cboCountry.Text;
        }

        private void dgvAutores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> elementos = new List<string>(7);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            ModeloDUsuario objDUsuario = new ModeloDUsuario();

            if (objDUsuario.InsertarAutor(CrearAutor()))
                MessageBox.Show("Correcto");
        }


        private ObjetoAutor CrearAutor()
        {
            ObjetoAutor obj = new ObjetoAutor();

            if (txtID.Text!="")
                obj.Codigo = txtID.Text;

            if (txtNombre.Text != "")
                obj.Nombres = txtNombre.Text;

            if (txtApellidos.Text != "")
                obj.Apellidos = txtApellidos.Text;

            //
            if (chkDesconocido.CheckState == CheckState.Checked)
                obj.Pais = "Desconocido";
            else
                obj.Pais = cboCountry.Text;


            if (txtCiudad.Text != "")
                obj.Ciudad = txtCiudad.Text;

            if (txtComentarios.Text != "")
                obj.Comentarios = txtComentarios.Text;

            //if (pictureBox1.Image != null)

            return obj;

            //    obj.Imagen = pictureBox1.Load(linkLabel1.Text);
        }

        private void ActualizarData()
        {
            try
            {
                ModeloDUsuario OBJ = new ModeloDUsuario();

                var tabla = OBJ.MostrarAutores();

                if (tabla.Rows.Count!=0)
                    dgvAutores.DataSource = tabla;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmGestionAutores_Load(object sender, EventArgs e)
        {
            ActualizarData();
            dgvAutores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvAutores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void dgvAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                List<string> message = new List<string>(5);

                DataGridViewRow reciever = dgvAutores.Rows[e.RowIndex];

                for (int i = 0; i < 5; i++)
                {
                    message.Add(reciever.Cells[i].Value.ToString());
                }

                ModeloDUsuario obj = new ModeloDUsuario();
                ObjetoAutor Autor = obj.MostrarAutor(dgvAutores.SelectedCells[0].Value.ToString());
                fichaAutor ficha = new fichaAutor(Autor);
                ficha.ShowDialog();
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Arrastre_Formularios.Llama_ReleaseCapture();
            Arrastre_Formularios.Llama_SendMessage(ParentForm.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                throw new System.NotImplementedException();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
