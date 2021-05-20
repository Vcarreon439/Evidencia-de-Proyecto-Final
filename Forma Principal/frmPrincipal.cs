using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Autenticacion;
using System.Text;
using Funcionalidad_Formularios;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma_Principal
{
    public partial class frmPrincipal : Form
    {
        TipoUsuario.TypeUser intern = TipoUsuario.TypeUser.Invitado;

        private void Opciones(TipoUsuario.TypeUser selector) 
        {
            switch (selector)
            {
                case TipoUsuario.TypeUser.Invitado:

                    break;

                case TipoUsuario.TypeUser.Usuario:
                    UserMode();
                    break;

                case TipoUsuario.TypeUser.Maganer:
                    ManagerMode();
                    break;

                case TipoUsuario.TypeUser.Admin:
                    AdminMode();
                    break;
            }
        }

        private void AdminMode()
        {
            btnGestionGeneros.Enabled = true;
            btnGestionarAutor.Enabled = true;
            btnGestionarMiembro.Enabled = true;
            btnGestionLibro.Enabled = true;

            btnGestionGeneros.Visible = true;
            btnGestionarAutor.Visible = true;
            btnGestionarMiembro.Visible = true;
            btnGestionLibro.Visible = true;

            btnListaGeneros.Enabled = true;
            btnListaAutores.Enabled = true;
            btnListaMiembros.Enabled = true;
            btnListaAutores.Enabled = true;

            cboTipoUsuario.Enabled = true;
            cboTipoUsuario.Visible = true;
        }

        private void ManagerMode()
        {
            btnGestionGeneros.Enabled = true;
            btnGestionarAutor.Enabled = true;
            btnGestionarMiembro.Enabled = true;
            btnGestionLibro.Enabled = true;

            btnGestionGeneros.Visible = true;
            btnGestionarAutor.Visible = true;
            btnGestionarMiembro.Visible = true;
            btnGestionLibro.Visible = true;

            btnListaGeneros.Enabled = true;
            btnListaAutores.Enabled = true;
            btnListaMiembros.Enabled = true;
            btnListaAutores.Enabled = true;
        }
        
        private void UserMode()
        {
            btnGestionGeneros.Enabled = false;
            btnGestionarAutor.Enabled = false;
            btnGestionarMiembro.Enabled = false;
            btnGestionLibro.Enabled = false;

            btnGestionGeneros.Visible = false;
            btnGestionarAutor.Visible = false;
            btnGestionarMiembro.Visible = false;
            btnGestionLibro.Visible = false;

            btnListaGeneros.Enabled = true;
            btnListaAutores.Enabled = true;
            btnListaMiembros.Enabled = true;
            btnListaAutores.Enabled = true;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (intern == TipoUsuario.TypeUser.Invitado)
            {
                MessageBox.Show("Usted no tiene permiso de abrir este formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            Opciones(intern);
        }

        public frmPrincipal(TipoUsuario.TypeUser type)
        {
            InitializeComponent();
            this.intern = type;
        }
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnGeneros_Click(object sender, EventArgs e)
        {
            if (pnlSubMenu1.Visible == false)
                pnlSubMenu1.Visible = true;
            else
                pnlSubMenu1.Visible = false;
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            if (pnlSubMenu2.Visible == false)
                pnlSubMenu2.Visible = true;
            else
                pnlSubMenu2.Visible = false;
        }

        private void btnMiembros_Click(object sender, EventArgs e)
        {
            if (pnlSubMenu3.Visible == false)
                pnlSubMenu3.Visible = true;
            else
                pnlSubMenu3.Visible = false;
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            if (pnlSubMenu4.Visible == false)
                pnlSubMenu4.Visible = true;
            else
                pnlSubMenu4.Visible = false;
        }

        private void btnGestionGeneros_Click(object sender, EventArgs e)
        {
            FormEnPanel.AbrirForm<GestionGeneros.frmGestionarGeneros>(ref pnlContenedor);
        }

        private void pnlContenedor_MouseMove(object sender, MouseEventArgs e)
        {
            Arrastre_Formularios.Llama_ReleaseCapture();
            Arrastre_Formularios.Llama_SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlEncabezadoMenu_MouseMove(object sender, MouseEventArgs e)
        {
            Arrastre_Formularios.Llama_ReleaseCapture();
            Arrastre_Formularios.Llama_SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlMenu_MouseMove(object sender, MouseEventArgs e)
        {
            Arrastre_Formularios.Llama_ReleaseCapture();
            Arrastre_Formularios.Llama_SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnGestionarAutores_Click(object sender, EventArgs e)
        {
            FormEnPanel.AbrirForm<GestionAutores.frmGestionAutores>(ref pnlContenedor);
        }

        private void btnListaMiembros_Click(object sender, EventArgs e)
        {
            FormEnPanel.AbrirForm<GestionUsuarios.frmTablaUsuarios>(ref pnlContenedor);
        }

        private void btnAgregarMiembro_Click(object sender, EventArgs e)
        {
            FormEnPanel.AbrirForm<GestionUsuarios.frmGestionUsuarios>(ref pnlContenedor);
        }

        private void btnGestionGeneros_MouseClick(object sender, MouseEventArgs e)
        {
            FormEnPanel.AbrirForm<GestionGeneros.frmGestionarGeneros>(ref pnlContenedor);
        }

        private void btnGestionarAutores_MouseClick(object sender, MouseEventArgs e)
        {
            FormEnPanel.AbrirForm<GestionAutores.frmGestionAutores>(ref pnlContenedor);
        }

        private void btnAgregarMiembro_MouseClick(object sender, MouseEventArgs e)
        {
            FormEnPanel.AbrirForm<GestionUsuarios.frmGestionUsuarios>(ref pnlContenedor);
        }

        private void btnListaMiembros_MouseClick(object sender, MouseEventArgs e)
        {
            FormEnPanel.AbrirForm<GestionUsuarios.frmTablaUsuarios>(ref pnlContenedor);
        }

        private void cboTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cboTipoUsuario.Text)
            {
                case "Administrador":
                    this.intern = TipoUsuario.TypeUser.Admin;
                    Opciones(this.intern);
                    break;

                case "Manager":
                    this.intern = TipoUsuario.TypeUser.Maganer;
                    Opciones(this.intern);
                    break;

                case "Usuario":
                    this.intern = TipoUsuario.TypeUser.Usuario;
                    Opciones(this.intern);
                    break;

                case "Invitado":
                    this.intern = TipoUsuario.TypeUser.Invitado;
                    Opciones(this.intern);
                    break;
            }
        }
    }
}
