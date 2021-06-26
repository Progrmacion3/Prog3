using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Persistencia
{
    public class PersistenciaViaje : Persistencia
    {
        public static bool Alta(Viaje viaje)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "alta_viaje";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@id", SqlDbType.Int);
            comando.Parameters.AddWithValue("@carga", viaje.Carga);
            comando.Parameters.AddWithValue("@fecha_ini", viaje.Inicio);
            comando.Parameters.AddWithValue("@fecha_fin", viaje.Fin);
            comando.Parameters.AddWithValue("@id_ciu_ini", viaje.Origen.Id);
            comando.Parameters.AddWithValue("@id_ciu_final", viaje.Destino.Id);
            comando.Parameters.AddWithValue("@id_camion", viaje.Camión.Id);
            comando.Parameters.AddWithValue("@id_usuario_camionero", viaje.Camionero.Id);
            comando.Parameters["@id"].Direction = ParameterDirection.Output;
            try
            {
                conexión.Open();
                comando.ExecuteNonQuery();
                viaje.Id = Convert.ToInt32(comando.Parameters["@id"].Value);
                var inicial = new Estado(1, "Propuesto", DateTime.Now);
                viaje.Estados.Add(inicial);
                return true;
            }
            catch // (Exception ex)
            {
                return false;
            }
            finally
            {
                conexión.Close();
            }
        }

        public static bool Baja(Viaje viaje)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "baja_viaje";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", viaje.Id);
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

        public static bool Listar(List<Viaje> lista)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "listar_viajes";
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
                        LeerViaje(lector, viaje);
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

        public static bool Obtener(Viaje viaje)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "obtener_viaje";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", viaje.Id);
            try
            {
                conexión.Open();
                using (var lector = comando.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        LeerViaje(lector, viaje);
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

        internal static void LeerViaje(SqlDataReader lector, Viaje viaje)
        {
            var carga = Convert.ToString(lector["carga"]);
            var inicio = Convert.ToDateTime(lector["fecha_ini"]);
            var fin = Convert.ToDateTime(lector["fecha_fin"]);
            var idOrigen = Convert.ToInt32(lector["id_ciu_ini"]);
            var nombreOrigen = Convert.ToString(lector["nombre_ciudad_ini"]);
            var idDestino = Convert.ToInt32(lector["id_ciu_final"]);
            var nombreDestino  = Convert.ToString(lector["nombre_ciudad_fin"]);
            var idCamión = Convert.ToInt32(lector["id_camion"]);
            var matrícula = Convert.ToString(lector["matricula"]);
            var idCamionero = Convert.ToInt32(lector["id_usuario_camionero"]);
            var nombreCamionero = Convert.ToString(lector["nombre_camionero"]);
            var apellidoCamionero = Convert.ToString(lector["apellido_camionero"]);

            var origen = new Ciudad(idOrigen, nombreOrigen);
            var destino = new Ciudad(idDestino, nombreDestino);
            var camión = new Camión(idCamión, matrícula);
            var camionero = new Camionero(idCamionero, nombreCamionero, apellidoCamionero);

            viaje.Carga = carga;
            viaje.Inicio = inicio;
            viaje.Fin = fin;
            viaje.Origen = origen;
            viaje.Destino = destino;
            viaje.Camión = camión;
            viaje.Camionero = camionero;
        }

        public static bool ViajeActual(Camionero camionero, out Viaje viaje)
        {
            viaje = new Viaje();
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "viaje_actual";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_camionero", camionero.Id);
            try
            {
                conexión.Open();
                using (var lector = comando.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        viaje.Id = Convert.ToInt32(lector["id_viaje"]);
                        return Obtener(viaje);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch // (Exception ex)
            {
                return false;
            }
            finally
            {
                conexión.Close();
            }
        }

        public static bool ObtenerEstadoActual(Viaje viaje, out Estado estado)
        {
            estado = new Estado();
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "obtener_estado_actual";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_viaje", viaje.Id);
            try
            {
                conexión.Open();
                using (var lector = comando.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        estado.Id = Convert.ToInt32(lector["id_estado"]);
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
            catch // (Exception ex)
            {
                return false;
            }
            finally
            {
                conexión.Close();
            }
        }

        public static bool Alta(Estado estado, Viaje viaje)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "alta_estado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_viaje", viaje.Id);
            comando.Parameters.Add("@id_estado", SqlDbType.Int);
            comando.Parameters.AddWithValue("@tipo", estado.Tipo);
            comando.Parameters.Add("@time", SqlDbType.Date);
            comando.Parameters.AddWithValue("@kilaje", estado.Kilaje);
            comando.Parameters.AddWithValue("@comentario", estado.Comentario);
            comando.Parameters["@id_estado"].Direction = ParameterDirection.Output;
            comando.Parameters["@time"].Direction = ParameterDirection.Output;
            try
            {
                conexión.Open();
                comando.ExecuteNonQuery();
                estado.Id = Convert.ToInt32(comando.Parameters["@id_estado"].Value);
                estado.Time = Convert.ToDateTime(comando.Parameters["@time"].Value);
                viaje.Estados.Add(estado);
                return true;
            }
            catch (Exception ex)
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
