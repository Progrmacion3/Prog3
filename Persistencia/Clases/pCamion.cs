using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Persistencia.Clases
{
   public class pCamion : Persistencia
    {
        public static bool AltaCamion(Common.Clases.Camion pCamion)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Camion_Agregar", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@matricula", pCamion.Matricula));
                cmd.Parameters.Add(new SqlParameter("@marca", pCamion.Marca));
                cmd.Parameters.Add(new SqlParameter("@modelo", pCamion.Modelo));
                cmd.Parameters.Add(new SqlParameter("@year", pCamion.Year));

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

        public static bool ModificarCamion(Common.Clases.Camion pCamion)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Camion_Modificar", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@matricula", pCamion.Matricula));
                cmd.Parameters.Add(new SqlParameter("@marca", pCamion.Marca));
                cmd.Parameters.Add(new SqlParameter("@modelo", pCamion.Modelo));
                cmd.Parameters.Add(new SqlParameter("@year", pCamion.Year));

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

        public static bool BajaCamion(Common.Clases.Camion pCamion)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Camion_Eliminar", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@matricula", pCamion.Matricula));

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

        public static List<Common.Clases.Camion> ListarCamiones()
        {
            List<Common.Clases.Camion> ListaCamiones = new List<Common.Clases.Camion>();
            Common.Clases.Camion cam;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Camion_TraerTodos", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // ejecutamos el store desde c#
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {

                    while (oReader.Read())
                    {
                        cam = new Common.Clases.Camion();
                        cam.Matricula = oReader["matriculaCamion"].ToString();
                        cam.Marca = oReader["marcaCamion"].ToString();
                        cam.Modelo = oReader["modeloCamion"].ToString();
                        cam.Year = short.Parse(oReader["yearCamion"].ToString());
                        ListaCamiones.Add(cam);
                    }

                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ListaCamiones;
        }

        public static Common.Clases.Camion TraerCamion(Common.Clases.Camion pCamion)
        {
            Common.Clases.Camion camion = null;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Camion_TraerEspecifico", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@matricula", pCamion.Matricula));

                // ejecutamos el store desde c#
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {

                    while (oReader.Read())
                    {
                        camion = new Common.Clases.Camion();
                        camion.Matricula = oReader["matriculaCamion"].ToString();
                        camion.Marca = oReader["marcaCamion"].ToString();
                        camion.Modelo = oReader["modeloCamion"].ToString();
                        camion.Year = short.Parse(oReader["yearCamion"].ToString());

                    }

                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return camion;
        }
    }
}
