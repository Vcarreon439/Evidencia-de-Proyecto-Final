
namespace Forma_Principal
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlSubMenu6 = new System.Windows.Forms.Panel();
            this.btnGestionarEditoriales = new System.Windows.Forms.Button();
            this.btnEditorial = new FontAwesome.Sharp.IconButton();
            this.pnlSubMenu5 = new System.Windows.Forms.Panel();
            this.btnGestionarUsuarios = new System.Windows.Forms.Button();
            this.btnManagers = new FontAwesome.Sharp.IconButton();
            this.pnlSubMenu4 = new System.Windows.Forms.Panel();
            this.btnListaLibros = new System.Windows.Forms.Button();
            this.btnGestionLibro = new System.Windows.Forms.Button();
            this.btnLibros = new FontAwesome.Sharp.IconButton();
            this.pnlSubMenu3 = new System.Windows.Forms.Panel();
            this.btnListaMiembros = new System.Windows.Forms.Button();
            this.btnGestionarMiembro = new System.Windows.Forms.Button();
            this.btnMiembros = new FontAwesome.Sharp.IconButton();
            this.pnlSubMenu2 = new System.Windows.Forms.Panel();
            this.btnListaAutores = new System.Windows.Forms.Button();
            this.btnGestionarAutor = new System.Windows.Forms.Button();
            this.btnAutores = new FontAwesome.Sharp.IconButton();
            this.pnlSubMenu1 = new System.Windows.Forms.Panel();
            this.btnListaGeneros = new System.Windows.Forms.Button();
            this.btnGestionGeneros = new System.Windows.Forms.Button();
            this.btnGeneros = new FontAwesome.Sharp.IconButton();
            this.pnlEncabezadoMenu = new System.Windows.Forms.Panel();
            this.btnIconoTitulo = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cboTipoUsuario = new System.Windows.Forms.ComboBox();
            this.btnSlide = new FontAwesome.Sharp.IconButton();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlSubMenu6.SuspendLayout();
            this.pnlSubMenu5.SuspendLayout();
            this.pnlSubMenu4.SuspendLayout();
            this.pnlSubMenu3.SuspendLayout();
            this.pnlSubMenu2.SuspendLayout();
            this.pnlSubMenu1.SuspendLayout();
            this.pnlEncabezadoMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.pnlMenu.Controls.Add(this.pnlSubMenu6);
            this.pnlMenu.Controls.Add(this.btnEditorial);
            this.pnlMenu.Controls.Add(this.pnlSubMenu5);
            this.pnlMenu.Controls.Add(this.btnManagers);
            this.pnlMenu.Controls.Add(this.pnlSubMenu4);
            this.pnlMenu.Controls.Add(this.btnLibros);
            this.pnlMenu.Controls.Add(this.pnlSubMenu3);
            this.pnlMenu.Controls.Add(this.btnMiembros);
            this.pnlMenu.Controls.Add(this.pnlSubMenu2);
            this.pnlMenu.Controls.Add(this.btnAutores);
            this.pnlMenu.Controls.Add(this.pnlSubMenu1);
            this.pnlMenu.Controls.Add(this.btnGeneros);
            this.pnlMenu.Controls.Add(this.pnlEncabezadoMenu);
            this.pnlMenu.Controls.Add(this.cboTipoUsuario);
            this.pnlMenu.Controls.Add(this.btnSlide);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 500);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMenu_MouseMove);
            // 
            // pnlSubMenu6
            // 
            this.pnlSubMenu6.AutoSize = true;
            this.pnlSubMenu6.Controls.Add(this.btnGestionarEditoriales);
            this.pnlSubMenu6.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenu6.Location = new System.Drawing.Point(0, 725);
            this.pnlSubMenu6.Name = "pnlSubMenu6";
            this.pnlSubMenu6.Size = new System.Drawing.Size(183, 40);
            this.pnlSubMenu6.TabIndex = 0;
            this.pnlSubMenu6.Visible = false;
            // 
            // btnGestionarEditoriales
            // 
            this.btnGestionarEditoriales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(81)))));
            this.btnGestionarEditoriales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarEditoriales.FlatAppearance.BorderSize = 0;
            this.btnGestionarEditoriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarEditoriales.ForeColor = System.Drawing.Color.White;
            this.btnGestionarEditoriales.Location = new System.Drawing.Point(0, 0);
            this.btnGestionarEditoriales.Name = "btnGestionarEditoriales";
            this.btnGestionarEditoriales.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnGestionarEditoriales.Size = new System.Drawing.Size(183, 40);
            this.btnGestionarEditoriales.TabIndex = 5;
            this.btnGestionarEditoriales.Text = "Gestionar Editoriales";
            this.btnGestionarEditoriales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarEditoriales.UseVisualStyleBackColor = false;
            this.btnGestionarEditoriales.Click += new System.EventHandler(this.btnGestionarEditoriales_Click);
            // 
            // btnEditorial
            // 
            this.btnEditorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditorial.FlatAppearance.BorderSize = 0;
            this.btnEditorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditorial.ForeColor = System.Drawing.Color.White;
            this.btnEditorial.IconChar = FontAwesome.Sharp.IconChar.Underline;
            this.btnEditorial.IconColor = System.Drawing.Color.White;
            this.btnEditorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditorial.IconSize = 30;
            this.btnEditorial.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnEditorial.Location = new System.Drawing.Point(0, 685);
            this.btnEditorial.Name = "btnEditorial";
            this.btnEditorial.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEditorial.Size = new System.Drawing.Size(183, 40);
            this.btnEditorial.TabIndex = 5;
            this.btnEditorial.Text = "Editorial";
            this.btnEditorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditorial.UseVisualStyleBackColor = true;
            this.btnEditorial.Click += new System.EventHandler(this.btnEditorial_Click);
            // 
            // pnlSubMenu5
            // 
            this.pnlSubMenu5.AutoSize = true;
            this.pnlSubMenu5.Controls.Add(this.btnGestionarUsuarios);
            this.pnlSubMenu5.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenu5.Location = new System.Drawing.Point(0, 645);
            this.pnlSubMenu5.Name = "pnlSubMenu5";
            this.pnlSubMenu5.Size = new System.Drawing.Size(183, 40);
            this.pnlSubMenu5.TabIndex = 0;
            this.pnlSubMenu5.Visible = false;
            // 
            // btnGestionarUsuarios
            // 
            this.btnGestionarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(81)))));
            this.btnGestionarUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarUsuarios.FlatAppearance.BorderSize = 0;
            this.btnGestionarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnGestionarUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnGestionarUsuarios.Name = "btnGestionarUsuarios";
            this.btnGestionarUsuarios.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnGestionarUsuarios.Size = new System.Drawing.Size(183, 40);
            this.btnGestionarUsuarios.TabIndex = 4;
            this.btnGestionarUsuarios.Text = "Gestionar Usuarios";
            this.btnGestionarUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarUsuarios.UseVisualStyleBackColor = false;
            this.btnGestionarUsuarios.Click += new System.EventHandler(this.btnGestionarUsuarios_Click);
            // 
            // btnManagers
            // 
            this.btnManagers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagers.FlatAppearance.BorderSize = 0;
            this.btnManagers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagers.ForeColor = System.Drawing.Color.White;
            this.btnManagers.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            this.btnManagers.IconColor = System.Drawing.Color.White;
            this.btnManagers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnManagers.IconSize = 30;
            this.btnManagers.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnManagers.Location = new System.Drawing.Point(0, 605);
            this.btnManagers.Name = "btnManagers";
            this.btnManagers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManagers.Size = new System.Drawing.Size(183, 40);
            this.btnManagers.TabIndex = 4;
            this.btnManagers.Text = "Usuarios";
            this.btnManagers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManagers.UseVisualStyleBackColor = true;
            this.btnManagers.Click += new System.EventHandler(this.btnManagers_Click);
            // 
            // pnlSubMenu4
            // 
            this.pnlSubMenu4.AutoSize = true;
            this.pnlSubMenu4.Controls.Add(this.btnListaLibros);
            this.pnlSubMenu4.Controls.Add(this.btnGestionLibro);
            this.pnlSubMenu4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenu4.Location = new System.Drawing.Point(0, 525);
            this.pnlSubMenu4.Name = "pnlSubMenu4";
            this.pnlSubMenu4.Size = new System.Drawing.Size(183, 80);
            this.pnlSubMenu4.TabIndex = 0;
            this.pnlSubMenu4.Visible = false;
            // 
            // btnListaLibros
            // 
            this.btnListaLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(81)))));
            this.btnListaLibros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaLibros.FlatAppearance.BorderSize = 0;
            this.btnListaLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaLibros.ForeColor = System.Drawing.Color.White;
            this.btnListaLibros.Location = new System.Drawing.Point(0, 40);
            this.btnListaLibros.Name = "btnListaLibros";
            this.btnListaLibros.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnListaLibros.Size = new System.Drawing.Size(183, 40);
            this.btnListaLibros.TabIndex = 6;
            this.btnListaLibros.Text = "Lista de Libros";
            this.btnListaLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaLibros.UseVisualStyleBackColor = false;
            this.btnListaLibros.Click += new System.EventHandler(this.btnListaLibros_Click);
            // 
            // btnGestionLibro
            // 
            this.btnGestionLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(81)))));
            this.btnGestionLibro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionLibro.FlatAppearance.BorderSize = 0;
            this.btnGestionLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionLibro.ForeColor = System.Drawing.Color.White;
            this.btnGestionLibro.Location = new System.Drawing.Point(0, 0);
            this.btnGestionLibro.Name = "btnGestionLibro";
            this.btnGestionLibro.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnGestionLibro.Size = new System.Drawing.Size(183, 40);
            this.btnGestionLibro.TabIndex = 3;
            this.btnGestionLibro.Text = "Gestion Libros";
            this.btnGestionLibro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionLibro.UseVisualStyleBackColor = false;
            this.btnGestionLibro.Click += new System.EventHandler(this.btnGestionLibro_Click);
            // 
            // btnLibros
            // 
            this.btnLibros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLibros.FlatAppearance.BorderSize = 0;
            this.btnLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibros.ForeColor = System.Drawing.Color.White;
            this.btnLibros.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnLibros.IconColor = System.Drawing.Color.White;
            this.btnLibros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLibros.IconSize = 30;
            this.btnLibros.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLibros.Location = new System.Drawing.Point(0, 485);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLibros.Size = new System.Drawing.Size(183, 40);
            this.btnLibros.TabIndex = 1;
            this.btnLibros.Text = "Libros";
            this.btnLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLibros.UseVisualStyleBackColor = true;
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // pnlSubMenu3
            // 
            this.pnlSubMenu3.AutoSize = true;
            this.pnlSubMenu3.Controls.Add(this.btnListaMiembros);
            this.pnlSubMenu3.Controls.Add(this.btnGestionarMiembro);
            this.pnlSubMenu3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenu3.Location = new System.Drawing.Point(0, 405);
            this.pnlSubMenu3.Name = "pnlSubMenu3";
            this.pnlSubMenu3.Size = new System.Drawing.Size(183, 80);
            this.pnlSubMenu3.TabIndex = 0;
            this.pnlSubMenu3.Visible = false;
            // 
            // btnListaMiembros
            // 
            this.btnListaMiembros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(81)))));
            this.btnListaMiembros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaMiembros.FlatAppearance.BorderSize = 0;
            this.btnListaMiembros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaMiembros.ForeColor = System.Drawing.Color.White;
            this.btnListaMiembros.Location = new System.Drawing.Point(0, 40);
            this.btnListaMiembros.Name = "btnListaMiembros";
            this.btnListaMiembros.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnListaMiembros.Size = new System.Drawing.Size(183, 40);
            this.btnListaMiembros.TabIndex = 5;
            this.btnListaMiembros.Text = "Lista de miembros";
            this.btnListaMiembros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaMiembros.UseVisualStyleBackColor = false;
            this.btnListaMiembros.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnListaMiembros_MouseClick);
            // 
            // btnGestionarMiembro
            // 
            this.btnGestionarMiembro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(81)))));
            this.btnGestionarMiembro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarMiembro.FlatAppearance.BorderSize = 0;
            this.btnGestionarMiembro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarMiembro.ForeColor = System.Drawing.Color.White;
            this.btnGestionarMiembro.Location = new System.Drawing.Point(0, 0);
            this.btnGestionarMiembro.Name = "btnGestionarMiembro";
            this.btnGestionarMiembro.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnGestionarMiembro.Size = new System.Drawing.Size(183, 40);
            this.btnGestionarMiembro.TabIndex = 2;
            this.btnGestionarMiembro.Text = "Gestionar Miembros";
            this.btnGestionarMiembro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarMiembro.UseVisualStyleBackColor = false;
            this.btnGestionarMiembro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnGestionarMiembro_MouseClick);
            // 
            // btnMiembros
            // 
            this.btnMiembros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMiembros.FlatAppearance.BorderSize = 0;
            this.btnMiembros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiembros.ForeColor = System.Drawing.Color.White;
            this.btnMiembros.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnMiembros.IconColor = System.Drawing.Color.White;
            this.btnMiembros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMiembros.IconSize = 30;
            this.btnMiembros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMiembros.Location = new System.Drawing.Point(0, 365);
            this.btnMiembros.Name = "btnMiembros";
            this.btnMiembros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMiembros.Size = new System.Drawing.Size(183, 40);
            this.btnMiembros.TabIndex = 0;
            this.btnMiembros.Text = "Miembros";
            this.btnMiembros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMiembros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMiembros.UseVisualStyleBackColor = true;
            this.btnMiembros.Click += new System.EventHandler(this.btnMiembros_Click);
            // 
            // pnlSubMenu2
            // 
            this.pnlSubMenu2.AutoSize = true;
            this.pnlSubMenu2.Controls.Add(this.btnListaAutores);
            this.pnlSubMenu2.Controls.Add(this.btnGestionarAutor);
            this.pnlSubMenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenu2.Location = new System.Drawing.Point(0, 285);
            this.pnlSubMenu2.Name = "pnlSubMenu2";
            this.pnlSubMenu2.Size = new System.Drawing.Size(183, 80);
            this.pnlSubMenu2.TabIndex = 0;
            this.pnlSubMenu2.Visible = false;
            // 
            // btnListaAutores
            // 
            this.btnListaAutores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(81)))));
            this.btnListaAutores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaAutores.FlatAppearance.BorderSize = 0;
            this.btnListaAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaAutores.ForeColor = System.Drawing.Color.White;
            this.btnListaAutores.Location = new System.Drawing.Point(0, 40);
            this.btnListaAutores.Name = "btnListaAutores";
            this.btnListaAutores.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnListaAutores.Size = new System.Drawing.Size(183, 40);
            this.btnListaAutores.TabIndex = 2;
            this.btnListaAutores.Text = "Lista Autores";
            this.btnListaAutores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaAutores.UseVisualStyleBackColor = false;
            this.btnListaAutores.Click += new System.EventHandler(this.btnListaAutores_Click);
            // 
            // btnGestionarAutor
            // 
            this.btnGestionarAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(81)))));
            this.btnGestionarAutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarAutor.FlatAppearance.BorderSize = 0;
            this.btnGestionarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarAutor.ForeColor = System.Drawing.Color.White;
            this.btnGestionarAutor.Location = new System.Drawing.Point(0, 0);
            this.btnGestionarAutor.Name = "btnGestionarAutor";
            this.btnGestionarAutor.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnGestionarAutor.Size = new System.Drawing.Size(183, 40);
            this.btnGestionarAutor.TabIndex = 1;
            this.btnGestionarAutor.Text = "Gestionar Autores";
            this.btnGestionarAutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarAutor.UseVisualStyleBackColor = false;
            this.btnGestionarAutor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnGestionarAutores_MouseClick);
            // 
            // btnAutores
            // 
            this.btnAutores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAutores.FlatAppearance.BorderSize = 0;
            this.btnAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutores.ForeColor = System.Drawing.Color.White;
            this.btnAutores.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnAutores.IconColor = System.Drawing.Color.White;
            this.btnAutores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAutores.IconSize = 30;
            this.btnAutores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutores.Location = new System.Drawing.Point(0, 245);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAutores.Size = new System.Drawing.Size(183, 40);
            this.btnAutores.TabIndex = 3;
            this.btnAutores.Text = "Autores";
            this.btnAutores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAutores.UseVisualStyleBackColor = true;
            this.btnAutores.Click += new System.EventHandler(this.btnAutores_Click);
            // 
            // pnlSubMenu1
            // 
            this.pnlSubMenu1.AutoSize = true;
            this.pnlSubMenu1.Controls.Add(this.btnListaGeneros);
            this.pnlSubMenu1.Controls.Add(this.btnGestionGeneros);
            this.pnlSubMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenu1.Location = new System.Drawing.Point(0, 165);
            this.pnlSubMenu1.Name = "pnlSubMenu1";
            this.pnlSubMenu1.Size = new System.Drawing.Size(183, 80);
            this.pnlSubMenu1.TabIndex = 0;
            this.pnlSubMenu1.Visible = false;
            // 
            // btnListaGeneros
            // 
            this.btnListaGeneros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(81)))));
            this.btnListaGeneros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaGeneros.FlatAppearance.BorderSize = 0;
            this.btnListaGeneros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaGeneros.ForeColor = System.Drawing.Color.White;
            this.btnListaGeneros.Location = new System.Drawing.Point(0, 40);
            this.btnListaGeneros.Name = "btnListaGeneros";
            this.btnListaGeneros.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnListaGeneros.Size = new System.Drawing.Size(183, 40);
            this.btnListaGeneros.TabIndex = 1;
            this.btnListaGeneros.Text = "Lista Generos";
            this.btnListaGeneros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaGeneros.UseVisualStyleBackColor = false;
            this.btnListaGeneros.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnListaGeneros_MouseClick);
            // 
            // btnGestionGeneros
            // 
            this.btnGestionGeneros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(81)))));
            this.btnGestionGeneros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionGeneros.FlatAppearance.BorderSize = 0;
            this.btnGestionGeneros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionGeneros.ForeColor = System.Drawing.Color.White;
            this.btnGestionGeneros.Location = new System.Drawing.Point(0, 0);
            this.btnGestionGeneros.Name = "btnGestionGeneros";
            this.btnGestionGeneros.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnGestionGeneros.Size = new System.Drawing.Size(183, 40);
            this.btnGestionGeneros.TabIndex = 0;
            this.btnGestionGeneros.Text = "Gestionar Generos";
            this.btnGestionGeneros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionGeneros.UseVisualStyleBackColor = false;
            this.btnGestionGeneros.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnGestionGeneros_MouseClick);
            // 
            // btnGeneros
            // 
            this.btnGeneros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeneros.FlatAppearance.BorderSize = 0;
            this.btnGeneros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneros.ForeColor = System.Drawing.Color.White;
            this.btnGeneros.IconChar = FontAwesome.Sharp.IconChar.Swatchbook;
            this.btnGeneros.IconColor = System.Drawing.Color.White;
            this.btnGeneros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGeneros.IconSize = 30;
            this.btnGeneros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneros.Location = new System.Drawing.Point(0, 125);
            this.btnGeneros.Name = "btnGeneros";
            this.btnGeneros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGeneros.Size = new System.Drawing.Size(183, 40);
            this.btnGeneros.TabIndex = 2;
            this.btnGeneros.Text = "Generos";
            this.btnGeneros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGeneros.UseVisualStyleBackColor = true;
            this.btnGeneros.Click += new System.EventHandler(this.btnGeneros_Click);
            // 
            // pnlEncabezadoMenu
            // 
            this.pnlEncabezadoMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(71)))));
            this.pnlEncabezadoMenu.Controls.Add(this.btnIconoTitulo);
            this.pnlEncabezadoMenu.Controls.Add(this.lblTitulo);
            this.pnlEncabezadoMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezadoMenu.Location = new System.Drawing.Point(0, 68);
            this.pnlEncabezadoMenu.Name = "pnlEncabezadoMenu";
            this.pnlEncabezadoMenu.Size = new System.Drawing.Size(183, 57);
            this.pnlEncabezadoMenu.TabIndex = 1;
            this.pnlEncabezadoMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlEncabezadoMenu_MouseMove);
            // 
            // btnIconoTitulo
            // 
            this.btnIconoTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIconoTitulo.FlatAppearance.BorderSize = 0;
            this.btnIconoTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIconoTitulo.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnIconoTitulo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.btnIconoTitulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconoTitulo.IconSize = 40;
            this.btnIconoTitulo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIconoTitulo.Location = new System.Drawing.Point(123, 0);
            this.btnIconoTitulo.Name = "btnIconoTitulo";
            this.btnIconoTitulo.Size = new System.Drawing.Size(60, 57);
            this.btnIconoTitulo.TabIndex = 0;
            this.btnIconoTitulo.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitulo.Size = new System.Drawing.Size(123, 57);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Biblioteca";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboTipoUsuario
            // 
            this.cboTipoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.cboTipoUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoUsuario.ForeColor = System.Drawing.Color.White;
            this.cboTipoUsuario.FormattingEnabled = true;
            this.cboTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Manager",
            "Usuario",
            "Invitado"});
            this.cboTipoUsuario.Location = new System.Drawing.Point(0, 40);
            this.cboTipoUsuario.Name = "cboTipoUsuario";
            this.cboTipoUsuario.Size = new System.Drawing.Size(183, 28);
            this.cboTipoUsuario.TabIndex = 0;
            this.cboTipoUsuario.Visible = false;
            this.cboTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.cboTipoUsuario_SelectedIndexChanged);
            // 
            // btnSlide
            // 
            this.btnSlide.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSlide.FlatAppearance.BorderSize = 0;
            this.btnSlide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlide.ForeColor = System.Drawing.Color.White;
            this.btnSlide.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnSlide.IconColor = System.Drawing.Color.White;
            this.btnSlide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSlide.IconSize = 25;
            this.btnSlide.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSlide.Location = new System.Drawing.Point(0, 0);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSlide.Size = new System.Drawing.Size(183, 40);
            this.btnSlide.TabIndex = 6;
            this.btnSlide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSlide.UseVisualStyleBackColor = true;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.AutoSize = true;
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(200, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(600, 500);
            this.pnlContenedor.TabIndex = 1;
            this.pnlContenedor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlContenedor_MouseMove);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Gestion Biblioteca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlSubMenu6.ResumeLayout(false);
            this.pnlSubMenu5.ResumeLayout(false);
            this.pnlSubMenu4.ResumeLayout(false);
            this.pnlSubMenu3.ResumeLayout(false);
            this.pnlSubMenu2.ResumeLayout(false);
            this.pnlSubMenu1.ResumeLayout(false);
            this.pnlEncabezadoMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlEncabezadoMenu;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlSubMenu1;
        private System.Windows.Forms.Button btnGestionGeneros;
        private System.Windows.Forms.Panel pnlSubMenu2;
        private System.Windows.Forms.Button btnGestionarAutor;
        private System.Windows.Forms.Panel pnlSubMenu3;
        private System.Windows.Forms.Button btnListaMiembros;
        private System.Windows.Forms.Button btnGestionarMiembro;
        private System.Windows.Forms.Panel pnlSubMenu4;
        private System.Windows.Forms.Button btnListaLibros;
        private System.Windows.Forms.Button btnGestionLibro;
        private FontAwesome.Sharp.IconButton btnMiembros;
        private FontAwesome.Sharp.IconButton btnLibros;
        private FontAwesome.Sharp.IconButton btnAutores;
        private FontAwesome.Sharp.IconButton btnGeneros;
        private System.Windows.Forms.ComboBox cboTipoUsuario;
        private System.Windows.Forms.Button btnListaGeneros;
        private System.Windows.Forms.Button btnListaAutores;
        private System.Windows.Forms.Panel pnlSubMenu5;
        private System.Windows.Forms.Button btnGestionarUsuarios;
        private FontAwesome.Sharp.IconButton btnManagers;
        private System.Windows.Forms.Panel pnlSubMenu6;
        private System.Windows.Forms.Button btnGestionarEditoriales;
        private FontAwesome.Sharp.IconButton btnEditorial;
        private FontAwesome.Sharp.IconButton btnSlide;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnIconoTitulo;
    }
}

