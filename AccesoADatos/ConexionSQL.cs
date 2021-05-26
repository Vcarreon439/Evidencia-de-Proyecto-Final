using System;
using System.IO;
using Autenticacion;
using System.Data.SqlClient;

namespace AccesoADatos
{
    public abstract class ConexionSQL
    {
        private readonly string cadenaConexion;

        public ConexionSQL() 
        {
            //cadenaConexion = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Path.GetFullPath("./LibreriaBD.mdf")};Integrated Security = True";
            cadenaConexion = $"Data Source=DESKTOP-185RN13\\SQLEXPRESS;Database = LibreriaBD; Integrated Security = True";
        }

        protected SqlConnection ObtenerConexion()
        { 
            return new SqlConnection(cadenaConexion); 
        }

    }

}
