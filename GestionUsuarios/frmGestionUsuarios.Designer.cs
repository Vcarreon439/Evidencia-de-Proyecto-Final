
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label domicilioLabel;
            System.Windows.Forms.Label entidadLabel;
            System.Windows.Forms.Label nacimientoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label situacionLabel;
            System.Windows.Forms.Label cURPLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.cURPTextBox = new System.Windows.Forms.TextBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.situacionComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.domicilioTextBox = new System.Windows.Forms.TextBox();
            this.entidadComboBox = new System.Windows.Forms.ComboBox();
            this.nacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            apellidosLabel = new System.Windows.Forms.Label();
            domicilioLabel = new System.Windows.Forms.Label();
            entidadLabel = new System.Windows.Forms.Label();
            nacimientoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            situacionLabel = new System.Windows.Forms.Label();
            cURPLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(268, 152);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(52, 13);
            apellidosLabel.TabIndex = 0;
            apellidosLabel.Text = "Apellidos:";
            // 
            // domicilioLabel
            // 
            domicilioLabel.AutoSize = true;
            domicilioLabel.Location = new System.Drawing.Point(12, 317);
            domicilioLabel.Name = "domicilioLabel";
            domicilioLabel.Size = new System.Drawing.Size(52, 13);
            domicilioLabel.TabIndex = 4;
            domicilioLabel.Text = "Domicilio:";
            // 
            // entidadLabel
            // 
            entidadLabel.AutoSize = true;
            entidadLabel.Location = new System.Drawing.Point(388, 61);
            entidadLabel.Name = "entidadLabel";
            entidadLabel.Size = new System.Drawing.Size(46, 13);
            entidadLabel.TabIndex = 6;
            entidadLabel.Text = "Entidad:";
            // 
            // nacimientoLabel
            // 
            nacimientoLabel.AutoSize = true;
            nacimientoLabel.Location = new System.Drawing.Point(301, 215);
            nacimientoLabel.Name = "nacimientoLabel";
            nacimientoLabel.Size = new System.Drawing.Size(111, 13);
            nacimientoLabel.TabIndex = 8;
            nacimientoLabel.Text = "Fecha de Nacimiento:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(268, 98);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 10;
            nombreLabel.Text = "Nombre:";
            // 
            // situacionLabel
            // 
            situacionLabel.AutoSize = true;
            situacionLabel.Location = new System.Drawing.Point(99, 279);
            situacionLabel.Name = "situacionLabel";
            situacionLabel.Size = new System.Drawing.Size(54, 13);
            situacionLabel.TabIndex = 14;
            situacionLabel.Text = "Situacion:";
            // 
            // cURPLabel
            // 
            cURPLabel.AutoSize = true;
            cURPLabel.Location = new System.Drawing.Point(379, 29);
            cURPLabel.Name = "cURPLabel";
            cURPLabel.Size = new System.Drawing.Size(40, 13);
            cURPLabel.TabIndex = 19;
            cURPLabel.Text = "CURP:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(cURPLabel);
            this.panel1.Controls.Add(this.cURPTextBox);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.btnInsertar);
            this.panel1.Controls.Add(situacionLabel);
            this.panel1.Controls.Add(this.situacionComboBox);
            this.panel1.Controls.Add(this.pictureBox1);
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
            this.panel1.Size = new System.Drawing.Size(638, 509);
            this.panel1.TabIndex = 0;
            // 
            // cURPTextBox
            // 
            this.cURPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "CURP", true));
            this.cURPTextBox.Location = new System.Drawing.Point(425, 26);
            this.cURPTextBox.Name = "cURPTextBox";
            this.cURPTextBox.Size = new System.Drawing.Size(100, 20);
            this.cURPTextBox.TabIndex = 20;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(GestionUsuarios.Usuario);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(474, 339);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(144, 42);
            this.btnNuevo.TabIndex = 18;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(474, 387);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(144, 42);
            this.btnInsertar.TabIndex = 16;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // situacionComboBox
            // 
            this.situacionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Situacion", true));
            this.situacionComboBox.FormattingEnabled = true;
            this.situacionComboBox.Location = new System.Drawing.Point(159, 271);
            this.situacionComboBox.Name = "situacionComboBox";
            this.situacionComboBox.Size = new System.Drawing.Size(121, 21);
            this.situacionComboBox.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 230);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(271, 173);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(347, 20);
            this.apellidosTextBox.TabIndex = 1;
            // 
            // domicilioTextBox
            // 
            this.domicilioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Domicilio", true));
            this.domicilioTextBox.Location = new System.Drawing.Point(15, 339);
            this.domicilioTextBox.Multiline = true;
            this.domicilioTextBox.Name = "domicilioTextBox";
            this.domicilioTextBox.Size = new System.Drawing.Size(453, 150);
            this.domicilioTextBox.TabIndex = 5;
            // 
            // entidadComboBox
            // 
            this.entidadComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Entidad", true));
            this.entidadComboBox.FormattingEnabled = true;
            this.entidadComboBox.Items.AddRange(new object[] {
            "Coahuila de Zaragoza",
            "Durango"});
            this.entidadComboBox.Location = new System.Drawing.Point(440, 58);
            this.entidadComboBox.Name = "entidadComboBox";
            this.entidadComboBox.Size = new System.Drawing.Size(178, 21);
            this.entidadComboBox.TabIndex = 7;
            // 
            // nacimientoDateTimePicker
            // 
            this.nacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usuarioBindingSource, "Nacimiento", true));
            this.nacimientoDateTimePicker.Location = new System.Drawing.Point(418, 211);
            this.nacimientoDateTimePicker.Name = "nacimientoDateTimePicker";
            this.nacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.nacimientoDateTimePicker.TabIndex = 9;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(271, 122);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(347, 20);
            this.nombreTextBox.TabIndex = 11;
            // 
            // frmGestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 509);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionUsuarios";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.ComboBox situacionComboBox;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox domicilioTextBox;
        private System.Windows.Forms.ComboBox entidadComboBox;
        private System.Windows.Forms.DateTimePicker nacimientoDateTimePicker;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox cURPTextBox;
    }
}

