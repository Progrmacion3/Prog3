using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Clases;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia.Clases
{
    public class Parada : Persistencia
    {
        public static bool AgregarParada(Common.Clases.Parada pParada)
        {
            bool retorno = true;

            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("AgregarParadaCamionero", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@IdViaje", pParada.IdViaje));
                cmd.Parameters.Add(new SqlParameter("@TipoParada", pParada.Tipo));
                cmd.Parameters.Add(new SqlParameter("@comentario", pParada.Comentario));


                int rtn = cmd.ExecuteNonQuery();
                if (rtn <= 0)
                {
                    retorno = false;
                }

                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public static string MostrarRotura(int pId, string pUsuario)
        {
            string retorno;

            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("MostrarRotura", conexion);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@IdViaje", pId));
                cmd.Parameters.Add(new SqlParameter("@Usuario", pUsuario));

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    retorno = Convert.ToString(oReader["Comentario"]).ToString();
                }

                conexion.Close();
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }
        public static List<Common.Clases.Parada> MostrarEstadoRotura(int pIdViaje, string pUsuario)
        {
            List<Common.Clases.Parada> retorno = new List<Common.Clases.Parada>();
            Common.Clases.Parada parada;

            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("MostrarRotura", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@IdViaje", pIdViaje));
                cmd.Parameters.Add(new SqlParameter("@Usuario", pUsuario));

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        parada = new Common.Clases.Parada();

                        parada.IdViaje = int.Parse(oReader["IdViaje"].ToString());
                        parada.IdParada = int.Parse(oReader["IdParada"].ToString());
                        parada.Comentario = oReader["Comentario"].ToString();
                        parada.Hora = Convert.ToDateTime(oReader["Hora"].ToString());
                        
                        retorno.Add(parada);
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }
        public static bool EliminarParada(Common.Clases.Parada pParada)
        {
            throw new NotImplementedException();
        }

        public static bool ModificarParada(Common.Clases.Parada pParada)
        {
            bool retorno = true;

            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("ModificarParadasAdmin", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idViaje", pParada.IdViaje));
                cmd.Parameters.Add(new SqlParameter("@idParada", pParada.IdParada));
                cmd.Parameters.Add(new SqlParameter("@Comentario", pParada.Comentario));
                cmd.Parameters.Add(new SqlParameter("@Estado", pParada.Estado));


                int rtn = cmd.ExecuteNonQuery();
                if (rtn <= 0)
                {
                    retorno = false;
                }

                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }
        public static List<Common.Clases.Parada> MostrarParadas()
        {
            List<Common.Clases.Parada> retorno = new List<Common.Clases.Parada>();
            Common.Clases.Parada parada;

            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("mostrarParadas", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        parada = new Common.Clases.Parada();
                        parada.IdParada = int.Parse(oReader["IdParada"].ToString());
                        parada.IdViaje = int.Parse(oReader["IdViaje"].ToString());
                        parada.Tipo = oReader["TipoParada"].ToString();
                        parada.Comentario = oReader["Comentario"].ToString();
                        parada.Estado = oReader["Estado"].ToString();
                        parada.Hora = Convert.ToDateTime(oReader["Hora"].ToString());


                        retorno.Add(parada);
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }
        public static Common.Clases.Parada MostrarParadaEspecifica(Common.Clases.Parada pParada)
        {
            Common.Clases.Parada retorno = null;
            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("mostrarParadaEspecifica", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idParada", pParada.IdParada));

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        retorno = new Common.Clases.Parada();
                        retorno.IdParada = int.Parse(oReader["IdParada"].ToString());
                        retorno.IdViaje = int.Parse(oReader["IdViaje"].ToString());
                        retorno.Tipo = oReader["TipoParada"].ToString();
                        retorno.Comentario = oReader["Comentario"].ToString();
                        retorno.Hora = Convert.ToDateTime(oReader["Hora"].ToString());
     
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }
    }
}
