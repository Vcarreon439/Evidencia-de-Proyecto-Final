using System.Data;
using Autenticacion;
using System.Data.SqlClient;

namespace AccesoADatos
{
    public class Usuario : ConexionSQL
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

        public TipoUsuario.TypeUser Autenticacion(string usuario) 
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = "select Rol from Managers where Nombre=@usuario";
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.CommandType = CommandType.Text;

                    switch ((string)cmd.ExecuteScalar())
                    {
                        case "ADMIN":
                            return TipoUsuario.TypeUser.Admin;
                            break;

                        case "USER":
                            return TipoUsuario.TypeUser.Usuario;
                            break;
                        
                        case "MANAGER":
                            return TipoUsuario.TypeUser.Maganer;
                            break;

                        case "GUEST":
                            return TipoUsuario.TypeUser.Invitado;
                            break;
                    }

                    return TipoUsuario.TypeUser.Invitado;
                }
            }
        }


    }
}
