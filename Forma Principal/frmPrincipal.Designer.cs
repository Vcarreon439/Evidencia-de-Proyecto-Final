
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
            this.pnlEncabezadoMenu = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.btnGeneros = new System.Windows.Forms.Button();
            this.pnlSubMenu1 = new System.Windows.Forms.Panel();
            this.btnGestionGeneros = new System.Windows.Forms.Button();
            this.btnAutores = new System.Windows.Forms.Button();
            this.pnlSubMenu2 = new System.Windows.Forms.Panel();
            this.btnGestionarAutor = new System.Windows.Forms.Button();
            this.btnGestionarAutores = new System.Windows.Forms.Button();
            this.btnMiembros = new System.Windows.Forms.Button();
            this.pnlSubMenu3 = new System.Windows.Forms.Panel();
            this.btnAgregarMiembro = new System.Windows.Forms.Button();
            this.btnUpdateMiembro = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnListaMiembros = new System.Windows.Forms.Button();
            this.btnLibros = new System.Windows.Forms.Button();
            this.pnlSubMenu4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.pnlSubMenu1.SuspendLayout();
            this.pnlSubMenu2.SuspendLayout();
            this.pnlSubMenu3.SuspendLayout();
            this.pnlSubMenu4.SuspendLayout();
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
            // 
            // pnlEncabezadoMenu
            // 
            this.pnlEncabezadoMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(71)))));
            this.pnlEncabezadoMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezadoMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezadoMenu.Name = "pnlEncabezadoMenu";
            this.pnlEncabezadoMenu.Size = new System.Drawing.Size(183, 57);
            this.pnlEncabezadoMenu.TabIndex = 1;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(200, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(600, 500);
            this.pnlContenedor.TabIndex = 1;
            // 
            // btnGeneros
            // 
            this.btnGeneros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeneros.FlatAppearance.BorderSize = 0;
            this.btnGeneros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneros.ForeColor = System.Drawing.Color.White;
            this.btnGeneros.Location = new System.Drawing.Point(0, 57);
            this.btnGeneros.Name = "btnGeneros";
            this.btnGeneros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGeneros.Size = new System.Drawing.Size(183, 40);
            this.btnGeneros.TabIndex = 0;
            this.btnGeneros.Text = "Generos";
            this.btnGeneros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneros.UseVisualStyleBackColor = true;
            this.btnGeneros.Click += new System.EventHandler(this.btnGeneros_Click);
            // 
            // pnlSubMenu1
            // 
            this.pnlSubMenu1.Controls.Add(this.btnGestionGeneros);
            this.pnlSubMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenu1.Location = new System.Drawing.Point(0, 97);
            this.pnlSubMenu1.Name = "pnlSubMenu1";
            this.pnlSubMenu1.Size = new System.Drawing.Size(183, 40);
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
            this.btnGestionGeneros.Size = new System.Drawing.Size(183, 40);
            this.btnGestionGeneros.TabIndex = 0;
            this.btnGestionGeneros.Text = "Gestionar Generos";
            this.btnGestionGeneros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionGeneros.UseVisualStyleBackColor = false;
            // 
            // btnAutores
            // 
            this.btnAutores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAutores.FlatAppearance.BorderSize = 0;
            this.btnAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutores.ForeColor = System.Drawing.Color.White;
            this.btnAutores.Location = new System.Drawing.Point(0, 137);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAutores.Size = new System.Drawing.Size(183, 40);
            this.btnAutores.TabIndex = 2;
            this.btnAutores.Text = "Autores";
            this.btnAutores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutores.UseVisualStyleBackColor = true;
            this.btnAutores.Click += new System.EventHandler(this.btnAutores_Click);
            // 
            // pnlSubMenu2
            // 
            this.pnlSubMenu2.Controls.Add(this.btnGestionarAutores);
            this.pnlSubMenu2.Controls.Add(this.btnGestionarAutor);
            this.pnlSubMenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenu2.Location = new System.Drawing.Point(0, 177);
            this.pnlSubMenu2.Name = "pnlSubMenu2";
            this.pnlSubMenu2.Size = new System.Drawing.Size(183, 40);
            this.pnlSubMenu2.TabIndex = 0;
            this.pnlSubMenu2.Visible = false;
            // 
            // btnGestionarAutor
            // 
            this.btnGestionarAutor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGestionarAutor.Location = new System.Drawing.Point(0, 0);
            this.btnGestionarAutor.Name = "btnGestionarAutor";
            this.btnGestionarAutor.Size = new System.Drawing.Size(183, 40);
            this.btnGestionarAutor.TabIndex = 0;
            this.btnGestionarAutor.Text = "Gestionar Autores";
            this.btnGestionarAutor.UseVisualStyleBackColor = true;
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
            this.btnGestionarAutores.Size = new System.Drawing.Size(183, 40);
            this.btnGestionarAutores.TabIndex = 1;
            this.btnGestionarAutores.Text = "Gestionar Autores";
            this.btnGestionarAutores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarAutores.UseVisualStyleBackColor = false;
            // 
            // btnMiembros
            // 
            this.btnMiembros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMiembros.FlatAppearance.BorderSize = 0;
            this.btnMiembros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiembros.ForeColor = System.Drawing.Color.White;
            this.btnMiembros.Location = new System.Drawing.Point(0, 217);
            this.btnMiembros.Name = "btnMiembros";
            this.btnMiembros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMiembros.Size = new System.Drawing.Size(183, 40);
            this.btnMiembros.TabIndex = 3;
            this.btnMiembros.Text = "Miembros";
            this.btnMiembros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMiembros.UseVisualStyleBackColor = true;
            this.btnMiembros.Click += new System.EventHandler(this.btnMiembros_Click);
            // 
            // pnlSubMenu3
            // 
            this.pnlSubMenu3.Controls.Add(this.btnListaMiembros);
            this.pnlSubMenu3.Controls.Add(this.btnDeleteMember);
            this.pnlSubMenu3.Controls.Add(this.btnUpdateMiembro);
            this.pnlSubMenu3.Controls.Add(this.btnAgregarMiembro);
            this.pnlSubMenu3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenu3.Location = new System.Drawing.Point(0, 257);
            this.pnlSubMenu3.Name = "pnlSubMenu3";
            this.pnlSubMenu3.Size = new System.Drawing.Size(183, 160);
            this.pnlSubMenu3.TabIndex = 0;
            this.pnlSubMenu3.Visible = false;
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
            this.btnAgregarMiembro.Size = new System.Drawing.Size(183, 40);
            this.btnAgregarMiembro.TabIndex = 2;
            this.btnAgregarMiembro.Text = "Agregar miembro";
            this.btnAgregarMiembro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarMiembro.UseVisualStyleBackColor = false;
            // 
            // btnUpdateMiembro
            // 
            this.btnUpdateMiembro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(81)))));
            this.btnUpdateMiembro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateMiembro.FlatAppearance.BorderSize = 0;
            this.btnUpdateMiembro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMiembro.ForeColor = System.Drawing.Color.White;
            this.btnUpdateMiembro.Location = new System.Drawing.Point(0, 40);
            this.btnUpdateMiembro.Name = "btnUpdateMiembro";
            this.btnUpdateMiembro.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnUpdateMiembro.Size = new System.Drawing.Size(183, 40);
            this.btnUpdateMiembro.TabIndex = 3;
            this.btnUpdateMiembro.Text = "Actualizar miembro";
            this.btnUpdateMiembro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateMiembro.UseVisualStyleBackColor = false;
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(81)))));
            this.btnDeleteMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteMember.FlatAppearance.BorderSize = 0;
            this.btnDeleteMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMember.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMember.Location = new System.Drawing.Point(0, 80);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnDeleteMember.Size = new System.Drawing.Size(183, 40);
            this.btnDeleteMember.TabIndex = 4;
            this.btnDeleteMember.Text = "Eliminar miembro";
            this.btnDeleteMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteMember.UseVisualStyleBackColor = false;
            // 
            // btnListaMiembros
            // 
            this.btnListaMiembros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(81)))));
            this.btnListaMiembros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaMiembros.FlatAppearance.BorderSize = 0;
            this.btnListaMiembros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaMiembros.ForeColor = System.Drawing.Color.White;
            this.btnListaMiembros.Location = new System.Drawing.Point(0, 120);
            this.btnListaMiembros.Name = "btnListaMiembros";
            this.btnListaMiembros.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnListaMiembros.Size = new System.Drawing.Size(183, 40);
            this.btnListaMiembros.TabIndex = 5;
            this.btnListaMiembros.Text = "Lista de miembros";
            this.btnListaMiembros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaMiembros.UseVisualStyleBackColor = false;
            // 
            // btnLibros
            // 
            this.btnLibros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLibros.FlatAppearance.BorderSize = 0;
            this.btnLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibros.ForeColor = System.Drawing.Color.White;
            this.btnLibros.Location = new System.Drawing.Point(0, 417);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLibros.Size = new System.Drawing.Size(183, 40);
            this.btnLibros.TabIndex = 4;
            this.btnLibros.Text = "Libros";
            this.btnLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibros.UseVisualStyleBackColor = true;
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // pnlSubMenu4
            // 
            this.pnlSubMenu4.Controls.Add(this.button4);
            this.pnlSubMenu4.Controls.Add(this.button3);
            this.pnlSubMenu4.Controls.Add(this.button2);
            this.pnlSubMenu4.Controls.Add(this.button1);
            this.pnlSubMenu4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenu4.Location = new System.Drawing.Point(0, 457);
            this.pnlSubMenu4.Name = "pnlSubMenu4";
            this.pnlSubMenu4.Size = new System.Drawing.Size(183, 160);
            this.pnlSubMenu4.TabIndex = 0;
            this.pnlSubMenu4.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(81)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(183, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar libro";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(81)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 40);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(183, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Actualizar libro";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(81)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 80);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(183, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "Eliminar Libro";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(81)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 120);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(183, 40);
            this.button4.TabIndex = 6;
            this.button4.Text = "Lista de Libros";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
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
            this.pnlMenu.ResumeLayout(false);
            this.pnlSubMenu1.ResumeLayout(false);
            this.pnlSubMenu2.ResumeLayout(false);
            this.pnlSubMenu3.ResumeLayout(false);
            this.pnlSubMenu4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlEncabezadoMenu;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlSubMenu1;
        private System.Windows.Forms.Button btnGeneros;
        private System.Windows.Forms.Button btnGestionGeneros;
        private System.Windows.Forms.Panel pnlSubMenu2;
        private System.Windows.Forms.Button btnGestionarAutores;
        private System.Windows.Forms.Button btnGestionarAutor;
        private System.Windows.Forms.Button btnAutores;
        private System.Windows.Forms.Panel pnlSubMenu3;
        private System.Windows.Forms.Button btnListaMiembros;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnUpdateMiembro;
        private System.Windows.Forms.Button btnAgregarMiembro;
        private System.Windows.Forms.Button btnMiembros;
        private System.Windows.Forms.Panel pnlSubMenu4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLibros;
    }
}

