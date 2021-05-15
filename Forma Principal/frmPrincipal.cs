using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma_Principal
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnGeneros_Click(object sender, EventArgs e)
        {
            if (pnlSubMenu1.Visible == false)
                pnlSubMenu1.Visible = true;
            else
                pnlSubMenu1.Visible = false;

            
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            if (pnlSubMenu2.Visible == false)
                pnlSubMenu2.Visible = true;
            else
                pnlSubMenu2.Visible = false;
        }

        private void btnMiembros_Click(object sender, EventArgs e)
        {
            if (pnlSubMenu3.Visible == false)
                pnlSubMenu3.Visible = true;
            else
                pnlSubMenu3.Visible = false;
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            if (pnlSubMenu4.Visible == false)
                pnlSubMenu4.Visible = true;
            else
                pnlSubMenu4.Visible = false;
        }
    }
}
