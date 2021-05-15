using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autenticacion;
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

        public TipoUsuario.TypeUser Autenticacion(string nombre) 
        {
            return usuario.Autenticacion(nombre);
        }
    }
}
