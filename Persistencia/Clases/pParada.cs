using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia.Clases
{
    public class pParada : Persistencia
    {
        public static bool AgregarParada(Common.Clases.Parada pPar)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Agregar_Parada", conn);

                cmd.CommandType = CommandType.StoredProcedure;

               
                cmd.Parameters.Add(new SqlParameter("@EstadoParada", pPar.EstadoParada));
                cmd.Parameters.Add(new SqlParameter("@tipoParada", pPar.Tipo));
                cmd.Parameters.Add(new SqlParameter("@comentarioParada", pPar.Comentario));


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




        public static bool ModificarParada(Common.Clases.Parada pPar)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Modificar_Parada", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idParada", pPar.identificadorPar));
                cmd.Parameters.Add(new SqlParameter("@EstadoParada", pPar.EstadoParada));
                cmd.Parameters.Add(new SqlParameter("@tipoParada", pPar.Tipo));
                cmd.Parameters.Add(new SqlParameter("@comentarioParada", pPar.Comentario));

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


        public static bool EliminarParada(Common.Clases.Parada pPar)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Eliminar_Parada", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@identificadorPar", pPar.identificadorPar));

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

        public static List<Common.Clases.Parada> TraerTodasLasParadas()
        {
            List<Common.Clases.Parada> retornarPar = new List<Common.Clases.Parada>();
            Common.Clases.Parada parada;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("TraerTodasLasParadas", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        parada = new Common.Clases.Parada();
                        parada.identificadorPar = int.Parse(oReader["idParada"].ToString());
                        parada.EstadoParada= oReader["estadoParada"].ToString();
                        parada.Tipo = oReader["tipoParada"].ToString();
                        parada.Comentario = oReader["comentarioParada"].ToString();
                        retornarPar.Add(parada);
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retornarPar;
        }

        public static Common.Clases.Parada TraerUnaParadaEnEspecifica(Common.Clases.Parada pPar)
        {

            Common.Clases.Parada parada = null;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("TraerUnaParadaEnEspecifica", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idParada", pPar.identificadorPar));

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        parada = new Common.Clases.Parada();
                        parada.identificadorPar = int.Parse(oReader["idParada"].ToString());
                        parada.EstadoParada = oReader["estadoParada"].ToString();
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

