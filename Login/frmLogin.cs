using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using Dominio;
using Forma_Principal;

namespace Login
{
    public partial class frmLogin : Form
    {
        private SqlConnection interno;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public frmLogin()
        {
            InitializeComponent();
            interno = new SqlConnection(
                $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Path.GetFullPath("./LibreriaBD.mdf")};Integrated Security = True");
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnCerrar_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloDUsuario usuario = new ModeloDUsuario();

                if (usuario.LoginUsuario(txtUsuario.Text, txtContra.Text))
                {
                    MessageBox.Show("Inicio Correcto");
                    frmPrincipal obj = new frmPrincipal(usuario.Autenticacion(txtUsuario.Text, txtContra.Text));
                    this.Hide();
                    txtContra.Text = "";
                    txtUsuario.Text = "";
                    obj.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                    txtContra.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnCerrar_MouseHover(object sender, EventArgs e)
        {
            btnCerrar.ForeColor = Color.Black;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.ForeColor = Color.Red;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSlateGray;
            this.TransparencyKey = Color.LightSlateGray;
        }

        private void rounded_Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Funcionalidad_Formularios.Arrastre_Formularios.Llama_ReleaseCapture();
            Funcionalidad_Formularios.Arrastre_Formularios.Llama_SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void rounded_PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtContra.Focus();
        }
    }
}