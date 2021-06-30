using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace Persistencia.Clases
{
    public class pViaje:Persistencia
    {
        public static bool AgregarViaje(Common.Clases.Viaje pVia)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Agregar_Viaje", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idCamionero",pVia.Camionero.identificadorCam));
                cmd.Parameters.Add(new SqlParameter("@idCamion",pVia.Camion.idCamion));
                cmd.Parameters.Add(new SqlParameter("@TipoCargaViaje",pVia.Tipo_Carga));
                cmd.Parameters.Add(new SqlParameter("@KilajeViaje",pVia.Kilaje));
                cmd.Parameters.Add(new SqlParameter("@OrigenViaje",pVia.Origen));
                cmd.Parameters.Add(new SqlParameter("@DestinoViaje",pVia.Destino));
                cmd.Parameters.Add(new SqlParameter("@FechaInicioViaje",pVia.Fecha_Inicio));
                cmd.Parameters.Add(new SqlParameter("@FechaFinalizacionViaje",pVia.Fecha_Finalizacion));
                cmd.Parameters.Add(new SqlParameter("@estadoViaje",pVia.EstadoViaje));

                int rtn = cmd.ExecuteNonQuery();

                if(rtn <= 0)
                {
                    retorno = false;
                }

                if(conn.State == ConnectionState.Open)
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




        public static bool ModificarViaje(Common.Clases.Viaje pVia)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Modificar_Viaje", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idViaje", pVia.identificadorViaje));
                cmd.Parameters.Add(new SqlParameter("@idCamionero", pVia.Camionero.identificadorCam));
                cmd.Parameters.Add(new SqlParameter("@idCamion", pVia.Camion.idCamion));
                cmd.Parameters.Add(new SqlParameter("@TipoCargaViaje", pVia.Tipo_Carga));
                cmd.Parameters.Add(new SqlParameter("@KilajeViaje", pVia.Kilaje));
                cmd.Parameters.Add(new SqlParameter("@OrigenViaje", pVia.Origen));
                cmd.Parameters.Add(new SqlParameter("@DestinoViaje", pVia.Destino));
                cmd.Parameters.Add(new SqlParameter("@FechaInicioViaje", pVia.Fecha_Inicio));
                cmd.Parameters.Add(new SqlParameter("@FechaFinalizacionViaje", pVia.Fecha_Finalizacion));
                cmd.Parameters.Add(new SqlParameter("@estadoViaje", pVia.EstadoViaje));

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


        public static bool EliminarViaje(Common.Clases.Viaje pVia)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Eliminar_Viaje", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idViaje", pVia.identificadorViaje));

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

        public static List<Common.Clases.Viaje> TraerTodosLosViajes()
        {
            List<Common.Clases.Viaje> retornarVia = new List<Common.Clases.Viaje>();
            Common.Clases.Viaje viaje;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);

                SqlCommand cmd = new SqlCommand("TraerTodosLosViajes", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        viaje = new Common.Clases.Viaje();
                        viaje.identificadorViaje = int.Parse(oReader["idViaje"].ToString());
                        viaje.Camionero.identificadorCam = int.Parse(oReader["idCamionero"].ToString());
                        viaje.Camion.idCamion = int.Parse(oReader["idCamion"].ToString());
                        viaje.Tipo_Carga = oReader["TipoCargaViaje"].ToString();
                        viaje.Kilaje = int.Parse (oReader["KilajeViaje"].ToString());
                        viaje.Origen = oReader["OrigenViaje"].ToString();
                        viaje.Destino = oReader["DestinoViaje"].ToString();
                        viaje.Fecha_Inicio = DateTime.Parse(oReader["FechaInicioViaje"].ToString());
                        viaje.Fecha_Finalizacion = DateTime.Parse(oReader["FechaFinalizacionViaje"].ToString());
                        viaje.EstadoViaje = oReader["estadoViaje"].ToString();
                        retornarVia.Add(viaje);
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retornarVia;
        }

        public static Common.Clases.Viaje TraerUnViajeEnEspecifico(Common.Clases.Viaje pVia)
        {

            Common.Clases.Viaje viaje = null; 

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);

                SqlCommand cmd = new SqlCommand("TraerUnViajeEnEspecifico", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idViaje", pVia.identificadorViaje));

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        viaje = new Common.Clases.Viaje();
                        viaje.identificadorViaje = int.Parse(oReader["idViaje"].ToString());
                        viaje.Camionero.identificadorCam = int.Parse(oReader["idCamionero"].ToString());
                        viaje.Camion.idCamion = int.Parse(oReader["idCamion"].ToString());
                        viaje.Tipo_Carga = oReader["TipoCargaViaje"].ToString();
                        viaje.Kilaje = int.Parse(oReader["KilajeViaje"].ToString());
                        viaje.Origen = oReader["OrigenViaje"].ToString();
                        viaje.Destino = oReader["DestinoViaje"].ToString();
                        viaje.Fecha_Inicio = DateTime.Parse(oReader["FechaInicioViaje"].ToString());
                        viaje.Fecha_Finalizacion = DateTime.Parse(oReader["FechaFinalizacionViaje"].ToString());
                        viaje.EstadoViaje = oReader["estadoViaje"].ToString();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return viaje;
        }
    }
}
