
namespace Login
{
    partial class frmLogin
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
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblTittle = new System.Windows.Forms.Label();
            this.icnPctBxLogo = new FontAwesome.Sharp.IconPictureBox();
            this.pnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnPctBxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.pnlFondo.Controls.Add(this.label2);
            this.pnlFondo.Controls.Add(this.txtContra);
            this.pnlFondo.Controls.Add(this.btnLogin);
            this.pnlFondo.Controls.Add(this.btnCerrar);
            this.pnlFondo.Controls.Add(this.label1);
            this.pnlFondo.Controls.Add(this.txtUsuario);
            this.pnlFondo.Controls.Add(this.lblTittle);
            this.pnlFondo.Controls.Add(this.icnPctBxLogo);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(300, 500);
            this.pnlFondo.TabIndex = 0;
            this.pnlFondo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlFondo_MouseMove);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contraseña";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(15, 321);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(273, 20);
            this.txtContra.TabIndex = 2;
            this.txtContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(90, 385);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(128, 51);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.btnCerrar.ForeColor = System.Drawing.Color.Red;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCerrar.IconColor = System.Drawing.Color.Red;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.Location = new System.Drawing.Point(256, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.DoubleClick += new System.EventHandler(this.btnCerrar_DoubleClick);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            this.btnCerrar.MouseHover += new System.EventHandler(this.btnCerrar_MouseHover);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(15, 258);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(273, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTittle
            // 
            this.lblTittle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTittle.AutoSize = true;
            this.lblTittle.BackColor = System.Drawing.Color.Transparent;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(83, 53);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(141, 25);
            this.lblTittle.TabIndex = 1;
            this.lblTittle.Text = "Iniciar Sesion";
            this.lblTittle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // icnPctBxLogo
            // 
            this.icnPctBxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.icnPctBxLogo.BackColor = System.Drawing.Color.Transparent;
            this.icnPctBxLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(132)))), ((int)(((byte)(103)))));
            this.icnPctBxLogo.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.icnPctBxLogo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(132)))), ((int)(((byte)(103)))));
            this.icnPctBxLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnPctBxLogo.IconSize = 130;
            this.icnPctBxLogo.Location = new System.Drawing.Point(12, 88);
            this.icnPctBxLogo.Name = "icnPctBxLogo";
            this.icnPctBxLogo.Size = new System.Drawing.Size(276, 130);
            this.icnPctBxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.icnPctBxLogo.TabIndex = 0;
            this.icnPctBxLogo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.pnlFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnPctBxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFondo;
        private FontAwesome.Sharp.IconPictureBox icnPctBxLogo;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContra;
    }
}

