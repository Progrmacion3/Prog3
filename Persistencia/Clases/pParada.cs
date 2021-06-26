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
    }
}

