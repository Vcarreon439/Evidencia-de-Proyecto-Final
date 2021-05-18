using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAutores
{
    public partial class fichaAutor : Form
    {
        ObjetoAutor Autor;

        public fichaAutor(ObjetoAutor autor)
        {
            InitializeComponent();
            this.Autor = autor;
        }

        private void fichaAutor_Load(object sender, EventArgs e)
        {

        }
    }
}
