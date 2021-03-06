using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autenticacion;
using System.Threading.Tasks;
using AccesoADatos;
using BibliotecaDeClases;
using GestionAutores;

namespace Dominio
{
    public class ModeloDUsuario
    {
        Usuario usuario = new Usuario();

        public bool EliminarAutor(ObjetoAutor autor)
        {
            return usuario.EliminarAutor(autor);
        }

        public bool InsertarMiembro(ObjetoMiembro miembro)
        {
            return usuario.InsertarMiembro(miembro);
        }

        public bool ActualizarAutor(ObjetoAutor autor)
        {
            return usuario.ActualizarAutor(autor);
        }

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

        public List<string> TemaCombo()
        {
            return usuario.TemaCombo();
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

        public DataTable UsuariosCant(int cantidad)
        {
            return usuario.UsuariosCant(cantidad);
        }

        public DataTable MostrarManagers()
        {
            return usuario.MostrarManagers();
        }

        public bool InsertarManager(string nombre, string contra, string rol)
        {
            return usuario.InsertarManager(nombre,contra,rol);
        }

        public ObjectManager MostrarManager(string codigo)
        {
            return usuario.MostrarManager(codigo);
        }

        public bool ActualizarManager(ObjectManager manager)
        {
            return usuario.ActualizarManager(manager);
        }

        public bool InsertarEditorial(ObjetoEditorial editorial)
        {
            return usuario.InsertarEditorial(editorial);
        }

        public DataTable MostrarEditoriales()
        {
            return usuario.MostrarEditoriales();
        }

        public DataTable MostrarEditorial(string cod, string nombre)
        {
            return usuario.MostrarEditorial(cod, nombre);
        }

        public bool ActualizarEditorial(ObjetoEditorial editorial)
        {
            return usuario.ActualizarEditorial(editorial);
        }

        public List<string> EditorialesCombo()
        {
            return usuario.EditorialesCombo();
        }

        public bool InsertarLibro(ObjetoLibro libro)
        {
            return usuario.InsertarLibro(libro);
        }

        public DataTable MostrarLibros()
        {
            return usuario.MostrarLibros();
        }

        public DataTable MostrarLibrosCant(int cantidad)
        {
            return usuario.MostrarLibrosCant(cantidad);
        }
    }
}
