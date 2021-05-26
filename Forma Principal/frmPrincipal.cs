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

        public frmPrincipal(TipoUsuario.TypeUser type)
        {
            InitializeComponent();
            this.intern = type;
        }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        #region Metodos Privados

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

        private void ModoInvitado()
        {
            btnGestionGeneros.Enabled = true;
            btnGestionarAutor.Enabled = true;
            btnGestionarMiembro.Enabled = true;
            btnGestionLibro.Enabled = true;

            btnGestionGeneros.Visible = true;
            btnGestionarAutor.Visible = true;
            btnGestionarMiembro.Visible = true;
            btnGestionLibro.Visible = true;
            btnGestionarUsuarios.Enabled = true;


            btnListaGeneros.Enabled = true;
            btnListaAutores.Enabled = true;
            btnListaMiembros.Enabled = true;
            btnListaAutores.Enabled = true;
            btnListaUsuarios.Enabled = true;

            cboTipoUsuario.Enabled = true;
            cboTipoUsuario.Visible = true;
        }

        private void EventChanger(bool bandera)
        {
            switch (bandera)
            {
                case true:
                    btnGestionLibro.MouseClick -= Mostrar_MouseClick;
                    btnGestionarUsuarios.MouseClick -= Mostrar_MouseClick;
                    btnGestionarMiembro.MouseClick -= Mostrar_MouseClick;
                    btnGestionGeneros.MouseClick -= Mostrar_MouseClick;
                    btnGestionarAutor.MouseClick -= Mostrar_MouseClick;
                    btnGestionGeneros.MouseClick += btnGestionGeneros_MouseClick;
                    btnGestionarAutor.MouseClick += btnGestionarAutores_MouseClick;
                    btnGestionarMiembro.MouseClick += btnGestionarMiembro_MouseClick;
                    btnGestionarUsuarios.MouseClick += btnGestionarUsuarios_MouseClick;
                    btnGestionLibro.MouseClick += btnGestionLibro_MouseClick;
                    //
                    btnListaGeneros.MouseClick -= Mostrar_MouseClick;
                    btnListaAutores.MouseClick -= Mostrar_MouseClick;
                    btnListaMiembros.MouseClick -= Mostrar_MouseClick;
                    btnListaUsuarios.MouseClick -= Mostrar_MouseClick;
                    btnListaLibros.MouseClick -= Mostrar_MouseClick;
                    btnListaGeneros.MouseClick += btnListaGeneros_MouseClick;
                    btnListaAutores.MouseClick += btnListaAutores_MouseClick;
                    btnListaMiembros.MouseClick += btnListaMiembros_MouseClick;
                    btnListaUsuarios.MouseClick += btnListaUsuarios_MouseClick;
                    btnListaLibros.MouseClick += btnListaLibros_MouseClick;
                    break;

                case false:
                    btnGestionGeneros.MouseClick -= btnGestionGeneros_MouseClick;
                    btnGestionarMiembro.MouseClick -= btnGestionarMiembro_MouseClick;
                    btnGestionarAutor.MouseClick -= btnGestionarAutores_MouseClick;
                    btnGestionarUsuarios.MouseClick -= btnGestionarUsuarios_MouseClick;
                    btnGestionLibro.MouseClick -= btnGestionLibro_MouseClick;
                    btnGestionGeneros.MouseClick += Mostrar_MouseClick;
                    btnGestionarAutor.MouseClick += Mostrar_MouseClick;
                    btnGestionarMiembro.MouseClick += Mostrar_MouseClick;
                    btnGestionarUsuarios.MouseClick += Mostrar_MouseClick;
                    btnGestionLibro.MouseClick += Mostrar_MouseClick;
                    //
                    btnListaGeneros.MouseClick -= btnListaGeneros_MouseClick;
                    btnListaUsuarios.MouseClick -= btnListaUsuarios_MouseClick;
                    btnListaLibros.MouseClick -= btnListaLibros_MouseClick;
                    btnListaMiembros.MouseClick -= btnListaMiembros_MouseClick;
                    btnListaAutores.MouseClick -= btnListaAutores_MouseClick;
                    btnListaGeneros.MouseClick += Mostrar_MouseClick;
                    btnListaAutores.MouseClick += Mostrar_MouseClick;
                    btnListaMiembros.MouseClick += Mostrar_MouseClick;
                    btnListaUsuarios.MouseClick += Mostrar_MouseClick;
                    btnListaLibros.MouseClick += Mostrar_MouseClick;
                    break;
            }
        }

        private void Mostrar_MouseClick(object sender, EventArgs e)
        {
            MessageBox.Show("Usted se encuentra en el modo de prueba", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            btnGestionarUsuarios.Enabled = true;
            

            btnListaGeneros.Enabled = true;
            btnListaAutores.Enabled = true;
            btnListaMiembros.Enabled = true;
            btnListaAutores.Enabled = true;
            btnListaUsuarios.Enabled = true;

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
            btnGestionarUsuarios.Enabled = true;

            btnManagers.Visible = true;
            pnlSubMenu5.Visible = true;

            
            btnListaGeneros.Enabled = true;
            btnListaAutores.Enabled = true;
            btnListaMiembros.Enabled = true;
            btnListaAutores.Enabled = true;
            btnListaUsuarios.Enabled = true;
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
            btnGestionarUsuarios.Enabled = false;

            btnManagers.Visible = false;
            pnlSubMenu5.Visible = false;
            
            btnListaGeneros.Enabled = true;
            btnListaAutores.Enabled = true;
            btnListaMiembros.Enabled = true;
            btnListaAutores.Enabled = true;
            btnListaUsuarios.Enabled = false;
        }

        #endregion

        #region Eventos

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (intern == TipoUsuario.TypeUser.Invitado)
            {
                MessageBox.Show("Usted no tiene permiso de abrir este formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            Opciones(intern);
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

        private void btnManagers_Click(object sender, EventArgs e)
        {
            if (pnlSubMenu5.Visible == false)
                pnlSubMenu5.Visible = true;
            else
                pnlSubMenu5.Visible = false;
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

        private void btnGestionGeneros_MouseClick(object sender, MouseEventArgs e)
        {
            FormEnPanel.AbrirForm<GestionGeneros.frmGestionarGeneros>(ref pnlContenedor);
            pnlSubMenu1.Visible = false;
            pnlSubMenu2.Visible = false;
            pnlSubMenu3.Visible = false;
            pnlSubMenu4.Visible = false;
            pnlSubMenu5.Visible = false;

        }

        private void btnGestionarAutores_MouseClick(object sender, MouseEventArgs e)
        {
            FormEnPanel.AbrirForm<GestionAutores.frmGestionAutores>(ref pnlContenedor);
            pnlSubMenu1.Visible = false;
            pnlSubMenu2.Visible = false;
            pnlSubMenu3.Visible = false;
            pnlSubMenu4.Visible = false;
            pnlSubMenu5.Visible = false;
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
        }

        private void cboTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cboTipoUsuario.Text)
            {
                case "Administrador":
                    this.intern = TipoUsuario.TypeUser.Admin;
                    Opciones(this.intern);
                    EventChanger(true);
                    break;

                case "Manager":
                    this.intern = TipoUsuario.TypeUser.Maganer;
                    Opciones(this.intern);
                    EventChanger(true);
                    break;

                case "Usuario":
                    this.intern = TipoUsuario.TypeUser.Usuario;
                    Opciones(this.intern);
                    EventChanger(true);
                    break;

                case "Invitado":
                    this.intern = TipoUsuario.TypeUser.Invitado;
                    Opciones(this.intern);
                    EventChanger(false);
                    break;
            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }


        #endregion

        private void btnListaGeneros_MouseClick(object sender, MouseEventArgs e)
        {
            FormEnPanel.AbrirForm<GestionGeneros.frmListaGenero>(ref pnlContenedor);
            pnlSubMenu1.Visible = false;
            pnlSubMenu2.Visible = false;
            pnlSubMenu3.Visible = false;
            pnlSubMenu4.Visible = false;
            pnlSubMenu5.Visible = false;
        }

        private void btnListaAutores_MouseClick(object sender, MouseEventArgs e)
        {
            pnlSubMenu1.Visible = false;
            pnlSubMenu2.Visible = false;
            pnlSubMenu3.Visible = false;
            pnlSubMenu4.Visible = false;
            pnlSubMenu5.Visible = false;
        }

        private void btnGestionarMiembro_MouseClick(object sender, MouseEventArgs e)
        {
            FormEnPanel.AbrirForm<GestionUsuarios.frmGestionUsuarios>(ref pnlContenedor);
            pnlSubMenu1.Visible = false;
            pnlSubMenu2.Visible = false;
            pnlSubMenu3.Visible = false;
            pnlSubMenu4.Visible = false;
            pnlSubMenu5.Visible = false;

        }

        private void btnGestionLibro_MouseClick(object sender, MouseEventArgs e)
        {
            pnlSubMenu1.Visible = false;
            pnlSubMenu2.Visible = false;
            pnlSubMenu3.Visible = false;
            pnlSubMenu4.Visible = false;
            pnlSubMenu5.Visible = false;
        }

        private void btnListaLibros_MouseClick(object sender, MouseEventArgs e)
        {
            pnlSubMenu1.Visible = false;
            pnlSubMenu2.Visible = false;
            pnlSubMenu3.Visible = false;
            pnlSubMenu4.Visible = false;
            pnlSubMenu5.Visible = false;
        }

        private void btnGestionarUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
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
        }

        private void btnGestionLibro_Click(object sender, EventArgs e)
        {
            FormEnPanel.AbrirForm<GestionLibros.frmGestionLibros>(ref pnlContenedor);
        }

        private void btnListaLibros_Click(object sender, EventArgs e)
        {
            FormEnPanel.AbrirForm<GestionLibros.listaLibros>(ref pnlContenedor);
        }

        private void btnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            FormEnPanel.AbrirForm<GestionManagers.frmGestionManagers>(ref pnlContenedor);
        }

        private void btnListaUsuarios_Click(object sender, EventArgs e)
        {
            FormEnPanel.AbrirForm<GestionManagers.listaManagers>(ref pnlContenedor);
        }
    }
}
