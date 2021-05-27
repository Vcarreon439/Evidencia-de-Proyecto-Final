using Autenticacion;
using GestionAutores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BibliotecaDeClases;

namespace AccesoADatos
{
    public class Usuario : ConexionSQL
    {

        #region Autenticacion

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

        #endregion

        #region Eliminar

        
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

        #endregion

        #region Mostrar

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

        public List<string> TemaCombo()
        {
            List<string> elementos = new List<string>();

            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("TemaCombo", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            elementos.Add(reader.GetString(0));
                    }

                    return elementos;
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
                            autor.Imagen = reader["foto"].ToString();
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

        public DataTable UsuariosCant(int cantidad)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                using (SqlDataAdapter adaptador = new SqlDataAdapter("UsuariosCant", conexion))
                {
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adaptador.SelectCommand.Parameters.AddWithValue("@cant", cantidad);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    return tabla;
                }
            }
        }

        public DataTable MostrarManagers()
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                using (SqlDataAdapter adaptador = new SqlDataAdapter("MostrarManagers", conexion))
                {
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    return tabla;
                }
            }
        }

        public ObjectManager MostrarManager(string codigo)
        {
            ObjectManager mana = new ObjectManager();

            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("MostrarManager", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cod", codigo);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            mana.Codigo = reader["Id"].ToString();
                            mana.Nombre = reader["Nombre"].ToString();
                            mana.Contraseña = reader["Contraseña"].ToString();
                            mana.Rol = reader["Rol"].ToString();
                        }

                        return mana;
                    }
                }
            }
        }

        #endregion

        #region Actualizar

        public bool ActualizarAutor(ObjetoAutor autor)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("ActualizarAutor", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@cod", autor.Codigo));
                        cmd.Parameters.Add(new SqlParameter("@nombres", autor.Nombres));
                        cmd.Parameters.Add(new SqlParameter("@apellidos", autor.Apellidos));
                        cmd.Parameters.Add(new SqlParameter("@pais", autor.Pais));
                        cmd.Parameters.Add(new SqlParameter("@ciudad", autor.Ciudad));
                        cmd.Parameters.Add(new SqlParameter("@comentarios", autor.Comentarios));
                        cmd.Parameters.Add(new SqlParameter("@foto", autor.Imagen));

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

        public bool ActualizarManager(ObjectManager manager)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("ActualizarManager", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@cod", manager.Codigo));
                        cmd.Parameters.Add(new SqlParameter("@nombre", manager.Nombre));
                        cmd.Parameters.Add(new SqlParameter("@contra", manager.Contraseña));
                        cmd.Parameters.Add(new SqlParameter("@rol", manager.Rol));

                        int valor = cmd.ExecuteNonQuery();

                        if (valor != 0)
                            return true;
                        else
                            return false;
                    }
                }
                catch (SqlException error)
                {
                    Console.WriteLine(error.Number);
                    return false;
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

        #endregion

        #region Insertar
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
                    MessageBox.Show("Este registro ya existe en la base de datos", $"Error {error.Number}", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
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

                    if (informacion.Imagen != null)
                        cmd.Parameters.AddWithValue("@foto", informacion.Imagen);
                    else
                        cmd.Parameters.AddWithValue("@foto", DBNull.Value);


                    if (cmd.ExecuteNonQuery() != 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        public bool InsertarMiembro(ObjetoMiembro miembro)
        {
            try
            {
                using (SqlConnection conexion = ObtenerConexion())
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("InsertarMiembro", conexion))
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;


                        //
                        if (miembro.CURP!="")
                            cmd.Parameters.AddWithValue("@curp", miembro.CURP);
                        else
                            cmd.Parameters.AddWithValue("@curp", DBNull.Value);


                        //
                        if (miembro.Nombres != "")
                            cmd.Parameters.AddWithValue("@nombre", miembro.Nombres);
                        else
                            cmd.Parameters.AddWithValue("@nombre", DBNull.Value);

                        //
                        if (miembro.Apellidos != "")
                            cmd.Parameters.AddWithValue("@apellidos", miembro.Apellidos);
                        else
                            cmd.Parameters.AddWithValue("@apellidos", DBNull.Value);

                        
                        //
                        if (miembro.Entidad != "")
                            cmd.Parameters.AddWithValue("@entidad", miembro.Entidad);
                        else
                            cmd.Parameters.AddWithValue("@entidad", DBNull.Value);

                        //
                        if (miembro.Sexo != "")
                            cmd.Parameters.AddWithValue("@sexo", miembro.Sexo);
                        else
                            cmd.Parameters.AddWithValue("@sexo", DBNull.Value);

                        //
                        if (miembro.Domicilio != "")
                            cmd.Parameters.AddWithValue("@domicilio", miembro.Domicilio);
                        else
                            cmd.Parameters.AddWithValue("@domicilio", DBNull.Value);

                        //
                        if (miembro.FechaNac != "")
                            cmd.Parameters.AddWithValue("@fecha", miembro.FechaNac);
                        else
                            cmd.Parameters.AddWithValue("@fecha", DBNull.Value);

                        //
                        if (miembro.Imagen != null)
                            cmd.Parameters.AddWithValue("@imagen", miembro.Imagen);
                        else
                            cmd.Parameters.AddWithValue("@imagen", DBNull.Value);


                        if (cmd.ExecuteNonQuery() != 0)
                            return true;
                        else
                            return false;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool InsertarManager(string nombre, string contra, string rol)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("InsertarManager", conexion))
                {
                    cmd.Connection = conexion;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@contra", contra);
                    cmd.Parameters.AddWithValue("@rol", rol);

                    if (cmd.ExecuteNonQuery() != 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        public bool InsertarEditorial(ObjetoEditorial editorial)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("InsertarEditorial", conexion))
                {
                    cmd.Connection = conexion;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@cod", editorial.Codigo);
                    cmd.Parameters.AddWithValue("@nombre", editorial.Nombre);

                    if (editorial.Telefono != "")
                        cmd.Parameters.AddWithValue("@telefono", editorial.Telefono);
                    else
                        cmd.Parameters.AddWithValue("@telefono", DBNull.Value);

                    if (editorial.Correo != "")
                        cmd.Parameters.AddWithValue("@correo", editorial.Correo);
                    else
                        cmd.Parameters.AddWithValue("@correo", DBNull.Value);


                    if (editorial.Direccion != "")
                        cmd.Parameters.AddWithValue("@direccion", editorial.Direccion);
                    else
                        cmd.Parameters.AddWithValue("@direccion", DBNull.Value);


                    if (cmd.ExecuteNonQuery() != 0)
                        return true;
                    else
                        return false;
                }
            }
        }


        #endregion
    }
}
