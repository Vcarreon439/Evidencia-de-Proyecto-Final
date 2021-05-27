
namespace GestionAutores
{
    partial class frmGestionAutores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionAutores));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pctAutor = new System.Windows.Forms.PictureBox();
            this.chkDesconocido = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCountry = new FlagsISO.ComboBoxCountrySelect();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAgregarFoto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnAgregarFoto);
            this.panel1.Controls.Add(this.pctAutor);
            this.panel1.Controls.Add(this.chkDesconocido);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtCiudad);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboCountry);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnInsertar);
            this.panel1.Controls.Add(this.dgvAutores);
            this.panel1.Controls.Add(this.txtComentarios);
            this.panel1.Controls.Add(this.txtApellidos);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 500);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pctAutor
            // 
            this.pctAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctAutor.Location = new System.Drawing.Point(18, 18);
            this.pctAutor.Name = "pctAutor";
            this.pctAutor.Size = new System.Drawing.Size(230, 230);
            this.pctAutor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAutor.TabIndex = 23;
            this.pctAutor.TabStop = false;
            this.pctAutor.DragDrop += new System.Windows.Forms.DragEventHandler(this.pctAutor_DragDrop);
            this.pctAutor.DragEnter += new System.Windows.Forms.DragEventHandler(this.pctAutor_DragEnter);
            // 
            // chkDesconocido
            // 
            this.chkDesconocido.AutoSize = true;
            this.chkDesconocido.Location = new System.Drawing.Point(573, 117);
            this.chkDesconocido.Name = "chkDesconocido";
            this.chkDesconocido.Size = new System.Drawing.Size(15, 14);
            this.chkDesconocido.TabIndex = 21;
            this.toolTip1.SetToolTip(this.chkDesconocido, "Pais desconocido");
            this.chkDesconocido.UseVisualStyleBackColor = true;
            this.chkDesconocido.CheckedChanged += new System.EventHandler(this.chkDesconocido_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tabla Autores";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ciudad:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(273, 164);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(315, 20);
            this.txtCiudad.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Origen:";
            // 
            // cboCountry
            // 
            this.cboCountry.DontGetShiny = false;
            this.cboCountry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCountry.FlagSize = FlagsISO.ComboBoxCountrySelect.FlagSizeType.Size16;
            this.cboCountry.IntegralHeight = false;
            this.cboCountry.ItemHeight = 15;
            this.cboCountry.Items.AddRange(new object[] {
            ((object)(resources.GetObject("cboCountry.Items"))),
            ((object)(resources.GetObject("cboCountry.Items1"))),
            ((object)(resources.GetObject("cboCountry.Items2"))),
            ((object)(resources.GetObject("cboCountry.Items3"))),
            ((object)(resources.GetObject("cboCountry.Items4"))),
            ((object)(resources.GetObject("cboCountry.Items5"))),
            ((object)(resources.GetObject("cboCountry.Items6"))),
            ((object)(resources.GetObject("cboCountry.Items7"))),
            ((object)(resources.GetObject("cboCountry.Items8"))),
            ((object)(resources.GetObject("cboCountry.Items9"))),
            ((object)(resources.GetObject("cboCountry.Items10"))),
            ((object)(resources.GetObject("cboCountry.Items11"))),
            ((object)(resources.GetObject("cboCountry.Items12"))),
            ((object)(resources.GetObject("cboCountry.Items13"))),
            ((object)(resources.GetObject("cboCountry.Items14"))),
            ((object)(resources.GetObject("cboCountry.Items15"))),
            ((object)(resources.GetObject("cboCountry.Items16"))),
            ((object)(resources.GetObject("cboCountry.Items17"))),
            ((object)(resources.GetObject("cboCountry.Items18"))),
            ((object)(resources.GetObject("cboCountry.Items19"))),
            ((object)(resources.GetObject("cboCountry.Items20"))),
            ((object)(resources.GetObject("cboCountry.Items21"))),
            ((object)(resources.GetObject("cboCountry.Items22"))),
            ((object)(resources.GetObject("cboCountry.Items23"))),
            ((object)(resources.GetObject("cboCountry.Items24"))),
            ((object)(resources.GetObject("cboCountry.Items25"))),
            ((object)(resources.GetObject("cboCountry.Items26"))),
            ((object)(resources.GetObject("cboCountry.Items27"))),
            ((object)(resources.GetObject("cboCountry.Items28"))),
            ((object)(resources.GetObject("cboCountry.Items29"))),
            ((object)(resources.GetObject("cboCountry.Items30"))),
            ((object)(resources.GetObject("cboCountry.Items31"))),
            ((object)(resources.GetObject("cboCountry.Items32"))),
            ((object)(resources.GetObject("cboCountry.Items33"))),
            ((object)(resources.GetObject("cboCountry.Items34"))),
            ((object)(resources.GetObject("cboCountry.Items35"))),
            ((object)(resources.GetObject("cboCountry.Items36"))),
            ((object)(resources.GetObject("cboCountry.Items37"))),
            ((object)(resources.GetObject("cboCountry.Items38"))),
            ((object)(resources.GetObject("cboCountry.Items39"))),
            ((object)(resources.GetObject("cboCountry.Items40"))),
            ((object)(resources.GetObject("cboCountry.Items41"))),
            ((object)(resources.GetObject("cboCountry.Items42"))),
            ((object)(resources.GetObject("cboCountry.Items43"))),
            ((object)(resources.GetObject("cboCountry.Items44"))),
            ((object)(resources.GetObject("cboCountry.Items45"))),
            ((object)(resources.GetObject("cboCountry.Items46"))),
            ((object)(resources.GetObject("cboCountry.Items47"))),
            ((object)(resources.GetObject("cboCountry.Items48"))),
            ((object)(resources.GetObject("cboCountry.Items49"))),
            ((object)(resources.GetObject("cboCountry.Items50"))),
            ((object)(resources.GetObject("cboCountry.Items51"))),
            ((object)(resources.GetObject("cboCountry.Items52"))),
            ((object)(resources.GetObject("cboCountry.Items53"))),
            ((object)(resources.GetObject("cboCountry.Items54"))),
            ((object)(resources.GetObject("cboCountry.Items55"))),
            ((object)(resources.GetObject("cboCountry.Items56"))),
            ((object)(resources.GetObject("cboCountry.Items57"))),
            ((object)(resources.GetObject("cboCountry.Items58"))),
            ((object)(resources.GetObject("cboCountry.Items59"))),
            ((object)(resources.GetObject("cboCountry.Items60"))),
            ((object)(resources.GetObject("cboCountry.Items61"))),
            ((object)(resources.GetObject("cboCountry.Items62"))),
            ((object)(resources.GetObject("cboCountry.Items63"))),
            ((object)(resources.GetObject("cboCountry.Items64"))),
            ((object)(resources.GetObject("cboCountry.Items65"))),
            ((object)(resources.GetObject("cboCountry.Items66"))),
            ((object)(resources.GetObject("cboCountry.Items67"))),
            ((object)(resources.GetObject("cboCountry.Items68"))),
            ((object)(resources.GetObject("cboCountry.Items69"))),
            ((object)(resources.GetObject("cboCountry.Items70"))),
            ((object)(resources.GetObject("cboCountry.Items71"))),
            ((object)(resources.GetObject("cboCountry.Items72"))),
            ((object)(resources.GetObject("cboCountry.Items73"))),
            ((object)(resources.GetObject("cboCountry.Items74"))),
            ((object)(resources.GetObject("cboCountry.Items75"))),
            ((object)(resources.GetObject("cboCountry.Items76"))),
            ((object)(resources.GetObject("cboCountry.Items77"))),
            ((object)(resources.GetObject("cboCountry.Items78"))),
            ((object)(resources.GetObject("cboCountry.Items79"))),
            ((object)(resources.GetObject("cboCountry.Items80"))),
            ((object)(resources.GetObject("cboCountry.Items81"))),
            ((object)(resources.GetObject("cboCountry.Items82"))),
            ((object)(resources.GetObject("cboCountry.Items83"))),
            ((object)(resources.GetObject("cboCountry.Items84"))),
            ((object)(resources.GetObject("cboCountry.Items85"))),
            ((object)(resources.GetObject("cboCountry.Items86"))),
            ((object)(resources.GetObject("cboCountry.Items87"))),
            ((object)(resources.GetObject("cboCountry.Items88"))),
            ((object)(resources.GetObject("cboCountry.Items89"))),
            ((object)(resources.GetObject("cboCountry.Items90"))),
            ((object)(resources.GetObject("cboCountry.Items91"))),
            ((object)(resources.GetObject("cboCountry.Items92"))),
            ((object)(resources.GetObject("cboCountry.Items93"))),
            ((object)(resources.GetObject("cboCountry.Items94"))),
            ((object)(resources.GetObject("cboCountry.Items95"))),
            ((object)(resources.GetObject("cboCountry.Items96"))),
            ((object)(resources.GetObject("cboCountry.Items97"))),
            ((object)(resources.GetObject("cboCountry.Items98"))),
            ((object)(resources.GetObject("cboCountry.Items99"))),
            ((object)(resources.GetObject("cboCountry.Items100"))),
            ((object)(resources.GetObject("cboCountry.Items101"))),
            ((object)(resources.GetObject("cboCountry.Items102"))),
            ((object)(resources.GetObject("cboCountry.Items103"))),
            ((object)(resources.GetObject("cboCountry.Items104"))),
            ((object)(resources.GetObject("cboCountry.Items105"))),
            ((object)(resources.GetObject("cboCountry.Items106"))),
            ((object)(resources.GetObject("cboCountry.Items107"))),
            ((object)(resources.GetObject("cboCountry.Items108"))),
            ((object)(resources.GetObject("cboCountry.Items109"))),
            ((object)(resources.GetObject("cboCountry.Items110"))),
            ((object)(resources.GetObject("cboCountry.Items111"))),
            ((object)(resources.GetObject("cboCountry.Items112"))),
            ((object)(resources.GetObject("cboCountry.Items113"))),
            ((object)(resources.GetObject("cboCountry.Items114"))),
            ((object)(resources.GetObject("cboCountry.Items115"))),
            ((object)(resources.GetObject("cboCountry.Items116"))),
            ((object)(resources.GetObject("cboCountry.Items117"))),
            ((object)(resources.GetObject("cboCountry.Items118"))),
            ((object)(resources.GetObject("cboCountry.Items119"))),
            ((object)(resources.GetObject("cboCountry.Items120"))),
            ((object)(resources.GetObject("cboCountry.Items121"))),
            ((object)(resources.GetObject("cboCountry.Items122"))),
            ((object)(resources.GetObject("cboCountry.Items123"))),
            ((object)(resources.GetObject("cboCountry.Items124"))),
            ((object)(resources.GetObject("cboCountry.Items125"))),
            ((object)(resources.GetObject("cboCountry.Items126"))),
            ((object)(resources.GetObject("cboCountry.Items127"))),
            ((object)(resources.GetObject("cboCountry.Items128"))),
            ((object)(resources.GetObject("cboCountry.Items129"))),
            ((object)(resources.GetObject("cboCountry.Items130"))),
            ((object)(resources.GetObject("cboCountry.Items131"))),
            ((object)(resources.GetObject("cboCountry.Items132"))),
            ((object)(resources.GetObject("cboCountry.Items133"))),
            ((object)(resources.GetObject("cboCountry.Items134"))),
            ((object)(resources.GetObject("cboCountry.Items135"))),
            ((object)(resources.GetObject("cboCountry.Items136"))),
            ((object)(resources.GetObject("cboCountry.Items137"))),
            ((object)(resources.GetObject("cboCountry.Items138"))),
            ((object)(resources.GetObject("cboCountry.Items139"))),
            ((object)(resources.GetObject("cboCountry.Items140"))),
            ((object)(resources.GetObject("cboCountry.Items141"))),
            ((object)(resources.GetObject("cboCountry.Items142"))),
            ((object)(resources.GetObject("cboCountry.Items143"))),
            ((object)(resources.GetObject("cboCountry.Items144"))),
            ((object)(resources.GetObject("cboCountry.Items145"))),
            ((object)(resources.GetObject("cboCountry.Items146"))),
            ((object)(resources.GetObject("cboCountry.Items147"))),
            ((object)(resources.GetObject("cboCountry.Items148"))),
            ((object)(resources.GetObject("cboCountry.Items149"))),
            ((object)(resources.GetObject("cboCountry.Items150"))),
            ((object)(resources.GetObject("cboCountry.Items151"))),
            ((object)(resources.GetObject("cboCountry.Items152"))),
            ((object)(resources.GetObject("cboCountry.Items153"))),
            ((object)(resources.GetObject("cboCountry.Items154"))),
            ((object)(resources.GetObject("cboCountry.Items155"))),
            ((object)(resources.GetObject("cboCountry.Items156"))),
            ((object)(resources.GetObject("cboCountry.Items157"))),
            ((object)(resources.GetObject("cboCountry.Items158"))),
            ((object)(resources.GetObject("cboCountry.Items159"))),
            ((object)(resources.GetObject("cboCountry.Items160"))),
            ((object)(resources.GetObject("cboCountry.Items161"))),
            ((object)(resources.GetObject("cboCountry.Items162"))),
            ((object)(resources.GetObject("cboCountry.Items163"))),
            ((object)(resources.GetObject("cboCountry.Items164"))),
            ((object)(resources.GetObject("cboCountry.Items165"))),
            ((object)(resources.GetObject("cboCountry.Items166"))),
            ((object)(resources.GetObject("cboCountry.Items167"))),
            ((object)(resources.GetObject("cboCountry.Items168"))),
            ((object)(resources.GetObject("cboCountry.Items169"))),
            ((object)(resources.GetObject("cboCountry.Items170"))),
            ((object)(resources.GetObject("cboCountry.Items171"))),
            ((object)(resources.GetObject("cboCountry.Items172"))),
            ((object)(resources.GetObject("cboCountry.Items173"))),
            ((object)(resources.GetObject("cboCountry.Items174"))),
            ((object)(resources.GetObject("cboCountry.Items175"))),
            ((object)(resources.GetObject("cboCountry.Items176"))),
            ((object)(resources.GetObject("cboCountry.Items177"))),
            ((object)(resources.GetObject("cboCountry.Items178"))),
            ((object)(resources.GetObject("cboCountry.Items179"))),
            ((object)(resources.GetObject("cboCountry.Items180"))),
            ((object)(resources.GetObject("cboCountry.Items181"))),
            ((object)(resources.GetObject("cboCountry.Items182"))),
            ((object)(resources.GetObject("cboCountry.Items183"))),
            ((object)(resources.GetObject("cboCountry.Items184"))),
            ((object)(resources.GetObject("cboCountry.Items185"))),
            ((object)(resources.GetObject("cboCountry.Items186"))),
            ((object)(resources.GetObject("cboCountry.Items187"))),
            ((object)(resources.GetObject("cboCountry.Items188"))),
            ((object)(resources.GetObject("cboCountry.Items189"))),
            ((object)(resources.GetObject("cboCountry.Items190"))),
            ((object)(resources.GetObject("cboCountry.Items191"))),
            ((object)(resources.GetObject("cboCountry.Items192"))),
            ((object)(resources.GetObject("cboCountry.Items193"))),
            ((object)(resources.GetObject("cboCountry.Items194"))),
            ((object)(resources.GetObject("cboCountry.Items195"))),
            ((object)(resources.GetObject("cboCountry.Items196"))),
            ((object)(resources.GetObject("cboCountry.Items197"))),
            ((object)(resources.GetObject("cboCountry.Items198"))),
            ((object)(resources.GetObject("cboCountry.Items199"))),
            ((object)(resources.GetObject("cboCountry.Items200"))),
            ((object)(resources.GetObject("cboCountry.Items201"))),
            ((object)(resources.GetObject("cboCountry.Items202"))),
            ((object)(resources.GetObject("cboCountry.Items203"))),
            ((object)(resources.GetObject("cboCountry.Items204"))),
            ((object)(resources.GetObject("cboCountry.Items205"))),
            ((object)(resources.GetObject("cboCountry.Items206"))),
            ((object)(resources.GetObject("cboCountry.Items207"))),
            ((object)(resources.GetObject("cboCountry.Items208"))),
            ((object)(resources.GetObject("cboCountry.Items209"))),
            ((object)(resources.GetObject("cboCountry.Items210"))),
            ((object)(resources.GetObject("cboCountry.Items211"))),
            ((object)(resources.GetObject("cboCountry.Items212"))),
            ((object)(resources.GetObject("cboCountry.Items213"))),
            ((object)(resources.GetObject("cboCountry.Items214"))),
            ((object)(resources.GetObject("cboCountry.Items215"))),
            ((object)(resources.GetObject("cboCountry.Items216"))),
            ((object)(resources.GetObject("cboCountry.Items217"))),
            ((object)(resources.GetObject("cboCountry.Items218"))),
            ((object)(resources.GetObject("cboCountry.Items219"))),
            ((object)(resources.GetObject("cboCountry.Items220"))),
            ((object)(resources.GetObject("cboCountry.Items221"))),
            ((object)(resources.GetObject("cboCountry.Items222"))),
            ((object)(resources.GetObject("cboCountry.Items223"))),
            ((object)(resources.GetObject("cboCountry.Items224"))),
            ((object)(resources.GetObject("cboCountry.Items225"))),
            ((object)(resources.GetObject("cboCountry.Items226"))),
            ((object)(resources.GetObject("cboCountry.Items227"))),
            ((object)(resources.GetObject("cboCountry.Items228"))),
            ((object)(resources.GetObject("cboCountry.Items229"))),
            ((object)(resources.GetObject("cboCountry.Items230"))),
            ((object)(resources.GetObject("cboCountry.Items231"))),
            ((object)(resources.GetObject("cboCountry.Items232"))),
            ((object)(resources.GetObject("cboCountry.Items233")))});
            this.cboCountry.Location = new System.Drawing.Point(317, 114);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.SelectedRegion = ((System.Globalization.RegionInfo)(resources.GetObject("cboCountry.SelectedRegion")));
            this.cboCountry.Size = new System.Drawing.Size(250, 21);
            this.cboCountry.TabIndex = 14;
            this.cboCountry.UseNativeName = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Acerca del autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombres:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID:";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(173, 310);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 6;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // dgvAutores
            // 
            this.dgvAutores.AllowUserToAddRows = false;
            this.dgvAutores.AllowUserToDeleteRows = false;
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.Location = new System.Drawing.Point(12, 345);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.Size = new System.Drawing.Size(576, 143);
            this.dgvAutores.TabIndex = 5;
            this.dgvAutores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutores_CellClick);
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(273, 218);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(315, 115);
            this.txtComentarios.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtComentarios, "Comentarios acerca del autor");
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(273, 76);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(315, 20);
            this.txtApellidos.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(273, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(315, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(148, 263);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 0;
            // 
            // btnAgregarFoto
            // 
            this.btnAgregarFoto.Location = new System.Drawing.Point(18, 261);
            this.btnAgregarFoto.Name = "btnAgregarFoto";
            this.btnAgregarFoto.Size = new System.Drawing.Size(97, 23);
            this.btnAgregarFoto.TabIndex = 24;
            this.btnAgregarFoto.Text = "Agregar Foto";
            this.btnAgregarFoto.UseVisualStyleBackColor = true;
            this.btnAgregarFoto.Click += new System.EventHandler(this.btnAgregarFoto_Click);
            // 
            // frmGestionAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionAutores";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmGestionAutores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView dgvAutores;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private FlagsISO.ComboBoxCountrySelect cboCountry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkDesconocido;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pctAutor;
        private System.Windows.Forms.Button btnAgregarFoto;
    }
}

