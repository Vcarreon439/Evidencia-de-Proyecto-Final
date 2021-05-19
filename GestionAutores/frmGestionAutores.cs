using System;
using Dominio;
using System.IO;
using Funcionalidad_Formularios;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace GestionAutores
{
    public partial class frmGestionAutores : Form
    {
        public frmGestionAutores()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //fichaAutor frm = new fichaAutor();
            //frm.Show();
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

        private void btnImagen_Click(object sender, EventArgs e)
        {
            using (CommonOpenFileDialog ofl = new CommonOpenFileDialog())
            {
                CommonFileDialogStandardFilters.PictureFiles.ShowExtensions = true;
                
                ofl.Title = "Seleccione un imagen porfavor.";
                ofl.IsFolderPicker = false;
                ofl.Multiselect = false;
                ofl.Filters.Add(CommonFileDialogStandardFilters.PictureFiles);

                if (ofl.ShowDialog() == CommonFileDialogResult.Ok)
                    linkLabel1.Text = ofl.FileName;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Path.Combine(Application.StartupPath, linkLabel1.Text));
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloDUsuario OBJ = new ModeloDUsuario();
                if (OBJ.InsertarAutor(CrearLista()))
                    MessageBox.Show("Correcto");
                else
                    MessageBox.Show("Incorrecto");

                ActualizarData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private List<string> CrearLista() 
        {
            List<string> lista = new List<string>(7);

            if (txtID.Text!="")
                lista.Add(txtID.Text);

            //Nombre
            if (txtNombre.Text!="")
                lista.Add(txtNombre.Text);
            else
                lista.Add(null);
            
            //Apellidos
            if (txtApellidos.Text!="")
                lista.Add(txtApellidos.Text);
            else
                lista.Add(null);

            //pais
            if (chkDesconocido.Checked == true)
                lista.Add("Desconocido");
            else
                lista.Add(cboCountry.Text);

            //Ciudad
            if (txtCiudad.Text != "")
                lista.Add(txtCiudad.Text);
            else
                lista.Add(null);

            //Comentarios
            if (txtComentarios.Text != "")
                lista.Add(txtComentarios.Text);
            else
                lista.Add("");

            //Foto
            if (linkLabel1.Text != "")
                lista.Add(linkLabel1.Text);
            else
                lista.Add("");

            return lista;
        }

        private void ActualizarData()
        {
            try
            {
                ModeloDUsuario OBJ = new ModeloDUsuario();

                var tabla = OBJ.MostrarAutor();

                if (tabla.Rows.Count!=0)
                    dgvAutores.DataSource = tabla;

                //dgvAutores.Ed

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmGestionAutores_Load(object sender, EventArgs e)
        {
            ActualizarData();
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

                ObjetoAutor Obj = new ObjetoAutor(message);
                fichaAutor ficha = new fichaAutor(Obj);
                ficha.ShowDialog();
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Arrastre_Formularios.Llama_ReleaseCapture();
            Arrastre_Formularios.Llama_SendMessage(ParentForm.Handle, 0x112, 0xf012, 0);
        }
    }
}
