using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Persistencia
{
    public class PersistenciaAdministrador : PersistenciaUsuario
    {
        public static bool Alta(Administrador administrador)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "alta_administrador";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@id", SqlDbType.Int);
            comando.Parameters.AddWithValue("@nombre", administrador.Nombre);
            comando.Parameters.AddWithValue("@apellido", administrador.Apellido);
            comando.Parameters.AddWithValue("@cedula", administrador.Cédula);
            comando.Parameters.AddWithValue("@telefono", administrador.Teléfono);
            comando.Parameters.AddWithValue("@usuario", administrador.UsuarioLogin);
            comando.Parameters.AddWithValue("@contrasenia", administrador.Contraseña);
            comando.Parameters["@id"].Direction = ParameterDirection.Output;
            try
            {
                conexión.Open();
                comando.ExecuteNonQuery();
                administrador.Id = Convert.ToInt32(comando.Parameters["@id"].Value);
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

        public static bool Modificar(Administrador administrador)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "modificar_administrador";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", administrador.Id);
            comando.Parameters.AddWithValue("@nombre", administrador.Nombre);
            comando.Parameters.AddWithValue("@apellido", administrador.Apellido);
            comando.Parameters.AddWithValue("@cedula", administrador.Cédula);
            comando.Parameters.AddWithValue("@telefono", administrador.Teléfono);
            comando.Parameters.AddWithValue("@usuario", administrador.UsuarioLogin);
            comando.Parameters.AddWithValue("@contrasenia", administrador.Contraseña);
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

        public static bool Listar(List<Administrador> lista)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "listar_administradores";
            comando.CommandType = CommandType.StoredProcedure;
            try
            {
                conexión.Open();
                using (var lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        var administrador = new Administrador(
                            Convert.ToInt32(lector["id_usuario_adm"]),
                            Convert.ToString(lector["nombre"]),
                            Convert.ToString(lector["apellido"]),
                            Convert.ToInt32(lector["cedula"]),
                            Convert.ToString(lector["telefono"]),
                            Convert.ToString(lector["usuario"]),
                            Convert.ToString(lector["contrasenia"])
                        );
                        lista.Add(administrador);
                    }
                }
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

        public static bool Obtener(Administrador administrador)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "obtener_administrador";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", administrador.Id);
            try
            {
                conexión.Open();
                using (var lector = comando.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        administrador.Nombre = Convert.ToString(lector["nombre"]);
                        administrador.Apellido = Convert.ToString(lector["apellido"]);
                        administrador.Cédula = Convert.ToInt32(lector["cedula"]);
                        administrador.Teléfono = Convert.ToString(lector["telefono"]);
                        administrador.UsuarioLogin = Convert.ToString(lector["usuario"]);
                        administrador.Contraseña = Convert.ToString(lector["contrasenia"]);
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
