using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmLogin : Form
    {
        private SqlConnection interno;


        [DllImport("Gdi32.dll", EntryPoint = "frmEsquinasRedondeadas")]
        private static extern IntPtr frmEsquinasRedondeadas
       (
           int nLeftRect,     
           int nTopRect,      
           int nRightRect,    
           int nBottomRect,   
           int nWidthEllipse, 
           int nHeightEllipse 
       );

        public frmLogin()
        {
            InitializeComponent();
            interno = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Path.GetFullPath("./LibreriaBD.mdf")};Integrated Security = True");
            Region = System.Drawing.Region.FromHrgn(frmEsquinasRedondeadas(0, 0, Width, Height, 20, 20));
        }

        private void btnCerrar_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
