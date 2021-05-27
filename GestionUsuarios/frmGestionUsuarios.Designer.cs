
namespace GestionUsuarios
{
    partial class frmGestionUsuarios
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
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label domicilioLabel;
            System.Windows.Forms.Label entidadLabel;
            System.Windows.Forms.Label nacimientoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label cURPLabel;
            System.Windows.Forms.Label label1;
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.btnAddFoto = new System.Windows.Forms.Button();
            this.cURPTextBox = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.pctUsuario = new System.Windows.Forms.PictureBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.domicilioTextBox = new System.Windows.Forms.TextBox();
            this.entidadComboBox = new System.Windows.Forms.ComboBox();
            this.nacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.btnLista = new System.Windows.Forms.Button();
            apellidosLabel = new System.Windows.Forms.Label();
            domicilioLabel = new System.Windows.Forms.Label();
            entidadLabel = new System.Windows.Forms.Label();
            nacimientoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            cURPLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(262, 170);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(52, 13);
            apellidosLabel.TabIndex = 0;
            apellidosLabel.Text = "Apellidos:";
            // 
            // domicilioLabel
            // 
            domicilioLabel.AutoSize = true;
            domicilioLabel.Location = new System.Drawing.Point(527, 277);
            domicilioLabel.Name = "domicilioLabel";
            domicilioLabel.Size = new System.Drawing.Size(52, 13);
            domicilioLabel.TabIndex = 4;
            domicilioLabel.Text = "Domicilio:";
            // 
            // entidadLabel
            // 
            entidadLabel.AutoSize = true;
            entidadLabel.Location = new System.Drawing.Point(346, 68);
            entidadLabel.Name = "entidadLabel";
            entidadLabel.Size = new System.Drawing.Size(46, 13);
            entidadLabel.TabIndex = 6;
            entidadLabel.Text = "Entidad:";
            // 
            // nacimientoLabel
            // 
            nacimientoLabel.AutoSize = true;
            nacimientoLabel.Location = new System.Drawing.Point(262, 240);
            nacimientoLabel.Name = "nacimientoLabel";
            nacimientoLabel.Size = new System.Drawing.Size(111, 13);
            nacimientoLabel.TabIndex = 8;
            nacimientoLabel.Text = "Fecha de Nacimiento:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(262, 115);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 10;
            nombreLabel.Text = "Nombre:";
            // 
            // cURPLabel
            // 
            cURPLabel.AutoSize = true;
            cURPLabel.Location = new System.Drawing.Point(433, 35);
            cURPLabel.Name = "cURPLabel";
            cURPLabel.Size = new System.Drawing.Size(40, 13);
            cURPLabel.TabIndex = 19;
            cURPLabel.Text = "CURP:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(346, 95);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(34, 13);
            label1.TabIndex = 23;
            label1.Text = "Sexo:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnLista);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.cboSexo);
            this.panel1.Controls.Add(this.btnAddFoto);
            this.panel1.Controls.Add(cURPLabel);
            this.panel1.Controls.Add(this.cURPTextBox);
            this.panel1.Controls.Add(this.btnInsertar);
            this.panel1.Controls.Add(this.pctUsuario);
            this.panel1.Controls.Add(apellidosLabel);
            this.panel1.Controls.Add(this.apellidosTextBox);
            this.panel1.Controls.Add(domicilioLabel);
            this.panel1.Controls.Add(this.domicilioTextBox);
            this.panel1.Controls.Add(entidadLabel);
            this.panel1.Controls.Add(this.entidadComboBox);
            this.panel1.Controls.Add(nacimientoLabel);
            this.panel1.Controls.Add(this.nacimientoDateTimePicker);
            this.panel1.Controls.Add(nombreLabel);
            this.panel1.Controls.Add(this.nombreTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 500);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cboSexo.Location = new System.Drawing.Point(398, 92);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(178, 21);
            this.cboSexo.TabIndex = 24;
            // 
            // btnAddFoto
            // 
            this.btnAddFoto.Location = new System.Drawing.Point(12, 293);
            this.btnAddFoto.Name = "btnAddFoto";
            this.btnAddFoto.Size = new System.Drawing.Size(132, 45);
            this.btnAddFoto.TabIndex = 22;
            this.btnAddFoto.Text = "Agregar foto";
            this.btnAddFoto.UseVisualStyleBackColor = true;
            this.btnAddFoto.Click += new System.EventHandler(this.btnAddFoto_Click);
            // 
            // cURPTextBox
            // 
            this.cURPTextBox.Location = new System.Drawing.Point(479, 32);
            this.cURPTextBox.Name = "cURPTextBox";
            this.cURPTextBox.Size = new System.Drawing.Size(100, 20);
            this.cURPTextBox.TabIndex = 20;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(12, 344);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(132, 45);
            this.btnInsertar.TabIndex = 16;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // pctUsuario
            // 
            this.pctUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctUsuario.Location = new System.Drawing.Point(12, 13);
            this.pctUsuario.Name = "pctUsuario";
            this.pctUsuario.Size = new System.Drawing.Size(233, 248);
            this.pctUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctUsuario.TabIndex = 14;
            this.pctUsuario.TabStop = false;
            this.pctUsuario.DragDrop += new System.Windows.Forms.DragEventHandler(this.pctUsuario_DragDrop);
            this.pctUsuario.DragEnter += new System.Windows.Forms.DragEventHandler(this.pctUsuario_DragEnter);
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.Location = new System.Drawing.Point(265, 192);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(314, 20);
            this.apellidosTextBox.TabIndex = 1;
            // 
            // domicilioTextBox
            // 
            this.domicilioTextBox.Location = new System.Drawing.Point(150, 293);
            this.domicilioTextBox.Multiline = true;
            this.domicilioTextBox.Name = "domicilioTextBox";
            this.domicilioTextBox.Size = new System.Drawing.Size(429, 185);
            this.domicilioTextBox.TabIndex = 5;
            // 
            // entidadComboBox
            // 
            this.entidadComboBox.FormattingEnabled = true;
            this.entidadComboBox.Items.AddRange(new object[] {
            "Coahuila de Zaragoza",
            "Durango"});
            this.entidadComboBox.Location = new System.Drawing.Point(398, 65);
            this.entidadComboBox.Name = "entidadComboBox";
            this.entidadComboBox.Size = new System.Drawing.Size(178, 21);
            this.entidadComboBox.TabIndex = 7;
            // 
            // nacimientoDateTimePicker
            // 
            this.nacimientoDateTimePicker.Location = new System.Drawing.Point(379, 234);
            this.nacimientoDateTimePicker.Name = "nacimientoDateTimePicker";
            this.nacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.nacimientoDateTimePicker.TabIndex = 9;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(265, 136);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(314, 20);
            this.nombreTextBox.TabIndex = 11;
            // 
            // btnLista
            // 
            this.btnLista.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnLista.Location = new System.Drawing.Point(12, 395);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(132, 45);
            this.btnLista.TabIndex = 25;
            this.btnLista.Text = "Mostrar Lista";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // frmGestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionUsuarios";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.PictureBox pctUsuario;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox domicilioTextBox;
        private System.Windows.Forms.ComboBox entidadComboBox;
        private System.Windows.Forms.DateTimePicker nacimientoDateTimePicker;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox cURPTextBox;
        private System.Windows.Forms.Button btnAddFoto;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Button btnLista;
    }
}

