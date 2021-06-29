using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Clases;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia.Clases
{
    public class Viaje : Persistencia
    {
        public static bool AgregarViaje(Common.Clases.Viaje pViaje)
        {
            bool retorno = true;

            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("AgregarViaje", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idCamionero", pViaje.IdCamionero));
                cmd.Parameters.Add(new SqlParameter("@idCamion", pViaje.IdCamion));
                cmd.Parameters.Add(new SqlParameter("@tipoCarga", pViaje.TipoCarga));
                cmd.Parameters.Add(new SqlParameter("@kilaje", pViaje.Kilaje));
                cmd.Parameters.Add(new SqlParameter("@origen", pViaje.Origen));
                cmd.Parameters.Add(new SqlParameter("@destino", pViaje.Destino));
                cmd.Parameters.Add(new SqlParameter("@fechaInicio", pViaje.FechaInicio));
                cmd.Parameters.Add(new SqlParameter("@fechaFinal", pViaje.FechaFinal));
                cmd.Parameters.Add(new SqlParameter("@estado", pViaje.Estado));

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

        public static bool EliminarViaje(Common.Clases.Viaje pViaje)
        {
            bool retorno = true;

            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("EliminarViaje", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idViaje", pViaje.IdViaje));


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

        public static bool ModificarViaje(Common.Clases.Viaje pViaje)
        {
            bool retorno = true;

            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("ModificarViaje", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idViaje", pViaje.IdViaje));
                cmd.Parameters.Add(new SqlParameter("@idCamionero", pViaje.IdCamionero));
                cmd.Parameters.Add(new SqlParameter("@idCamion", pViaje.IdCamion));
                cmd.Parameters.Add(new SqlParameter("@tipoCarga", pViaje.TipoCarga));
                cmd.Parameters.Add(new SqlParameter("@kilaje", pViaje.Kilaje));
                cmd.Parameters.Add(new SqlParameter("@origen", pViaje.Origen));
                cmd.Parameters.Add(new SqlParameter("@destino", pViaje.Destino));
                cmd.Parameters.Add(new SqlParameter("@fechaInicio", pViaje.FechaInicio));
                cmd.Parameters.Add(new SqlParameter("@fechaFinal", pViaje.FechaFinal));
                cmd.Parameters.Add(new SqlParameter("@estado", pViaje.Estado));

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
        public static bool ModificarViajeCamionero(Common.Clases.Viaje pViaje)
        {
            bool retorno = true;

            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("ModificarViajeCamionero", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idViaje", pViaje.IdViaje));
                cmd.Parameters.Add(new SqlParameter("@kilaje", pViaje.Kilaje));
                cmd.Parameters.Add(new SqlParameter("@estado", pViaje.Estado));

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
        public static List<Common.Clases.Viaje> MostrarViajes()
        {
            List<Common.Clases.Viaje> retorno = new List<Common.Clases.Viaje>();
            Common.Clases.Viaje viaje;

            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("mostrarViajes", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        viaje = new Common.Clases.Viaje();
                        viaje.IdViaje = int.Parse(oReader["IdViaje"].ToString());
                        viaje.IdCamionero = int.Parse(oReader["IdCamionero"].ToString());
                        viaje.IdCamion = int.Parse(oReader["IdCamion"].ToString());
                        viaje.TipoCarga = oReader["TipoCarga"].ToString();
                        viaje.Kilaje = int.Parse(oReader["Kilaje"].ToString());
                        viaje.Origen = oReader["Origen"].ToString();
                        viaje.Destino = oReader["Destino"].ToString();
                        viaje.FechaInicio = Convert.ToDateTime(oReader["FechaInicio"].ToString());
                        viaje.FechaFinal = Convert.ToDateTime(oReader["FechaFinal"].ToString());
                        viaje.Estado = oReader["Estado"].ToString();

                        retorno.Add(viaje);
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
        public static List<Common.Clases.Viaje> MostrarViajesMesActual()
        {
            List<Common.Clases.Viaje> retorno = new List<Common.Clases.Viaje>();
            Common.Clases.Viaje viaje;

            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("mostrarViajesMesActual", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        viaje = new Common.Clases.Viaje();
                        viaje.IdViaje = int.Parse(oReader["IdViaje"].ToString());
                        viaje.IdCamionero = int.Parse(oReader["IdCamionero"].ToString());
                        viaje.IdCamion = int.Parse(oReader["IdCamion"].ToString());
                        viaje.TipoCarga = oReader["TipoCarga"].ToString();
                        viaje.Kilaje = int.Parse(oReader["Kilaje"].ToString());
                        viaje.Origen = oReader["Origen"].ToString();
                        viaje.Destino = oReader["Destino"].ToString();
                        viaje.FechaInicio = Convert.ToDateTime(oReader["FechaInicio"].ToString());
                        viaje.FechaFinal = Convert.ToDateTime(oReader["FechaFinal"].ToString());
                        viaje.Estado = oReader["Estado"].ToString();

                        retorno.Add(viaje);
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
        public static List<Common.Clases.Viaje> MostrarViajesPorCamionero(int pCedula)
        {
            List<Common.Clases.Viaje> retorno = new List<Common.Clases.Viaje>();
            Common.Clases.Viaje viaje;

            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("mostrarViajesPorCamionero", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@cedula", pCedula));

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        viaje = new Common.Clases.Viaje();
                        viaje.IdViaje = int.Parse(oReader["IdViaje"].ToString());
                        viaje.IdCamionero = int.Parse(oReader["IdCamionero"].ToString());
                        viaje.IdCamion = int.Parse(oReader["IdCamion"].ToString());
                        viaje.TipoCarga = oReader["TipoCarga"].ToString();
                        viaje.Kilaje = int.Parse(oReader["Kilaje"].ToString());
                        viaje.Origen = oReader["Origen"].ToString();
                        viaje.Destino = oReader["Destino"].ToString();
                        viaje.FechaInicio = Convert.ToDateTime(oReader["FechaInicio"].ToString());
                        viaje.FechaFinal = Convert.ToDateTime(oReader["FechaFinal"].ToString());
                        viaje.Estado = oReader["Estado"].ToString();

                        retorno.Add(viaje);
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
        public static Common.Clases.Viaje MostrarViajeEspecifico(Common.Clases.Viaje pViaje)
        {
            Common.Clases.Viaje retorno = null;
            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("mostrarViajeEspecifico", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idViaje", pViaje.IdViaje));

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        retorno = new Common.Clases.Viaje();
                        retorno.IdViaje = int.Parse(oReader["IdViaje"].ToString());
                        retorno.IdCamionero = int.Parse(oReader["IdCamionero"].ToString());
                        retorno.IdCamion = int.Parse(oReader["IdCamion"].ToString());
                        retorno.TipoCarga = oReader["TipoCarga"].ToString();
                        retorno.Kilaje = int.Parse(oReader["Kilaje"].ToString());
                        retorno.Origen = oReader["Origen"].ToString();
                        retorno.Destino = oReader["Destino"].ToString();
                        retorno.FechaInicio = Convert.ToDateTime(oReader["FechaInicio"].ToString());
                        retorno.FechaFinal = Convert.ToDateTime(oReader["FechaFinal"].ToString());
                        retorno.Estado = oReader["Estado"].ToString();
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
