
namespace GestionGeneros
{
    partial class frmListaGenero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numUpDnCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dgvGenero = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.numUpDnCantidad);
            this.panel1.Controls.Add(this.btnShowAll);
            this.panel1.Controls.Add(this.btnMostrar);
            this.panel1.Controls.Add(this.dgvGenero);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 500);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // numUpDnCantidad
            // 
            this.numUpDnCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDnCantidad.Location = new System.Drawing.Point(520, 42);
            this.numUpDnCantidad.Name = "numUpDnCantidad";
            this.numUpDnCantidad.Size = new System.Drawing.Size(54, 20);
            this.numUpDnCantidad.TabIndex = 4;
            this.toolTip1.SetToolTip(this.numUpDnCantidad, "Aqui puedes aumentar la cantidad de resultados a mostrar");
            this.numUpDnCantidad.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(23, 41);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(121, 23);
            this.btnShowAll.TabIndex = 3;
            this.btnShowAll.Text = "Mostrar Todos";
            this.toolTip1.SetToolTip(this.btnShowAll, "Muestra todos los temas existentes.");
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrar.Location = new System.Drawing.Point(401, 39);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(113, 23);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dgvGenero
            // 
            this.dgvGenero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenero.Location = new System.Drawing.Point(23, 85);
            this.dgvGenero.Name = "dgvGenero";
            this.dgvGenero.Size = new System.Drawing.Size(551, 394);
            this.dgvGenero.TabIndex = 0;
            // 
            // frmListaGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaGenero";
            this.Text = "frmListaGenero";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dgvGenero;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown numUpDnCantidad;
    }
}