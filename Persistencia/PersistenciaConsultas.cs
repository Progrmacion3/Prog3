using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Persistencia
{
    public class PersistenciaConsultas : Persistencia
    {
        public static bool ListarViajesOrdenadosDelMes(List<Viaje> lista)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "listar_viajes_ordenados_del_mes";
            comando.CommandType = CommandType.StoredProcedure;
            try
            {
                conexión.Open();
                using (var lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        var id = Convert.ToInt32(lector["id_viaje"]);
                        var viaje = new Viaje(id);
                        PersistenciaViaje.LeerViaje(lector, viaje);
                        lista.Add(viaje);
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

        public static bool ListarViajes(Camionero camionero, List<Viaje> lista)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "listar_viajes_de_camionero";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_camionero", camionero.Id);
            try
            {
                conexión.Open();
                using (var lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        var id = Convert.ToInt32(lector["id_viaje"]);
                        var viaje = new Viaje(id);
                        PersistenciaViaje.LeerViaje(lector, viaje);
                        lista.Add(viaje);
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

        public static bool ObtenerCamioneroPorCédula(Camionero camionero)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "buscar_camionero_por_cedula";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cedula", camionero.Cédula);
            try
            {
                conexión.Open();
                using (var lector = comando.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        camionero.Id = Convert.ToInt32(lector["id_usuario_camionero"]);
                        camionero.Nombre = Convert.ToString(lector["nombre"]);
                        camionero.Apellido = Convert.ToString(lector["apellido"]);
                        camionero.Teléfono = Convert.ToString(lector["telefono"]);
                        camionero.UsuarioLogin = Convert.ToString(lector["usuario"]);
                        camionero.Contraseña = Convert.ToString(lector["contrasenia"]);
                        camionero.Nacimiento = Convert.ToDateTime(lector["fec_nac"]);
                        camionero.TipoLibreta = Convert.ToString(lector["tipo_lib"]);
                        camionero.VencimientoLibreta = Convert.ToDateTime(lector["venc_lib"]);
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

        public static bool ListarParadas(Viaje viaje, List<Estado> lista)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "listar_paradas_del_viaje";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_viaje", viaje.Id);
            try
            {
                conexión.Open();
                using (var lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        var id = Convert.ToInt32(lector["id_estado"]);
                        var tipo = Convert.ToString(lector["tipo"]);
                        var time = Convert.ToDateTime(lector["time"]);
                        var kilaje = Convert.ToInt32(lector["kilaje"]);
                        var comentario = Convert.ToString(lector["comentario"]);
                        var estado = new Estado(id, tipo, time, kilaje, comentario);
                        lista.Add(estado);
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

        public static bool Obtener(Estado estado, Viaje viaje)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "obtener_estado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_viaje", viaje.Id);
            comando.Parameters.AddWithValue("@id_estado", estado.Id);
            try
            {
                conexión.Open();
                using (var lector = comando.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        estado.Tipo = Convert.ToString(lector["tipo"]);
                        estado.Time = Convert.ToDateTime(lector["time"]);
                        estado.Kilaje = Convert.ToInt32(lector["kilaje"]);
                        estado.Comentario = Convert.ToString(lector["comentario"]);
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
