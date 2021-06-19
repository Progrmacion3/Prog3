using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Persistencia
{
    public class PersistenciaCamión : Persistencia
    {
        public static bool Alta(Camión camión)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "alta_camion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@id", SqlDbType.Int);
            comando.Parameters.AddWithValue("@marca", camión.Marca);
            comando.Parameters.AddWithValue("@modelo", camión.Modelo);
            comando.Parameters.AddWithValue("@matricula", camión.Matrícula);
            comando.Parameters.AddWithValue("@anio", camión.Año);
            comando.Parameters["@id"].Direction = ParameterDirection.Output;
            try
            {
                conexión.Open();
                comando.ExecuteNonQuery();
                camión.Id = Convert.ToInt32(comando.Parameters["@id"].Value);
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

        public static bool Baja(Camión camión)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "baja_camion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", camión.Id);
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

        public static bool Modificar(Camión camión)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "modificar_camion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", camión.Id);
            comando.Parameters.AddWithValue("@marca", camión.Marca);
            comando.Parameters.AddWithValue("@modelo", camión.Modelo);
            comando.Parameters.AddWithValue("@matricula", camión.Matrícula);
            comando.Parameters.AddWithValue("@anio", camión.Año);
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

        public static bool Listar(List<Camión> lista)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "listar_camiones";
            comando.CommandType = CommandType.StoredProcedure;
            try
            {
                conexión.Open();
                using (var lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        var camión = new Camión(
                            Convert.ToInt32(lector["id_camion"]),
                            Convert.ToString(lector["marca"]),
                            Convert.ToString(lector["modelo"]),
                            Convert.ToString(lector["matricula"]),
                            Convert.ToInt32(lector["anio"])
                        );
                        lista.Add(camión);
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

        public static bool Obtener(Camión camión)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "obtener_usuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", camión.Id);
            try
            {
                conexión.Open();
                using (var lector = comando.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        camión.Marca = Convert.ToString(lector["marca"]);
                        camión.Modelo = Convert.ToString(comando.Parameters["modelo"].Value);
                        camión.Matrícula = Convert.ToString(comando.Parameters["matricula"].Value);
                        camión.Año = Convert.ToInt32(comando.Parameters["anio"].Value);
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
