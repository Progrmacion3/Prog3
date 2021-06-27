using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using obligatorio.Dominio;


namespace obligatorio.Persistencia.Clases
{
    public class pViaje : Persistencia
    {
        public static bool AgregarViaje(Viaje pViaje)
        {
            bool retorno = true;
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Viaje_Agregar", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@tipoCarga", pViaje.Carga));
                cmd.Parameters.Add(new SqlParameter("@kilaje", pViaje.Kilaje));
                cmd.Parameters.Add(new SqlParameter("@origenViaje", pViaje.Origen));
                cmd.Parameters.Add(new SqlParameter("@destinoViaje", pViaje.Destino));
                cmd.Parameters.Add(new SqlParameter("@fechaInicio", pViaje.FechaInicio));
                cmd.Parameters.Add(new SqlParameter("@fechaFin", pViaje.FechaFin));
                cmd.Parameters.Add(new SqlParameter("@estado", pViaje.Estado));
                cmd.Parameters.Add(new SqlParameter("@idCamionero", pViaje.Camionero));
                cmd.Parameters.Add(new SqlParameter("@idCamion", pViaje.Camion));


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

        public static bool EliminarViaje(Viaje pViaje)
        {
            bool retorno = true;
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Viaje_Eliminar", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idViaje", pViaje.Id));

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

        public static bool ModificarViaje(Viaje pViaje)
        {
            bool retorno = true;
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Viaje_Modificar", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idViaje", pViaje.Id));
                cmd.Parameters.Add(new SqlParameter("@tipoCarga", pViaje.Carga));
                cmd.Parameters.Add(new SqlParameter("@kilaje", pViaje.Kilaje));
                cmd.Parameters.Add(new SqlParameter("@origenViaje", pViaje.Origen));
                cmd.Parameters.Add(new SqlParameter("@destinoViaje", pViaje.Destino));
                cmd.Parameters.Add(new SqlParameter("@fechaInicio", pViaje.FechaInicio));
                cmd.Parameters.Add(new SqlParameter("@fechaFin", pViaje.FechaFin));
                cmd.Parameters.Add(new SqlParameter("@estado", pViaje.Estado));
                cmd.Parameters.Add(new SqlParameter("@idCamionero", pViaje.Camionero));
                cmd.Parameters.Add(new SqlParameter("@idCamion", pViaje.Camion));


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