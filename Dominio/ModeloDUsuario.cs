﻿using System;
using System.Data;
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
        
        public DataTable MostrarAutor()
        {
            return usuario.MostrarAutor();
        }
        
        public DataTable MostrarUsuarios()
        {
            return usuario.MostrarUsuarios();
        }

        /// <summary>
        /// Metodo de acceso a procedimiento almacenado MostrarAutor_5
        /// </summary>
        /// <param name="valores">Codigo, nombre, apellidos, pais, ciudad</param>
        /// <returns></returns>
        public DataTable MostrarAutor_5(List<string> valores)
        {
            return usuario.MostrarAutor_5(valores);
        }
        #endregion


        public bool ActualizarGenero(string cod, string descripcion = null)
        {
            return usuario.ActualizarGenero(cod, descripcion);
        }

        public bool InsertarAutor(List<string> lista) 
        {
            return usuario.InsertarAutor(lista);
        }

    }
}
