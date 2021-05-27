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
using Funcionalidad_Formularios;

namespace GestionAutores
{
    public partial class frmListaAutores : Form
    {
        public frmListaAutores()
        {
            InitializeComponent();
            dgvAutores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            FillData();
        }

        private void FillData()
        {
            try
            {
                ModeloDUsuario OBJ = new ModeloDUsuario();
                dgvAutores.DataSource = OBJ.MostrarAutores();
                dgvAutores.ReadOnly = true;
                Format();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Arrastre_Formularios.Llama_ReleaseCapture();
            Arrastre_Formularios.Llama_SendMessage(ParentForm.Handle, 0x112, 0xf012, 0);
        }

        private void Format()
        {
            dgvAutores.Columns[1].HeaderText = "Nombres";
            dgvAutores.Columns[2].HeaderText = "Apellidos";
            dgvAutores.Columns[3].HeaderText = "Pais";
            dgvAutores.Columns[4].HeaderText = "Ciudad";
            dgvAutores.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarCant(Convert.ToInt32(numUpDnCantidad.Value));
        }

        private void MostrarCant(int cant)
        {
            try
            {
                ModeloDUsuario OBJ = new ModeloDUsuario();
                dgvAutores.DataSource = OBJ.AutorCant(cant);
                dgvAutores.ReadOnly = true;
                Format();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void dgvAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ModeloDUsuario obj = new ModeloDUsuario();
                ObjetoAutor Autor = obj.MostrarAutor(dgvAutores.SelectedCells[0].Value.ToString());
                fichaAutor ficha = new fichaAutor(Autor);

                switch (ficha.ShowDialog())
                {
                    case DialogResult.Cancel:
                        MostrarCant(10);
                        break;

                    case DialogResult.Yes:
                        MostrarCant(10);
                        break;

                    case DialogResult.No:
                        MostrarCant(10);
                        break;
                }
            }
        }
    }
}
