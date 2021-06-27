using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using obligatorio.Dominio;

namespace obligatorio.Persistencia.Clases
{
    public class pCamion : Persistencia
    {
        public static bool AgregarCamion(Camion pCamion)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Camion_Agregar", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@marca", pCamion.Marca));
                cmd.Parameters.Add(new SqlParameter("@modelo", pCamion.Modelo));
                cmd.Parameters.Add(new SqlParameter("@ano", pCamion.Ano));
                cmd.Parameters.Add(new SqlParameter("@matriculaCamion", pCamion.Matricula));

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
            catch(Exception ex)
            {
                throw ex;
            }
            return retorno;
        }
    }
}