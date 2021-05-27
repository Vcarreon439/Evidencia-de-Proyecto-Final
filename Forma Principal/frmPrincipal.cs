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
        private TipoUsuario.TypeUser intern = TipoUsuario.TypeUser.Invitado;

        #region ControlDeAcceso

        private void Opciones(TipoUsuario.TypeUser selector)
        {
            switch (selector)
            {
                case TipoUsuario.TypeUser.Invitado:
                    ModoInvitado();
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

        private void ModoInvitado()
        {
            btnGeneros.Visible = true;
            btnAutores.Visible = true;
            btnMiembros.Visible = true;
            btnLibros.Visible = true;
            btnManagers.Visible = true;
            btnEditorial.Visible = true;

            btnGeneros.Enabled = true;
            btnAutores.Enabled = true;
            btnMiembros.Enabled = true;
            btnLibros.Enabled = true;
            btnManagers.Enabled = true;
            btnEditorial.Enabled = true;

            btnGestionGeneros.Visible = true;
            btnGestionGeneros.Enabled = false;

            btnListaGeneros.Visible = true;
            btnListaGeneros.Enabled = false;

            btnGestionarAutor.Visible = true;
            btnGestionarAutor.Enabled = false;

            btnListaAutores.Visible = true;
            btnListaAutores.Enabled = false;

            btnGestionarMiembro.Visible = true;
            btnGestionarMiembro.Enabled = false;

            btnListaMiembros.Visible = true;
            btnListaMiembros.Enabled = false;

            btnGestionLibro.Visible = true;
            btnGestionLibro.Enabled = false;

            btnListaLibros.Visible = true;
            btnListaLibros.Enabled = false;

            btnGestionarUsuarios.Visible = true;
            btnGestionarUsuarios.Enabled = false;

            btnGestionarEditoriales.Visible = true;
            btnGestionarEditoriales.Enabled = false;

            pnlSubMenu1.Visible = true;
            pnlSubMenu1.Enabled = true;
            pnlSubMenu2.Visible = true;
            pnlSubMenu2.Enabled = true;
            pnlSubMenu3.Visible = true;
            pnlSubMenu3.Enabled = true;
            pnlSubMenu4.Visible = true;
            pnlSubMenu4.Enabled = true;
            pnlSubMenu5.Visible = true;
            pnlSubMenu5.Enabled = true;
            pnlSubMenu6.Visible = true;
            pnlSubMenu6.Enabled = true;

            cboTipoUsuario.Visible = false;
        }
        private void AdminMode()
        {
            btnGeneros.Visible = true;
            btnAutores.Visible = true;
            btnMiembros.Visible = true;
            btnLibros.Visible = true;
            btnManagers.Visible = true;
            btnEditorial.Visible = true;

            btnGeneros.Enabled = true;
            btnAutores.Enabled = true;
            btnMiembros.Enabled = true;
            btnLibros.Enabled = true;
            btnManagers.Enabled = true;
            btnEditorial.Enabled = true;

            btnGestionGeneros.Visible = true;
            btnGestionGeneros.Enabled = true;

            btnListaGeneros.Visible = true;
            btnListaGeneros.Enabled = true;

            btnGestionarAutor.Visible = true;
            btnGestionarAutor.Enabled = true;

            btnListaAutores.Visible = true;
            btnListaAutores.Enabled = true;

            btnGestionarMiembro.Visible = true;
            btnGestionarMiembro.Enabled = true;

            btnListaMiembros.Visible = true;
            btnListaMiembros.Enabled = true;

            btnGestionLibro.Visible = true;
            btnGestionLibro.Enabled = true;

            btnListaLibros.Visible = true;
            btnListaLibros.Enabled = true;

            btnGestionarUsuarios.Visible = true;
            btnGestionarUsuarios.Enabled = true;

            btnGestionarEditoriales.Visible = true;
            btnGestionarEditoriales.Enabled = true;

            pnlSubMenu1.Visible = false;
            pnlSubMenu1.Enabled = true;
            pnlSubMenu2.Visible = false;
            pnlSubMenu2.Enabled = true;
            pnlSubMenu3.Visible = false;
            pnlSubMenu3.Enabled = true;
            pnlSubMenu4.Visible = false;
            pnlSubMenu4.Enabled = true;
            pnlSubMenu5.Visible = false;
            pnlSubMenu5.Enabled = true;
            pnlSubMenu6.Visible = false;
            pnlSubMenu6.Enabled = true;

            cboTipoUsuario.Visible = true;
        }
        private void ManagerMode()
        {
            btnGeneros.Visible = true;
            btnAutores.Visible = true;
            btnMiembros.Visible = true;
            btnLibros.Visible = true;
            btnManagers.Visible = true;
            btnEditorial.Visible = true;

            btnGeneros.Enabled = true;
            btnAutores.Enabled = true;
            btnMiembros.Enabled = true;
            btnLibros.Enabled = true;
            btnManagers.Enabled = true;
            btnEditorial.Enabled = true;

            btnGestionGeneros.Visible = true;
            btnGestionGeneros.Enabled = true;

            btnListaGeneros.Visible = true;
            btnListaGeneros.Enabled = true;

            btnGestionarAutor.Visible = true;
            btnGestionarAutor.Enabled = true;

            btnListaAutores.Visible = true;
            btnListaAutores.Enabled = true;

            btnGestionarMiembro.Visible = true;
            btnGestionarMiembro.Enabled = true;

            btnListaMiembros.Visible = true;
            btnListaMiembros.Enabled = true;

            btnGestionLibro.Visible = true;
            btnGestionLibro.Enabled = true;

            btnListaLibros.Visible = true;
            btnListaLibros.Enabled = true;

            btnGestionarUsuarios.Visible = true;
            btnGestionarUsuarios.Enabled = true;

            btnGestionarEditoriales.Visible = true;
            btnGestionarEditoriales.Enabled = true;

            pnlSubMenu1.Visible = false;
            pnlSubMenu1.Enabled = true;
            pnlSubMenu2.Visible = false;
            pnlSubMenu2.Enabled = true;
            pnlSubMenu3.Visible = false;
            pnlSubMenu3.Enabled = true;
            pnlSubMenu4.Visible = false;
            pnlSubMenu4.Enabled = true;
            pnlSubMenu5.Visible = false;
            pnlSubMenu5.Enabled = true;
            pnlSubMenu6.Visible = false;
            pnlSubMenu6.Enabled = true;

            cboTipoUsuario.Visible = false;
        }
        private void UserMode()
        {
            btnGeneros.Visible = true;
            btnAutores.Visible = true;
            btnMiembros.Visible = false;
            btnLibros.Visible = true;
            btnManagers.Visible = false;
            btnEditorial.Visible = false;

            btnGeneros.Enabled = true;
            btnAutores.Enabled = true;
            btnMiembros.Enabled = false;
            btnLibros.Enabled = true;
            btnManagers.Enabled = false;
            btnEditorial.Enabled = false;

            btnGestionGeneros.Visible = false;
            btnGestionGeneros.Enabled = false;

            btnListaGeneros.Visible = true;
            btnListaGeneros.Enabled = true;

            btnGestionarAutor.Visible = false;
            btnGestionarAutor.Enabled = false;

            btnListaAutores.Visible = true;
            btnListaAutores.Enabled = true;

            btnGestionarMiembro.Visible = false;
            btnGestionarMiembro.Enabled = false;

            btnListaMiembros.Visible = false;
            btnListaMiembros.Enabled = false;

            btnGestionLibro.Visible = false;
            btnGestionLibro.Enabled = false;

            btnListaLibros.Visible = true;
            btnListaLibros.Enabled = true;

            btnGestionarUsuarios.Visible = false;
            btnGestionarUsuarios.Enabled = false;

            btnGestionarEditoriales.Visible = true;
            btnGestionarEditoriales.Enabled = true;

            pnlSubMenu1.Visible = false;
            pnlSubMenu1.Enabled = true;
            pnlSubMenu2.Visible = false;
            pnlSubMenu2.Enabled = true;
            pnlSubMenu3.Visible = false;
            pnlSubMenu3.Enabled = false;
            pnlSubMenu4.Visible = false;
            pnlSubMenu4.Enabled = true;
            pnlSubMenu5.Visible = false;
            pnlSubMenu5.Enabled = false;
            pnlSubMenu6.Visible = false;
            pnlSubMenu6.Enabled = false;

            cboTipoUsuario.Visible = false;
        }

        #endregion

        #region Load

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

        #endregion

        private void SlideBtn()
        {
            if (pnlMenu.Size.Width == 60)
            {
                pnlMenu.Size = new Size(200, pnlMenu.Height);
                CambiarBotones();
                SlideAligment();
            }
        }


        #region ControlDePaneles

        private void btnGeneros_Click(object sender, EventArgs e)
        {
            SlideBtn();

            if (pnlSubMenu1.Visible == false)
                pnlSubMenu1.Visible = true;
            else
                pnlSubMenu1.Visible = false;

        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            SlideBtn();

            if (pnlSubMenu2.Visible == false)
                pnlSubMenu2.Visible = true;
            else
                pnlSubMenu2.Visible = false;
        }

        private void btnMiembros_Click(object sender, EventArgs e)
        {
            SlideBtn();

            if (pnlSubMenu3.Visible == false)
                pnlSubMenu3.Visible = true;
            else
                pnlSubMenu3.Visible = false;
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            SlideBtn();

            if (pnlSubMenu4.Visible == false)
                pnlSubMenu4.Visible = true;
            else
                pnlSubMenu4.Visible = false;
        }

        private void btnManagers_Click(object sender, EventArgs e)
        {
            SlideBtn();

            if (pnlSubMenu5.Visible == false)
                pnlSubMenu5.Visible = true;
            else
                pnlSubMenu5.Visible = false;
        }

        private void btnEditorial_Click(object sender, EventArgs e)
        {
            SlideBtn();

            if (pnlSubMenu6.Visible == false)
                pnlSubMenu6.Visible = true;
            else
                pnlSubMenu6.Visible = false;
        }

        #endregion

        #region MovimientoDeLaForma
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

        #endregion

        #region EventosClick

        private void btnListaGeneros_MouseClick(object sender, MouseEventArgs e)
        {
            FormEnPanel.AbrirForm<GestionGeneros.frmListaGenero>(ref pnlContenedor);
            pnlSubMenu1.Visible = false;
            pnlSubMenu2.Visible = false;
            pnlSubMenu3.Visible = false;
            pnlSubMenu4.Visible = false;
            pnlSubMenu5.Visible = false;
            pnlSubMenu6.Visible = false;
        }

        private void btnGestionGeneros_Click(object sender, EventArgs e)
        {
            FormEnPanel.AbrirForm<GestionGeneros.frmGestionarGeneros>(ref pnlContenedor);
        }

        private void btnGestionarMiembro_MouseClick(object sender, MouseEventArgs e)
        {
            FormEnPanel.AbrirForm<GestionUsuarios.frmTablaUsuarios>(ref pnlContenedor);

            if (FormEnPanel.AbrirForm<GestionUsuarios.frmGestionUsuarios>(ref pnlContenedor, 0) == DialogResult.Yes)
            {
                FormEnPanel.AbrirForm<GestionUsuarios.frmTablaUsuarios>(ref pnlContenedor);
            }

            pnlSubMenu1.Visible = false;
            pnlSubMenu2.Visible = false;
            pnlSubMenu3.Visible = false;
            pnlSubMenu4.Visible = false;
            pnlSubMenu5.Visible = false;

        }

        private void btnListaUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            pnlSubMenu1.Visible = false;
            pnlSubMenu2.Visible = false;
            pnlSubMenu3.Visible = false;
            pnlSubMenu4.Visible = false;
            pnlSubMenu5.Visible = false;
        }

        private void btnListaAutores_Click(object sender, EventArgs e)
        {
            FormEnPanel.AbrirForm<GestionAutores.frmListaAutores>(ref pnlContenedor);
            pnlSubMenu1.Visible = false;
            pnlSubMenu2.Visible = false;
            pnlSubMenu3.Visible = false;
            pnlSubMenu4.Visible = false;
            pnlSubMenu5.Visible = false;
            pnlSubMenu6.Visible = false;
        }

        private void btnGestionLibro_Click(object sender, EventArgs e)
        {
            FormEnPanel.AbrirForm<GestionLibros.frmGestionLibros>(ref pnlContenedor);
            pnlSubMenu1.Visible = false;
            pnlSubMenu2.Visible = false;
            pnlSubMenu3.Visible = false;
            pnlSubMenu4.Visible = false;
            pnlSubMenu5.Visible = false;
            pnlSubMenu6.Visible = false;
        }

        private void btnListaLibros_Click(object sender, EventArgs e)
        {
            FormEnPanel.AbrirForm<GestionLibros.listaLibros>(ref pnlContenedor);
            pnlSubMenu1.Visible = false;
            pnlSubMenu2.Visible = false;
            pnlSubMenu3.Visible = false;
            pnlSubMenu4.Visible = false;
            pnlSubMenu5.Visible = false;
            pnlSubMenu6.Visible = false;
        }

        private void btnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            FormEnPanel.AbrirForm<GestionManagers.frmGestionManagers>(ref pnlContenedor);
            pnlSubMenu1.Visible = false;
            pnlSubMenu2.Visible = false;
            pnlSubMenu3.Visible = false;
            pnlSubMenu4.Visible = false;
            pnlSubMenu5.Visible = false;
            pnlSubMenu6.Visible = false;
        }

        private void btnGestionarEditoriales_Click(object sender, EventArgs e)
        {
            FormEnPanel.AbrirForm<GestionEditorial.frmGestionarEditoriales>(ref pnlContenedor);
            pnlSubMenu1.Visible = false;
            pnlSubMenu2.Visible = false;
            pnlSubMenu3.Visible = false;
            pnlSubMenu4.Visible = false;
            pnlSubMenu5.Visible = false;
            pnlSubMenu6.Visible = false;
        }

        private void btnGestionarAutores_Click(object sender, EventArgs e)
        {
            FormEnPanel.AbrirForm<GestionAutores.frmGestionAutores>(ref pnlContenedor);
        }

        private void btnGestionGeneros_MouseClick(object sender, MouseEventArgs e)
        {
            FormEnPanel.AbrirForm<GestionGeneros.frmGestionarGeneros>(ref pnlContenedor);
            pnlSubMenu1.Visible = false;
            pnlSubMenu2.Visible = false;
            pnlSubMenu3.Visible = false;
            pnlSubMenu4.Visible = false;
            pnlSubMenu5.Visible = false;
            pnlSubMenu6.Visible = false;
        }

        private void btnGestionarAutores_MouseClick(object sender, MouseEventArgs e)
        {
            FormEnPanel.AbrirForm<GestionAutores.frmGestionAutores>(ref pnlContenedor);
            pnlSubMenu1.Visible = false;
            pnlSubMenu2.Visible = false;
            pnlSubMenu3.Visible = false;
            pnlSubMenu4.Visible = false;
            pnlSubMenu5.Visible = false;
            pnlSubMenu6.Visible = false;
        }

        private void btnAgregarMiembro_MouseClick(object sender, MouseEventArgs e)
        {
            FormEnPanel.AbrirForm<GestionUsuarios.frmGestionUsuarios>(ref pnlContenedor);
        }

        private void btnListaMiembros_MouseClick(object sender, MouseEventArgs e)
        {
            FormEnPanel.AbrirForm<GestionUsuarios.frmTablaUsuarios>(ref pnlContenedor);
            pnlSubMenu1.Visible = false;
            pnlSubMenu2.Visible = false;
            pnlSubMenu3.Visible = false;
            pnlSubMenu4.Visible = false;
            pnlSubMenu5.Visible = false;
            pnlSubMenu6.Visible = false;
        }

        #endregion


        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void CambiarBotones()
        {
            if (pnlMenu.Size.Width == 60)
            {
                btnGeneros.Text = "";
                btnAutores.Text = "";
                btnMiembros.Text = "";
                btnLibros.Text = "";
                btnManagers.Text = "";
                btnEditorial.Text = "";
                lblTitulo.Visible = false;
            }
            else
            {
                btnGeneros.Text = "Generos";
                btnAutores.Text = "Autores";
                btnMiembros.Text = "Miembros";
                btnLibros.Text = "Libros";
                btnManagers.Text = "Usuarios";
                btnEditorial.Text = "Editorial";
                lblTitulo.Visible = true;
            }
        }

        private void SlideAligment()
        {
            if (btnSlide.ImageAlign == ContentAlignment.MiddleLeft)
                btnSlide.ImageAlign = ContentAlignment.MiddleRight;
            else
                btnSlide.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void CambiarMenu()
        {
            if (pnlMenu.Size.Width != 60)
            {
                pnlMenu.Size = new Size(60, pnlMenu.Height);
                CambiarBotones();
                SlideAligment();
            }
            else
            {
                pnlMenu.Size = new Size(200, pnlMenu.Height);
                CambiarBotones();
                SlideAligment();
            }
        }

        private void MostrarMenu()
        {
            pnlMenu.Size = new Size(200, pnlMenu.Height);
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            CambiarMenu();   
        }
    }
}
