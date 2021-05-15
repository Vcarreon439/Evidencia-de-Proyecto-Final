using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AccesoADatos
{
    public class Usuario:ConexionSQL
    {
        public bool Login(string usuario, string contra) 
        {
            using (SqlConnection conexion = ObtenerConexion()) 
            {
                conexion.Open();
                using (SqlCommand cmd  = new SqlCommand()) 
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = "select * from Managers where Nombre=@usuario and Contraseña=@pass";
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@pass", contra);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader lector = cmd.ExecuteReader();

                    if (lector.HasRows)
                        return true;
                    else
                        return false;
                }
            }
        }


    }
}
