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

        public static bool ListarCamioneros(int cédula, List<Camionero> lista)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "buscar_camionero_por_cedula";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cedula", cédula);
            try
            {
                conexión.Open();
                using (var lector = comando.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        var camionero = new Camionero(
                            Convert.ToInt32(lector["id_usuario_camionero"]),
                            Convert.ToString(lector["nombre"]),
                            Convert.ToString(lector["apellido"]),
                            Convert.ToInt32(lector["cedula"]),
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
    }
}
