
namespace Login
{
    partial class Form1
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
            this.icnPctBxLogo = new FontAwesome.Sharp.IconPictureBox();
            this.lblTittle = new System.Windows.Forms.Label();
            this.pnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icnPctBxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.Controls.Add(this.lblTittle);
            this.pnlFondo.Controls.Add(this.icnPctBxLogo);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(384, 561);
            this.pnlFondo.TabIndex = 0;
            // 
            // icnPctBxLogo
            // 
            this.icnPctBxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.icnPctBxLogo.BackColor = System.Drawing.Color.Transparent;
            this.icnPctBxLogo.ForeColor = System.Drawing.Color.Tan;
            this.icnPctBxLogo.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.icnPctBxLogo.IconColor = System.Drawing.Color.Tan;
            this.icnPctBxLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnPctBxLogo.IconSize = 191;
            this.icnPctBxLogo.Location = new System.Drawing.Point(12, 59);
            this.icnPctBxLogo.Name = "icnPctBxLogo";
            this.icnPctBxLogo.Size = new System.Drawing.Size(360, 191);
            this.icnPctBxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.icnPctBxLogo.TabIndex = 0;
            this.icnPctBxLogo.TabStop = false;
            // 
            // lblTittle
            // 
            this.lblTittle.BackColor = System.Drawing.Color.Transparent;
            this.lblTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(0, 0);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(384, 44);
            this.lblTittle.TabIndex = 1;
            this.lblTittle.Text = "Iniciar Sesion";
            this.lblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.pnlFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlFondo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icnPctBxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFondo;
        private FontAwesome.Sharp.IconPictureBox icnPctBxLogo;
        private System.Windows.Forms.Label lblTittle;
    }
}

