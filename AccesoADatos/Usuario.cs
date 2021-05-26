using Autenticacion;
using GestionAutores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
                    adaptador.SelectCommand.Parameters.AddWithValue("@cant", cantidad);
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
                    cmd.CommandText = "select * from Managers where Nombre=@usuario and Contraseña=@pass"; cmd.Parameters.AddWithValue("@usuario", usuario);
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
                    adaptador.SelectCommand.Parameters.AddWithValue("@cant", cant);
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


        public bool InsertarAutor(ObjetoAutor informacion)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("InsertarAutor", conexion))
                {
                    cmd.Connection = conexion;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@cod", informacion.Codigo);
                    cmd.Parameters.AddWithValue("@nombre", informacion.Nombres);
                    cmd.Parameters.AddWithValue("@apellidos", informacion.Apellidos);
                    cmd.Parameters.AddWithValue("@pais", informacion.Pais);
                    cmd.Parameters.AddWithValue("@ciudad", informacion.Ciudad);
                    cmd.Parameters.AddWithValue("@comentarios", informacion.Comentarios);

                    //if (informacion.Imagen != null)
                    //    //cmd.Parameters.AddWithValue("@foto", SqlDbType.Image).Value = informacion.Imagen.GetBuffer();
                    //else
                    //    cmd.Parameters.AddWithValue("@foto", DBNull.Value);


                    if (cmd.ExecuteNonQuery() != 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        public ObjetoAutor MostrarAutor(string codigo)
        {
            ObjetoAutor autor = new ObjetoAutor();

            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("MostrarAutor", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cod", codigo);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            autor.Codigo = reader["Codigo"].ToString();
                            autor.Nombres = reader["nombres"].ToString();
                            autor.Apellidos = reader["apellidos"].ToString();
                            autor.Pais = reader["paisNac"].ToString();
                            autor.Ciudad = reader["ciudadNac"].ToString();
                            autor.Comentarios = reader["comentarios"].ToString();

                            MessageBox.Show($"{reader["foto"].GetType().ToString()}  {reader["foto"].ToString()}");

                            //if (reader["foto"] != null)
                            //    autor.Imagen = ImagenAutor.ToBytes(reader[6].ToString());
                            
                        }

                        return autor;
                    }
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

        //public ObjetoAutor MostrarAutor(string codigo)
        //{
        //    using (SqlConnection conexion = ObtenerConexion())
        //    {
        //        conexion.Open();

        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.Add("@cod", codigo);

        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
                    
        //        }

        //    }
        //}

        public DataTable MostrarAutores()
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                using (SqlDataAdapter adaptador = new SqlDataAdapter("MostrarAutores", conexion))
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
        /// Metodo de acceso a procedimiento almacenado MostrarAutores_5 de la base de datos
        /// </summary>
        /// <param name="elementos">Codigo, nombre, apellidos, pais, ciudad</param>
        /// <returns>Retorna una tabla de los datos (Codigo, nombre, apellidos, pais, ciudad) del autor)</returns>
        public DataTable MostrarAutores_5(List<string> elementos)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                using (SqlDataAdapter adaptador = new SqlDataAdapter("MostrarAutores_5", conexion))
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
