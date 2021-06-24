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
                cmd.Parameters.Add(new SqlParameter("@matriculaC", pCamion.Matricula));
                cmd.Parameters.Add(new SqlParameter("@marcaC", pCamion.Marca));
                cmd.Parameters.Add(new SqlParameter("@modeloC", pCamion.Modelo));
                cmd.Parameters.Add(new SqlParameter("@yearC", pCamion.Year));

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
                cmd.Parameters.Add(new SqlParameter("@matriculaC", pCamion.Matricula));
                cmd.Parameters.Add(new SqlParameter("@marcaC", pCamion.Marca));
                cmd.Parameters.Add(new SqlParameter("@modeloC", pCamion.Modelo));
                cmd.Parameters.Add(new SqlParameter("@yearC", pCamion.Year));

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
                cmd.Parameters.Add(new SqlParameter("@matriculaC", pCamion.Matricula));

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
                        cam.Matricula = oReader["matriculaC"].ToString();
                        cam.Marca = oReader["marcaC"].ToString();
                        cam.Modelo = oReader["modeloC"].ToString();
                        cam.Year = short.Parse(oReader["yearC"].ToString());
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
                        camion.Matricula = oReader["matriculaC"].ToString();
                        camion.Marca = oReader["marcaC"].ToString();
                        camion.Modelo = oReader["modeloC"].ToString();
                        camion.Year = short.Parse(oReader["yearC"].ToString());

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
