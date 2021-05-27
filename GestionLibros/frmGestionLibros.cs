﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Funcionalidad_Formularios;

namespace GestionLibros
{
    public partial class frmGestionLibros : Form
    {
        public frmGestionLibros()
        {
            InitializeComponent();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Arrastre_Formularios.Llama_ReleaseCapture();
            Arrastre_Formularios.Llama_SendMessage(ParentForm.Handle, 0x112, 0xf012, 0);
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmGestionLibros_Load(object sender, EventArgs e)
        {
            ModeloDUsuario model = new ModeloDUsuario();

            foreach (var VARIABLE in model.TemaCombo())
                cboTema.Items.Add(VARIABLE);

            foreach (var VARIABLE in model.EditorialesCombo())
                cboEditorial.Items.Add(VARIABLE);

        }

        private void cboTema_Enter(object sender, EventArgs e)
        {
            cboTema.Items.Clear();

            ModeloDUsuario model = new ModeloDUsuario();

            foreach (var VARIABLE in model.TemaCombo())
                cboTema.Items.Add(VARIABLE);
        }

        private void cboEditorial_Enter(object sender, EventArgs e)
        {
            cboEditorial.Items.Clear();

            ModeloDUsuario model = new ModeloDUsuario();

            foreach (var VARIABLE in model.EditorialesCombo())
                cboEditorial.Items.Add(VARIABLE);
        }
    }
}
