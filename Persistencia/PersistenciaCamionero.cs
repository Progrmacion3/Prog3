using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Persistencia
{
    public class PersistenciaCamionero : PersistenciaUsuario
    {
        public static bool Alta(Camionero camionero)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "alta_camionero";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@id", SqlDbType.Int);
            comando.Parameters.AddWithValue("@nombre", camionero.Nombre);
            comando.Parameters.AddWithValue("@apellido", camionero.Apellido);
            comando.Parameters.AddWithValue("@cedula", camionero.Cédula);
            comando.Parameters.AddWithValue("@cargo", camionero.Cargo);
            comando.Parameters.AddWithValue("@telefono", camionero.Teléfono);
            comando.Parameters.AddWithValue("@usuario", camionero.UsuarioLogin);
            comando.Parameters.AddWithValue("@contrasenia", camionero.Contraseña);
            comando.Parameters.AddWithValue("@fec_nac", camionero.Nacimiento);
            comando.Parameters.AddWithValue("@tipo_lib", camionero.TipoLibreta);
            comando.Parameters.AddWithValue("@venc_lib", camionero.VencimientoLibreta);
            comando.Parameters["@id"].Direction = ParameterDirection.Output;
            try
            {
                conexión.Open();
                comando.ExecuteNonQuery();
                camionero.Id = Convert.ToInt32(comando.Parameters["@id"].Value);
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

        public static bool Modificar(Camionero camionero)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "modificar_administrador";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", camionero.Id);
            comando.Parameters.AddWithValue("@nombre", camionero.Nombre);
            comando.Parameters.AddWithValue("@apellido", camionero.Apellido);
            comando.Parameters.AddWithValue("@cedula", camionero.Cédula);
            comando.Parameters.AddWithValue("@cargo", camionero.Cargo);
            comando.Parameters.AddWithValue("@telefono", camionero.Teléfono);
            comando.Parameters.AddWithValue("@usuario", camionero.UsuarioLogin);
            comando.Parameters.AddWithValue("@contrasenia", camionero.Contraseña);
            comando.Parameters.AddWithValue("@fec_nac", camionero.Nacimiento);
            comando.Parameters.AddWithValue("@tipo_lib", camionero.TipoLibreta);
            comando.Parameters.AddWithValue("@venc_lib", camionero.VencimientoLibreta);
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

        public static bool Listar(List<Camionero> lista)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "listar_camioneros";
            comando.CommandType = CommandType.StoredProcedure;
            try
            {
                conexión.Open();
                using (var lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        var camionero = new Camionero(
                            Convert.ToInt32(lector["id_usuario_adm"]),
                            Convert.ToString(lector["nombre"]),
                            Convert.ToString(lector["apellido"]),
                            Convert.ToInt32(lector["cedula"]),
                            Convert.ToString(lector["cargo"]),
                            Convert.ToString(lector["telefono"]),
                            Convert.ToString(lector["usuario"]),
                            Convert.ToString(lector["contrasenia"]),
                            Convert.ToDateTime(lector["fec_nac"]),
                            Convert.ToString(lector["tipo_lib"]),
                            Convert.ToDateTime(lector["venc_lib"])
                        );
                        lista.Add(camionero);
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

        public static bool Obtener(Camionero camionero)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "obtener_usuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", camionero.Id);
            try
            {
                conexión.Open();
                using (var lector = comando.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        camionero.Nombre = Convert.ToString(lector["nombre"]);
                        camionero.Apellido = Convert.ToString(comando.Parameters["apellido"].Value);
                        camionero.Cédula = Convert.ToInt32(comando.Parameters["cedula"].Value);
                        camionero.Cargo = Convert.ToString(comando.Parameters["cargo"].Value);
                        camionero.Teléfono = Convert.ToString(comando.Parameters["telefono"].Value);
                        camionero.UsuarioLogin = Convert.ToString(comando.Parameters["usuario"].Value);
                        camionero.Contraseña = Convert.ToString(comando.Parameters["contrasenia"].Value);
                        camionero.Nacimiento = Convert.ToDateTime(comando.Parameters["fec_nac"].Value);
                        camionero.TipoLibreta = Convert.ToString(comando.Parameters["tipo_lib"].Value);
                        camionero.VencimientoLibreta = Convert.ToDateTime(comando.Parameters["venc_lib"].Value);
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
