
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlSubMenu4 = new System.Windows.Forms.Panel();
            this.btnListaLibros = new System.Windows.Forms.Button();
            this.btnAgregarLibro = new System.Windows.Forms.Button();
            this.btnLibros = new FontAwesome.Sharp.IconButton();
            this.pnlSubMenu3 = new System.Windows.Forms.Panel();
            this.btnListaMiembros = new System.Windows.Forms.Button();
            this.btnAgregarMiembro = new System.Windows.Forms.Button();
            this.btnMiembros = new FontAwesome.Sharp.IconButton();
            this.pnlSubMenu2 = new System.Windows.Forms.Panel();
            this.btnGestionarAutores = new System.Windows.Forms.Button();
            this.btnGestionarAutor = new System.Windows.Forms.Button();
            this.btnAutores = new FontAwesome.Sharp.IconButton();
            this.pnlSubMenu1 = new System.Windows.Forms.Panel();
            this.btnGestionGeneros = new System.Windows.Forms.Button();
            this.btnGeneros = new FontAwesome.Sharp.IconButton();
            this.pnlEncabezadoMenu = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlSubMenu4.SuspendLayout();
            this.pnlSubMenu3.SuspendLayout();
            this.pnlSubMenu2.SuspendLayout();
            this.pnlSubMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.pnlMenu.Controls.Add(this.pnlSubMenu4);
            this.pnlMenu.Controls.Add(this.btnLibros);
            this.pnlMenu.Controls.Add(this.pnlSubMenu3);
            this.pnlMenu.Controls.Add(this.btnMiembros);
            this.pnlMenu.Controls.Add(this.pnlSubMenu2);
            this.pnlMenu.Controls.Add(this.btnAutores);
            this.pnlMenu.Controls.Add(this.pnlSubMenu1);
            this.pnlMenu.Controls.Add(this.btnGeneros);
            this.pnlMenu.Controls.Add(this.pnlEncabezadoMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 500);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMenu_MouseMove);
            // 
            // pnlSubMenu4
            // 
            this.pnlSubMenu4.Controls.Add(this.btnListaLibros);
            this.pnlSubMenu4.Controls.Add(this.btnAgregarLibro);
            this.pnlSubMenu4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenu4.Location = new System.Drawing.Point(0, 377);
            this.pnlSubMenu4.Name = "pnlSubMenu4";
            this.pnlSubMenu4.Size = new System.Drawing.Size(200, 80);
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
            this.btnListaLibros.Size = new System.Drawing.Size(200, 40);
            this.btnListaLibros.TabIndex = 6;
            this.btnListaLibros.Text = "Lista de Libros";
            this.btnListaLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaLibros.UseVisualStyleBackColor = false;
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(81)))));
            this.btnAgregarLibro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarLibro.FlatAppearance.BorderSize = 0;
            this.btnAgregarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarLibro.ForeColor = System.Drawing.Color.White;
            this.btnAgregarLibro.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnAgregarLibro.Size = new System.Drawing.Size(200, 40);
            this.btnAgregarLibro.TabIndex = 3;
            this.btnAgregarLibro.Text = "Agregar libro";
            this.btnAgregarLibro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarLibro.UseVisualStyleBackColor = false;
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
            this.btnLibros.Location = new System.Drawing.Point(0, 337);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLibros.Size = new System.Drawing.Size(200, 40);
            this.btnLibros.TabIndex = 1;
            this.btnLibros.Text = "Libros";
            this.btnLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLibros.UseVisualStyleBackColor = true;
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // pnlSubMenu3
            // 
            this.pnlSubMenu3.Controls.Add(this.btnListaMiembros);
            this.pnlSubMenu3.Controls.Add(this.btnAgregarMiembro);
            this.pnlSubMenu3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenu3.Location = new System.Drawing.Point(0, 257);
            this.pnlSubMenu3.Name = "pnlSubMenu3";
            this.pnlSubMenu3.Size = new System.Drawing.Size(200, 80);
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
            this.btnListaMiembros.Size = new System.Drawing.Size(200, 40);
            this.btnListaMiembros.TabIndex = 5;
            this.btnListaMiembros.Text = "Lista de miembros";
            this.btnListaMiembros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaMiembros.UseVisualStyleBackColor = false;
            this.btnListaMiembros.Click += new System.EventHandler(this.btnListaMiembros_Click);
            // 
            // btnAgregarMiembro
            // 
            this.btnAgregarMiembro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(81)))));
            this.btnAgregarMiembro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarMiembro.FlatAppearance.BorderSize = 0;
            this.btnAgregarMiembro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMiembro.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMiembro.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarMiembro.Name = "btnAgregarMiembro";
            this.btnAgregarMiembro.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnAgregarMiembro.Size = new System.Drawing.Size(200, 40);
            this.btnAgregarMiembro.TabIndex = 2;
            this.btnAgregarMiembro.Text = "Agregar miembro";
            this.btnAgregarMiembro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarMiembro.UseVisualStyleBackColor = false;
            this.btnAgregarMiembro.Click += new System.EventHandler(this.btnAgregarMiembro_Click);
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
            this.btnMiembros.Location = new System.Drawing.Point(0, 217);
            this.btnMiembros.Name = "btnMiembros";
            this.btnMiembros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMiembros.Size = new System.Drawing.Size(200, 40);
            this.btnMiembros.TabIndex = 0;
            this.btnMiembros.Text = "Miembros";
            this.btnMiembros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMiembros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMiembros.UseVisualStyleBackColor = true;
            this.btnMiembros.Click += new System.EventHandler(this.btnMiembros_Click);
            // 
            // pnlSubMenu2
            // 
            this.pnlSubMenu2.Controls.Add(this.btnGestionarAutores);
            this.pnlSubMenu2.Controls.Add(this.btnGestionarAutor);
            this.pnlSubMenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenu2.Location = new System.Drawing.Point(0, 177);
            this.pnlSubMenu2.Name = "pnlSubMenu2";
            this.pnlSubMenu2.Size = new System.Drawing.Size(200, 40);
            this.pnlSubMenu2.TabIndex = 0;
            this.pnlSubMenu2.Visible = false;
            // 
            // btnGestionarAutores
            // 
            this.btnGestionarAutores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(81)))));
            this.btnGestionarAutores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGestionarAutores.FlatAppearance.BorderSize = 0;
            this.btnGestionarAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarAutores.ForeColor = System.Drawing.Color.White;
            this.btnGestionarAutores.Location = new System.Drawing.Point(0, 0);
            this.btnGestionarAutores.Name = "btnGestionarAutores";
            this.btnGestionarAutores.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnGestionarAutores.Size = new System.Drawing.Size(200, 40);
            this.btnGestionarAutores.TabIndex = 1;
            this.btnGestionarAutores.Text = "Gestionar Autores";
            this.btnGestionarAutores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarAutores.UseVisualStyleBackColor = false;
            this.btnGestionarAutores.Click += new System.EventHandler(this.btnGestionarAutores_Click);
            // 
            // btnGestionarAutor
            // 
            this.btnGestionarAutor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGestionarAutor.Location = new System.Drawing.Point(0, 0);
            this.btnGestionarAutor.Name = "btnGestionarAutor";
            this.btnGestionarAutor.Size = new System.Drawing.Size(200, 40);
            this.btnGestionarAutor.TabIndex = 0;
            this.btnGestionarAutor.Text = "Gestionar Autores";
            this.btnGestionarAutor.UseVisualStyleBackColor = true;
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
            this.btnAutores.Location = new System.Drawing.Point(0, 137);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAutores.Size = new System.Drawing.Size(200, 40);
            this.btnAutores.TabIndex = 3;
            this.btnAutores.Text = "Autores";
            this.btnAutores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAutores.UseVisualStyleBackColor = true;
            this.btnAutores.Click += new System.EventHandler(this.btnAutores_Click);
            // 
            // pnlSubMenu1
            // 
            this.pnlSubMenu1.Controls.Add(this.btnGestionGeneros);
            this.pnlSubMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenu1.Location = new System.Drawing.Point(0, 97);
            this.pnlSubMenu1.Name = "pnlSubMenu1";
            this.pnlSubMenu1.Size = new System.Drawing.Size(200, 40);
            this.pnlSubMenu1.TabIndex = 0;
            this.pnlSubMenu1.Visible = false;
            // 
            // btnGestionGeneros
            // 
            this.btnGestionGeneros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(81)))));
            this.btnGestionGeneros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGestionGeneros.FlatAppearance.BorderSize = 0;
            this.btnGestionGeneros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionGeneros.ForeColor = System.Drawing.Color.White;
            this.btnGestionGeneros.Location = new System.Drawing.Point(0, 0);
            this.btnGestionGeneros.Name = "btnGestionGeneros";
            this.btnGestionGeneros.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnGestionGeneros.Size = new System.Drawing.Size(200, 40);
            this.btnGestionGeneros.TabIndex = 0;
            this.btnGestionGeneros.Text = "Gestionar Generos";
            this.btnGestionGeneros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionGeneros.UseVisualStyleBackColor = false;
            this.btnGestionGeneros.Click += new System.EventHandler(this.btnGestionGeneros_Click);
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
            this.btnGeneros.Location = new System.Drawing.Point(0, 57);
            this.btnGeneros.Name = "btnGeneros";
            this.btnGeneros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGeneros.Size = new System.Drawing.Size(200, 40);
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
            this.pnlEncabezadoMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezadoMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezadoMenu.Name = "pnlEncabezadoMenu";
            this.pnlEncabezadoMenu.Size = new System.Drawing.Size(200, 57);
            this.pnlEncabezadoMenu.TabIndex = 1;
            this.pnlEncabezadoMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlEncabezadoMenu_MouseMove);
            // 
            // pnlContenedor
            // 
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
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlSubMenu4.ResumeLayout(false);
            this.pnlSubMenu3.ResumeLayout(false);
            this.pnlSubMenu2.ResumeLayout(false);
            this.pnlSubMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlEncabezadoMenu;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlSubMenu1;
        private System.Windows.Forms.Button btnGestionGeneros;
        private System.Windows.Forms.Panel pnlSubMenu2;
        private System.Windows.Forms.Button btnGestionarAutores;
        private System.Windows.Forms.Button btnGestionarAutor;
        private System.Windows.Forms.Panel pnlSubMenu3;
        private System.Windows.Forms.Button btnListaMiembros;
        private System.Windows.Forms.Button btnAgregarMiembro;
        private System.Windows.Forms.Panel pnlSubMenu4;
        private System.Windows.Forms.Button btnListaLibros;
        private System.Windows.Forms.Button btnAgregarLibro;
        private FontAwesome.Sharp.IconButton btnMiembros;
        private FontAwesome.Sharp.IconButton btnLibros;
        private FontAwesome.Sharp.IconButton btnAutores;
        private FontAwesome.Sharp.IconButton btnGeneros;
    }
}

