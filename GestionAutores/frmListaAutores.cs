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
                dgvAutores.DataSource = OBJ.MostrarAutor();
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
    }
}
