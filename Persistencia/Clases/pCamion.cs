using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace Persistencia.Clases
{
    public class pCamion : Persistencia
    {
        public static bool AgregarCamion(Common.Clases.Camion pCamion)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Agregar_Camion", conn);

                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add(new SqlParameter("@matriculaCamion", pCamion.Matricula));
                cmd.Parameters.Add(new SqlParameter("@ModeloCamion ", pCamion.Modelo));
                cmd.Parameters.Add(new SqlParameter("@marcaCamion", pCamion.Marca));
                cmd.Parameters.Add(new SqlParameter("@añoCamion ", pCamion.Año));
                

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



        public static bool ModificarCamion(Common.Clases.Camion pCamion)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Modificar_Camion", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@matriculaCamion", pCamion.Matricula));
                cmd.Parameters.Add(new SqlParameter("@ModeloCamion ", pCamion.Modelo));
                cmd.Parameters.Add(new SqlParameter("@marcaCamion", pCamion.Marca));
                cmd.Parameters.Add(new SqlParameter("@añoCamion ", pCamion.Año));

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


        public static bool EliminarCamion(Common.Clases.Camion pCamion)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Eliminar_Camion", conn);

                cmd.CommandType = CommandType.StoredProcedure;

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
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }
    }
}