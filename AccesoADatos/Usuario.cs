using System.Data;
using Autenticacion;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace AccesoADatos
{
    public class Usuario : ConexionSQL
    {

        public bool Login(string usuario, string contra)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand())
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

        public TipoUsuario.TypeUser Autenticacion(string usuario, string contraseña)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = "select Rol from Managers where Nombre=@usuario and Contraseña=@pass";
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@pass", contraseña);
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

        public bool InsertarGenero(string codigo, string definicion)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("Insercion_Genero", conexion))
                {
                    cmd.Connection = conexion;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@cod", codigo));
                    cmd.Parameters.Add(new SqlParameter("@tipo", definicion));

                    if (cmd.ExecuteNonQuery() != 0)
                        return true;
                    else
                        return false;
                }
            }
        }


        public bool InsertarAutor(List<string> informacion)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("InsertarAutor", conexion))
                {
                    List<string> param = new List<string>{ "@cod", "@nombre","@apellidos","@pais", "@ciudad", "@comentarios", "@foto"};

                    cmd.Connection = conexion;
                    cmd.CommandType = CommandType.StoredProcedure;

                    for (int i = 0; i < 7; i++)
                        cmd.Parameters.Add(param[i], informacion[i]);

                    if (cmd.ExecuteNonQuery() != 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        public DataTable MostrarGeneros()
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                using (SqlDataAdapter adaptador = new SqlDataAdapter("MostrarTemas", conexion))
                {
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    return tabla;
                }
            }
        }
        
        public DataTable MostrarAutor()
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                using (SqlDataAdapter adaptador = new SqlDataAdapter("MostrarAutor", conexion))
                {
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    return tabla;
                }
            }
        }

        public bool ActualizarGenero(string cod, string descripcion)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("ActualizarGenero1", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@cod", cod));
                    cmd.Parameters.Add(new SqlParameter("@cambio", descripcion));

                    if (cmd.ExecuteNonQuery() != 0)
                        return true;
                    else
                        return false;
                }
            }
        }
    }
}
