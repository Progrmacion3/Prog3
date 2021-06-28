using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Persistencia.Clases
{
   public class pViaje : Persistencia
    {
        public static bool AltaViaje(Common.Clases.Viaje pViaje)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Viaje_Agregar", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@camioneroViaje", pViaje.Camionero.CI));
                cmd.Parameters.Add(new SqlParameter("@camionViaje", pViaje.Camion.Matricula));
                cmd.Parameters.Add(new SqlParameter("@tipoCargaViaje", pViaje.TipoCarga));
                cmd.Parameters.Add(new SqlParameter("@kilaje", pViaje.Kilaje));
                cmd.Parameters.Add(new SqlParameter("@origen", pViaje.Origen));
                cmd.Parameters.Add(new SqlParameter("@destino", pViaje.Destino));
                cmd.Parameters.Add(new SqlParameter("@fechaInicio", pViaje.FechaInicio));
                cmd.Parameters.Add(new SqlParameter("@fechaFinalizacion", pViaje.FechaFinalizacion));
                cmd.Parameters.Add(new SqlParameter("@estado", pViaje.Estado));

                // ejecutamos el store desde c#
                int rtn = cmd.ExecuteNonQuery();

                if (rtn <= 0)
                {
                    retorno = false;
                }

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

        public static bool BajaViaje(Common.Clases.Viaje pViaje)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Viaje_Eliminar", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@idViaje", pViaje.Id));

                // ejecutamos el store desde c#
                int rtn = cmd.ExecuteNonQuery();

                if (rtn <= 0)
                {
                    retorno = false;
                }

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

        public static bool ModificarViaje(Common.Clases.Viaje pViaje)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Viaje_Modificar", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@idViaje", pViaje.Id));
                cmd.Parameters.Add(new SqlParameter("@camioneroViaje", pViaje.Camionero.CI));
                cmd.Parameters.Add(new SqlParameter("@camionViaje", pViaje.Camion.Matricula));
                cmd.Parameters.Add(new SqlParameter("@tipoCargaViaje", pViaje.TipoCarga));
                cmd.Parameters.Add(new SqlParameter("@kilaje", pViaje.Kilaje));
                cmd.Parameters.Add(new SqlParameter("@origen", pViaje.Origen));
                cmd.Parameters.Add(new SqlParameter("@destino", pViaje.Destino));
                cmd.Parameters.Add(new SqlParameter("@fechaInicio", pViaje.FechaInicio));
                cmd.Parameters.Add(new SqlParameter("@fechaFinalizacion", pViaje.FechaFinalizacion));
                cmd.Parameters.Add(new SqlParameter("@estado", pViaje.Estado));
                
                // ejecutamos el store desde c#
                int rtn = cmd.ExecuteNonQuery();

                if (rtn <= 0)
                {
                    retorno = false;
                }

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

        public static List<Common.Clases.Viaje> ListarViajes()
        {
            List<Common.Clases.Viaje> ListaViajes = new List<Common.Clases.Viaje>();
            Common.Clases.Viaje viaje;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Viaje_TraerTodos", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // ejecutamos el store desde c#
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {

                    while (oReader.Read())
                    {
                        viaje = new Common.Clases.Viaje();
                        viaje.Id = short.Parse(oReader["idViaje"].ToString());
                        viaje.Camionero = new Common.Clases.Camionero();
                        viaje.Camionero.CI = int.Parse(oReader["camioneroViaje"].ToString());
                        viaje.Camion = new Common.Clases.Camion();
                        viaje.Camion.Matricula = oReader["camionViaje"].ToString();
                        viaje.TipoCarga = oReader["tipoDeCargaViaje"].ToString();
                        viaje.Kilaje = int.Parse(oReader["kilajeViaje"].ToString());
                        viaje.Origen = oReader["origenViaje"].ToString();
                        viaje.Destino = oReader["destinoViaje"].ToString();
                        viaje.FechaInicio = oReader["fechaInicioViaje"].ToString();
                        viaje.FechaFinalizacion = oReader["fechaFinalizacionViaje"].ToString();
                        viaje.Estado = oReader["estadoViaje"].ToString();
                        ListaViajes.Add(viaje);
                    }

                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ListaViajes;
        }

        public static Common.Clases.Viaje TraerViaje(Common.Clases.Viaje pViaje)
        {
            Common.Clases.Viaje viaje = null;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Viaje_TraerEspecifico", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@idViaje", pViaje.Id));

                // ejecutamos el store desde c#
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {

                    while (oReader.Read())
                    {
                        viaje = new Common.Clases.Viaje();
                        viaje.Id = short.Parse(oReader["idViaje"].ToString());
                        viaje.Camionero = new Common.Clases.Camionero();
                        viaje.Camionero.CI = int.Parse(oReader["camioneroViaje"].ToString());
                        viaje.Camion = new Common.Clases.Camion();
                        viaje.Camion.Matricula = oReader["camionViaje"].ToString();
                        viaje.TipoCarga = oReader["tipoDeCargaViaje"].ToString();
                        viaje.Kilaje = int.Parse(oReader["kilajeViaje"].ToString());
                        viaje.Origen = oReader["origenViaje"].ToString();
                        viaje.Destino = oReader["destinoViaje"].ToString();
                        viaje.FechaInicio = oReader["fechaInicioViaje"].ToString();
                        viaje.FechaFinalizacion = oReader["fechaFinalizacionViaje"].ToString();
                        viaje.Estado = oReader["estadoViaje"].ToString();

                    }

                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return viaje;
        }
    }
}
