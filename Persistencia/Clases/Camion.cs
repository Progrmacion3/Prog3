using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Clases;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia.Clases
{
    public class Camion : Persistencia
    {
        public static bool AgregarCamion(Common.Clases.Camion pCamion)
        {
            bool retorno = true;

            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("AgregarCamion", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@matricula", pCamion.Matricula));
                cmd.Parameters.Add(new SqlParameter("@marca", pCamion.Marca));
                cmd.Parameters.Add(new SqlParameter("@modelo", pCamion.Modelo));
                cmd.Parameters.Add(new SqlParameter("@año", pCamion.Año));

                int rtn = cmd.ExecuteNonQuery();
                if(rtn <= 0)
                {
                    retorno = false;
                }
                
                if(conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch(Exception ex)
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
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("EliminarCamion", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@matricula", pCamion.Matricula));
                

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

        public static bool ModificarCamion(Common.Clases.Camion pCamion)
        {
            bool retorno = true;

            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("ModificarCamion", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@matricula", pCamion.Matricula));
                cmd.Parameters.Add(new SqlParameter("@marca", pCamion.Marca));
                cmd.Parameters.Add(new SqlParameter("@modelo", pCamion.Modelo));
                cmd.Parameters.Add(new SqlParameter("@año", pCamion.Año));

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
        public static List<Common.Clases.Camion> MostrarCamiones()
        {
            List<Common.Clases.Camion> retorno = new List<Common.Clases.Camion>();
            Common.Clases.Camion camion;

            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("mostrarCamiones", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        camion = new Common.Clases.Camion();
                        camion.IdCamion = int.Parse(oReader["IdCamion"].ToString());
                        camion.Matricula = oReader["Matricula"].ToString();
                        camion.Marca = oReader["Marca"].ToString();
                        camion.Modelo = oReader["Modelo"].ToString();
                        camion.Año = int.Parse(oReader["Año"].ToString());

                        retorno.Add(camion);
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
        public static Common.Clases.Camion MostrarCamionEspecifico(Common.Clases.Camion pCamion)
        {
            Common.Clases.Camion retorno = null;
            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("mostrarCamionEspecifico", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@matricula", pCamion.Matricula));

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        retorno = new Common.Clases.Camion();
                        retorno.Matricula = oReader["Matricula"].ToString();
                        retorno.Marca = oReader["Marca"].ToString();
                        retorno.Modelo = oReader["Modelo"].ToString();
                        retorno.Año = int.Parse(oReader["Año"].ToString());

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
        public static Common.Clases.Camion MostrarCamionEspecifico2(Common.Clases.Camion pCamion)
        {
            Common.Clases.Camion retorno = null;
            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("mostrarCamionEspecifico2", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idCamion", pCamion.IdCamion));

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        retorno = new Common.Clases.Camion();
                        retorno.IdCamion = int.Parse(oReader["IdCamion"].ToString());
                        

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
