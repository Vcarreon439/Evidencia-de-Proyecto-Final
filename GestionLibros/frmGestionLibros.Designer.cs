
namespace GestionLibros
{
    partial class frmGestionLibros
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.cboTema = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pctImgLibro = new System.Windows.Forms.PictureBox();
            this.numEdicion = new System.Windows.Forms.NumericUpDown();
            this.numCopias = new System.Windows.Forms.NumericUpDown();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.cboEditorial = new System.Windows.Forms.ComboBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImgLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEdicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCopias)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnInsertar);
            this.panel1.Controls.Add(this.dgvLibros);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cboTema);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pctImgLibro);
            this.panel1.Controls.Add(this.numEdicion);
            this.panel1.Controls.Add(this.numCopias);
            this.panel1.Controls.Add(this.txtISBN);
            this.panel1.Controls.Add(this.txtTitulo);
            this.panel1.Controls.Add(this.cboEditorial);
            this.panel1.Controls.Add(this.txtLugar);
            this.panel1.Controls.Add(this.txtAño);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 500);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(482, 241);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(106, 23);
            this.btnInsertar.TabIndex = 18;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // dgvLibros
            // 
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(12, 286);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.Size = new System.Drawing.Size(576, 202);
            this.dgvLibros.TabIndex = 17;
            this.dgvLibros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibros_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Numero de edicion";
            // 
            // cboTema
            // 
            this.cboTema.FormattingEnabled = true;
            this.cboTema.Location = new System.Drawing.Point(278, 165);
            this.cboTema.Name = "cboTema";
            this.cboTema.Size = new System.Drawing.Size(121, 21);
            this.cboTema.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Copias";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Lugar de edición";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tema";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Año de edicion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Editorial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ISBN";
            // 
            // pctImgLibro
            // 
            this.pctImgLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctImgLibro.Location = new System.Drawing.Point(14, 14);
            this.pctImgLibro.Name = "pctImgLibro";
            this.pctImgLibro.Size = new System.Drawing.Size(189, 250);
            this.pctImgLibro.TabIndex = 7;
            this.pctImgLibro.TabStop = false;
            // 
            // numEdicion
            // 
            this.numEdicion.Location = new System.Drawing.Point(456, 168);
            this.numEdicion.Name = "numEdicion";
            this.numEdicion.Size = new System.Drawing.Size(132, 20);
            this.numEdicion.TabIndex = 6;
            // 
            // numCopias
            // 
            this.numCopias.Location = new System.Drawing.Point(456, 121);
            this.numCopias.Name = "numCopias";
            this.numCopias.Size = new System.Drawing.Size(132, 20);
            this.numCopias.TabIndex = 5;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(451, 79);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(137, 20);
            this.txtISBN.TabIndex = 4;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(226, 41);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(362, 20);
            this.txtTitulo.TabIndex = 3;
            // 
            // cboEditorial
            // 
            this.cboEditorial.FormattingEnabled = true;
            this.cboEditorial.Location = new System.Drawing.Point(278, 79);
            this.cboEditorial.Name = "cboEditorial";
            this.cboEditorial.Size = new System.Drawing.Size(121, 21);
            this.cboEditorial.TabIndex = 2;
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(226, 244);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(234, 20);
            this.txtLugar.TabIndex = 1;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(307, 121);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(92, 20);
            this.txtAño.TabIndex = 0;
            // 
            // frmGestionLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionLibros";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmGestionLibros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImgLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEdicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCopias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctImgLibro;
        private System.Windows.Forms.NumericUpDown numEdicion;
        private System.Windows.Forms.NumericUpDown numCopias;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ComboBox cboEditorial;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboTema;
        private System.Windows.Forms.Button btnInsertar;
    }
}

