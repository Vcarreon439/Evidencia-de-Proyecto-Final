using System;
using System.Windows.Forms;
using System.Data;
using Autenticacion;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections.Generic;

namespace AccesoADatos
{
    public class Usuario : ConexionSQL
    {
        public DataTable MostrarGenerosCant(int cantidad)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                using (SqlDataAdapter adaptador = new SqlDataAdapter("TemaCant", conexion))
                {
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adaptador.SelectCommand.Parameters.Add("@cant", cantidad);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    return tabla;
                }
            }

        }

        public List<string> GenerosCombo(int cant)
        {
            List<string> elementos = new List<string>();

            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("TemaCombo", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cant", cant);
                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            elementos.Add(reader.GetString(0));
                    }

                    return elementos;
                }
            }
        }


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

        public object AutorCant(int cant)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                using (SqlDataAdapter adaptador = new SqlDataAdapter("AutorCant", conexion))
                {
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adaptador.SelectCommand.Parameters.Add("@cant", cant);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    return tabla;
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

                    switch ((string) cmd.ExecuteScalar())
                    {
                        case "ADMIN":
                            return TipoUsuario.TypeUser.Admin;

                        case "USER":
                            return TipoUsuario.TypeUser.Usuario;

                        case "MANAGER":
                            return TipoUsuario.TypeUser.Maganer;

                        case "GUEST":
                            return TipoUsuario.TypeUser.Invitado;

                        default:
                            return TipoUsuario.TypeUser.Invitado;
                    }
                }
            }
        }

        public bool InsertarGenero(string codigo, string definicion)
        {
            try
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
            catch (SqlException error)
            {
                if (error.Number == 2627)
                    MessageBox.Show("Este registro ya existe en la base de datos",$"Error {error.Number}", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
        }
    


    public bool EliminarTema(string codigo)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("EliminarTema", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codTema", codigo);

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
        
        public DataTable MostrarUsuarios()
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                using (SqlDataAdapter adaptador = new SqlDataAdapter("MostrarUsuarios", conexion))
                {
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    return tabla;
                }
            }
        }


        /// <summary>
        /// Metodo de acceso a procedimiento almacenado MostrarAutor_5 de la base de datos
        /// </summary>
        /// <param name="elementos">Codigo, nombre, apellidos, pais, ciudad</param>
        /// <returns>Retorna una tabla de los datos (Codigo, nombre, apellidos, pais, ciudad) del autor)</returns>
        public DataTable MostrarAutor_5(List<string> elementos)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                using (SqlDataAdapter adaptador = new SqlDataAdapter("MostrarAutor_5", conexion))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@cod", elementos[0]);
                    adaptador.SelectCommand.Parameters.AddWithValue("@nombre", elementos[1]);
                    adaptador.SelectCommand.Parameters.AddWithValue("@apellidos", elementos[2]);
                    adaptador.SelectCommand.Parameters.AddWithValue("@pais", elementos[3]);
                    adaptador.SelectCommand.Parameters.AddWithValue("@ciudad", elementos[4]);


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
                try
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("ActualizarGenero1", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@cod", cod));
                        cmd.Parameters.Add(new SqlParameter("@cambio", descripcion));

                        int valor = cmd.ExecuteNonQuery();

                        if (valor != 0)
                            return true;
                    }
                }
                catch (SqlException error)
                {
                    Console.WriteLine(error.Number);
                    return false;
                }

                return false;

            }
        }
    }
}
