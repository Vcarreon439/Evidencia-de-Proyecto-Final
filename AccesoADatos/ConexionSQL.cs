using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos
{
    public abstract class ConexionSQL
    {
        private readonly string cadenaConexion;

        public ConexionSQL() 
        {
            cadenaConexion = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Path.GetFullPath("./LibreriaBD.mdf")};Integrated Security = True";
        }

        protected SqlConnection ObtenerConexion()
        { 
            return new SqlConnection(cadenaConexion); 
        }

    }

}
