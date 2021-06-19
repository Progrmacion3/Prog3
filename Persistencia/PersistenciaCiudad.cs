using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Persistencia
{
    public class PersistenciaCiudad : Persistencia
    {
        public static bool Listar(List<Ciudad> lista)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "listar_ciudades";
            comando.CommandType = CommandType.StoredProcedure;
            try
            {
                conexión.Open();
                using (var lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        var ciudad = new Ciudad(
                            Convert.ToInt32(lector["id_ciudad"]),
                            Convert.ToString(lector["nombre"])
                        );
                        lista.Add(ciudad);
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

        public static bool Obtener(Ciudad ciudad)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "obtener_ciudad";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", ciudad.Id);
            try
            {
                conexión.Open();
                using (var lector = comando.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        ciudad.Nombre = Convert.ToString(lector["nombre"]);
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
