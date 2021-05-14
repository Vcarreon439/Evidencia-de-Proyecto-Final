using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;

namespace Dominio
{
    public class ModeloDUsuario
    {
        Usuario usuario = new Usuario();
        
        public bool LoginUsuario(string nombre, string contra) 
        {
            return usuario.Login(nombre, contra);
        }

    }
}
