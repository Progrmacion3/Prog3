using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using obligatorio.Dominio;

namespace obligatorio.Persistencia.Clases
{
    public class pParada : Persistencia
    {
        public static bool AgregarParada(Parada pParada)
        {
            bool retorno = true;
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Parada_Agregar", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idParada", pParada.Id));
                cmd.Parameters.Add(new SqlParameter("@comentario", pParada.Comentario));
                cmd.Parameters.Add(new SqlParameter("@razon", pParada.Razon));
                cmd.Parameters.Add(new SqlParameter("@idViaje", pParada.IdViaje));


                int rtn = cmd.ExecuteNonQuery();

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

        public static bool EliminarParada(Parada pParada)
        {
            bool retorno = true;
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Parada_Eliminar", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idParada", pParada.Id));

                int rtn = cmd.ExecuteNonQuery();

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

        public static bool ParadaCamion(Parada pParada)
        {
            bool retorno = true;
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Parada_Modificar", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idParada", pParada.Id));
                cmd.Parameters.Add(new SqlParameter("@comentario", pParada.Comentario));
                cmd.Parameters.Add(new SqlParameter("@razon", pParada.Razon));
                cmd.Parameters.Add(new SqlParameter("@idViaje", pParada.IdViaje));


                int rtn = cmd.ExecuteNonQuery();

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
    }
}