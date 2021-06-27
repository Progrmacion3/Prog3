using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Persistencia.Clases
{
    public class pParada : Persistencia
    {
        public static bool AltaParada(Common.Clases.Parada pParada)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Parada_Agregar", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@idViaje", pParada.Viaje.Id));
                cmd.Parameters.Add(new SqlParameter("@tipo", pParada.Tipo));
                cmd.Parameters.Add(new SqlParameter("@comentarioParada", pParada.Comentario));

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

        public static bool BajaParada(Common.Clases.Parada pParada)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Parada_Eliminar", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@id", pParada.Id));

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

        public static List<Common.Clases.Parada> ListarParadas()
        {
            List<Common.Clases.Parada> ListaParadas = new List<Common.Clases.Parada>();
            Common.Clases.Parada parada;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Parada_TraerTodas", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // ejecutamos el store desde c#
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {

                    while (oReader.Read())
                    {
                        parada = new Common.Clases.Parada();
                        parada.Id = short.Parse(oReader["matriculaCamion"].ToString());
                        parada.Viaje.Id = short.Parse(oReader["idViaje"].ToString());
                        parada.Tipo = oReader["tipoParada"].ToString();
                        parada.Comentario = oReader["comentarioParada"].ToString();
                        ListaParadas.Add(parada);
                    }

                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ListaParadas;
        }

        public static Common.Clases.Parada TraerParada(Common.Clases.Parada pParada)
        {
            Common.Clases.Parada parada = null;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Parada_TraerEspecifica", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@id", pParada.Id));

                // ejecutamos el store desde c#
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {

                    while (oReader.Read())
                    {
                        parada = new Common.Clases.Parada();
                        parada.Id = short.Parse(oReader["idParada"].ToString());
                        parada.Viaje.Id = short.Parse(oReader["idViaje"].ToString());
                        parada.Tipo = oReader["tipoParada"].ToString();
                        parada.Comentario = oReader["comentarioParada"].ToString();

                    }

                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return parada;
        }
    }
}
