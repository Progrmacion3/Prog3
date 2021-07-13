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

                cmd.Parameters.Add(new SqlParameter("@idCamion", pCamion.idCamion));
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

                cmd.Parameters.Add(new SqlParameter("@idCamion", pCamion.idCamion));

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

        public static List<Common.Clases.Camion> TraerTodosLosCamiones()
        {
            List<Common.Clases.Camion> retornarCamion = new List<Common.Clases.Camion>();
            Common.Clases.Camion camion;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("TraerTodosLosCamiones", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    
                    while (oReader.Read())
                    {
                        camion = new Common.Clases.Camion();
                        camion.idCamion = int.Parse(oReader["idCamion"].ToString());
                        camion.Matricula = oReader["matriculaCamion"].ToString();
                        camion.Modelo = oReader["modeloCamion"].ToString();
                        camion.Marca = oReader["marcaCamion"].ToString();
                        camion.Año = int.Parse(oReader["añoCamion"].ToString());
                        retornarCamion.Add(camion);
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retornarCamion;
        }

        public static Common.Clases.Camion TraerUnCamionEnEspecifico(Common.Clases.Camion pCamion)
        {
           
            Common.Clases.Camion camion=null;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("TraerUnCamionEnEspecifico", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idCamion", pCamion.idCamion));

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        camion = new Common.Clases.Camion();
                        camion.idCamion = int.Parse(oReader["idCamion"].ToString());
                        camion.Matricula = oReader["matriculaCamion"].ToString();
                        camion.Modelo = oReader["modeloCamion"].ToString();
                        camion.Marca = oReader["marcaCamion"].ToString();
                        camion.Año = int.Parse(oReader["añoCamion"].ToString());
                       
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