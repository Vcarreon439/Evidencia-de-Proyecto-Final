using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autenticacion;
using System.Threading.Tasks;
using AccesoADatos;
using GestionAutores;

namespace Dominio
{
    public class ModeloDUsuario
    {
        Usuario usuario = new Usuario();

        public DataTable MostrarGenerosCant(int cantidad)
        {
            return usuario.MostrarGenerosCant(cantidad);
        }

        public bool LoginUsuario(string nombre, string contra) 
        {
            return usuario.Login(nombre, contra);
        }

        public TipoUsuario.TypeUser Autenticacion(string nombre, string contraseña) 
        {
            return usuario.Autenticacion(nombre, contraseña);
        }

        public bool InsercionTema(string codigo, string descripcion) 
        {
            return usuario.InsertarGenero(codigo, descripcion);
        }

        #region MostrarDatos
        public DataTable MostrarGeneros()
        {
            return usuario.MostrarGeneros();
        }

        public List<string> GenerosCombo(int cantidad)
        {
            return usuario.GenerosCombo(cantidad);
        }

        public DataTable MostrarAutores()
        {
            return usuario.MostrarAutores();
        }
        
        public DataTable MostrarUsuarios()
        {
            return usuario.MostrarUsuarios();
        }

        /// <summary>
        /// Metodo de acceso a procedimiento almacenado MostrarAutores_5
        /// </summary>
        /// <param name="valores">Codigo, nombre, apellidos, pais, ciudad</param>
        /// <returns></returns>
        public DataTable MostrarAutor_5(List<string> valores)
        {
            return usuario.MostrarAutores_5(valores);
        }
        #endregion


        public bool ActualizarGenero(string cod, string descripcion = null)
        {
            return usuario.ActualizarGenero(cod, descripcion);
        }

        public object AutorCant(int cant)
        {
            return usuario.AutorCant(cant);
        }

        public bool InsertarAutor(ObjetoAutor autor) 
        {
            return usuario.InsertarAutor(autor);
        }

        public ObjetoAutor MostrarAutor(string codigo)
        {
            return usuario.MostrarAutor(codigo);
        }

        #region  MetodosEliminar

        public bool EliminarTema(string codigo)
        {
            return usuario.EliminarTema(codigo);
        }

        #endregion

    }
}
