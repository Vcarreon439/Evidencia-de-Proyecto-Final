using System;
using System.Linq;
using System.Windows.Forms;

namespace Funcionalidad_Formularios
{
    public class FormEnPanel
    {
        static public void AbrirForm<MiFomr>(ref Panel pnlFormularios) where MiFomr : Form, new()
        {
            Form formulario;
            formulario = pnlFormularios.Controls.OfType<MiFomr>().FirstOrDefault(); //Busca formulario en coleccion
            if (formulario == null)
            {
                formulario = new MiFomr();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnlFormularios.Controls.Add(formulario);
                pnlFormularios.Tag = formulario;
                formulario.Show();
            }
            //En caso de ya estar abierto
            else
            {
                formulario.BringToFront();
                formulario.WindowState = FormWindowState.Maximized;
            }
        }

        static public DialogResult AbrirForm<MiFomr>(ref Panel pnlFormularios, int valor=0) where MiFomr : Form, new()
        {
            Form formulario;
            formulario = pnlFormularios.Controls.OfType<MiFomr>().FirstOrDefault(); //Busca formulario en coleccion
            if (formulario == null)
            {
                formulario = new MiFomr();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnlFormularios.Controls.Add(formulario);
                pnlFormularios.Tag = formulario;
                formulario.Show();
            }
            //En caso de ya estar abierto
            else
            {
                formulario.BringToFront();
                formulario.WindowState = FormWindowState.Maximized;
            }

            return formulario.DialogResult;
        }

    }
}
