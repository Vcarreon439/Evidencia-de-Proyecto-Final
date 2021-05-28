using System.Drawing;
using System.Windows.Forms;

namespace Funcionalidad_Formularios
{
    public class LigarTextBox
    {
        private string texto;

        private Color ClrBntF;


        public LigarTextBox(TextBox referencia) 
        {
            ClrBntF = referencia.ForeColor;
            this.texto = referencia.Text;
        }
        
        ~LigarTextBox( ){ }
        
        public void Usuario_Contra(ref TextBox Usuario) 
        {
            switch (texto)
            {
                case "":
                    Usuario.Text = "USUARIO";
                    Usuario.ForeColor = ClrBntF;
                    break;

                case "USUARIO":
                    Usuario.Text = "";
                    Usuario.ForeColor = ClrBntF;
                    break;
            }
        }

        public void Contra_Usuario(ref TextBox rContraseña)
        {
            switch (texto)
            {
                case "":
                    rContraseña.Text = "CONTRASEÑA";
                    rContraseña.ForeColor = ClrBntF;
                    rContraseña.UseSystemPasswordChar = false;
                    break;

                case "CONTRASEÑA":
                    rContraseña.Text = "";
                    rContraseña.ForeColor = ClrBntF;
                    rContraseña.UseSystemPasswordChar = true;
                    break;
            }
        }
    }
}
