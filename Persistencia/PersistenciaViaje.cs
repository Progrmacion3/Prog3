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
            comando.Parameters.AddWithValue("@id_ciu_ini", viaje.Origen);
            comando.Parameters.AddWithValue("@id_ciu_fin", viaje.Destino);
            comando.Parameters.AddWithValue("@id_camion", viaje.Camión.Id);
            comando.Parameters.AddWithValue("@id_usuario_camionero", viaje.Camionero.Id);
            comando.Parameters["@id"].Direction = ParameterDirection.Output;
            try
            {
                conexión.Open();
                comando.ExecuteNonQuery();
                viaje.Id = Convert.ToInt32(comando.Parameters["@id"].Value);
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
                        var viaje = new Viaje(
                            Convert.ToInt32(lector["id_viaje"]),
                            Convert.ToString(lector["carga"]),
                            Convert.ToDateTime(lector["fecha_ini"]),
                            Convert.ToDateTime(lector["fecha_fin"]),
                            new Ciudad(Convert.ToInt32(lector["id_ciu_ini"])),
                            new Ciudad(Convert.ToInt32(lector["id_ciu_fin"])),
                            new Camión(Convert.ToInt32(lector["id_camion"])),
                            new Camionero(Convert.ToInt32(lector["id_usuario_camionero"]))
                        );
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
    }
}
