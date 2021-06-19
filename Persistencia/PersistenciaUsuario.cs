using Common;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Persistencia
{
    public class PersistenciaUsuario : Persistencia
    {
        public static bool Ingresar(Usuario usuario, out bool correcto, out char tipo)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "ingresar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", usuario.UsuarioLogin);
            comando.Parameters.AddWithValue("@contrasenia", usuario.Contraseña);
            comando.Parameters.Add("@id", SqlDbType.Int);
            comando.Parameters.Add("@correcto", SqlDbType.Bit);
            comando.Parameters.Add("@tipo", SqlDbType.Char, 1);
            comando.Parameters["@correcto"].Direction = ParameterDirection.Output;
            comando.Parameters["@tipo"].Direction = ParameterDirection.Output;
            comando.Parameters["@id"].Direction = ParameterDirection.Output;
            try
            {
                conexión.Open();
                comando.ExecuteNonQuery();
                correcto = Convert.ToBoolean(comando.Parameters["@correcto"].Value);
                tipo = Convert.ToChar(comando.Parameters["@tipo"].Value);
                usuario.Id = Convert.ToChar(comando.Parameters["@id"].Value);
                return true;
            }
            catch
            {
                correcto = false;
                tipo = ' ';
                return false;
            }
            finally
            {
                conexión.Close();
            }
        }

        public static bool Baja(Usuario usuario)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "baja_usuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", usuario.Id);
            try
            {
                conexión.Open();
                comando.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conexión.Close();
            }
        }

        public static bool Obtener(Usuario usuario)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "obtener_usuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", usuario.Id);
            try
            {
                conexión.Open();
                using (var lector = comando.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        usuario.Nombre = Convert.ToString(lector["nombre"]);
                        usuario.Apellido = Convert.ToString(lector["apellido"]);
                        usuario.Cédula = Convert.ToInt32(lector["cedula"]);
                        usuario.Cargo = Convert.ToString(lector["cargo"]);
                        usuario.Teléfono = Convert.ToString(lector["telefono"]);
                        usuario.UsuarioLogin = Convert.ToString(lector["usuario"]);
                        usuario.Contraseña = Convert.ToString(lector["contrasenia"]);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                conexión.Close();
            }
        }
    }
}
