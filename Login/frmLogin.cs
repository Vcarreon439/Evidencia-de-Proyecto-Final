using System;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Dominio;


namespace Login
{
    public partial class frmLogin : Form
    {
        private SqlConnection interno;


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );

        public frmLogin()
        {
            InitializeComponent();
            interno = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Path.GetFullPath("./LibreriaBD.mdf")};Integrated Security = True");
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnCerrar_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ModeloDUsuario usuario = new ModeloDUsuario();
            bool valido = usuario.LoginUsuario(txtUsuario.Text, txtContra.Text);

            if (valido==true)
                MessageBox.Show("Inicio Correcto");
            else
                MessageBox.Show("Inicio Inorrecto");
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void pnlFondo_MouseMove(object sender, MouseEventArgs e)
        {
            Funcionalidad_Formularios.Arrastre_Formularios.Llama_ReleaseCapture();
            Funcionalidad_Formularios.Arrastre_Formularios.Llama_SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
