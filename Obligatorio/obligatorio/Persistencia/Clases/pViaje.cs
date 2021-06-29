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
                cmd.Parameters.Add(new SqlParameter("@kilajeViaje", pViaje.Kilaje));
                cmd.Parameters.Add(new SqlParameter("@origenViaje", pViaje.Origen));
                cmd.Parameters.Add(new SqlParameter("@destinoViaje", pViaje.Destino));
                cmd.Parameters.Add(new SqlParameter("@fechaInicio", pViaje.FechaInicio));
                cmd.Parameters.Add(new SqlParameter("@fechaFin", pViaje.FechaFin));
                cmd.Parameters.Add(new SqlParameter("@estado", pViaje.Estado));
                cmd.Parameters.Add(new SqlParameter("@idCamionero", pViaje.Camionero.Id));
                cmd.Parameters.Add(new SqlParameter("@matriculaCamion", pViaje.Camion.Matricula));


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
                cmd.Parameters.Add(new SqlParameter("@kilajeViaje", pViaje.Kilaje));
                cmd.Parameters.Add(new SqlParameter("@origenViaje", pViaje.Origen));
                cmd.Parameters.Add(new SqlParameter("@destinoViaje", pViaje.Destino));
                cmd.Parameters.Add(new SqlParameter("@fechaInicio", pViaje.FechaInicio));
                cmd.Parameters.Add(new SqlParameter("@fechaFin", pViaje.FechaFin));
                cmd.Parameters.Add(new SqlParameter("@estado", "propuesto"));
                cmd.Parameters.Add(new SqlParameter("@idCamionero", pViaje.Camionero.Id));
                cmd.Parameters.Add(new SqlParameter("@matriculaCamion", pViaje.Camion.Matricula));


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

        public static List<Viaje> pListaViajes()
        {
            List<Viaje> listaViajes = new List<Viaje>();
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Viaje_TraerTodos", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Viaje viaje = new Viaje();
                        viaje.Id = int.Parse(oReader["idViaje"].ToString());
                        viaje.Carga = oReader["tipoCarga"].ToString();
                        viaje.Kilaje = float.Parse(oReader["kilajeViaje"].ToString());
                        viaje.Origen = oReader["origenViaje"].ToString();
                        viaje.Destino = oReader["destinoViaje"].ToString();
                        viaje.FechaInicio = DateTime.Parse(oReader["fechaInicio"].ToString());
                        viaje.FechaFin = DateTime.Parse(oReader["fechaFin"].ToString());
                        viaje.Estado = oReader["estado"].ToString();
                        viaje.Camionero = new Empresa().BuscarCamionero(new Camionero(int.Parse(oReader["idCamionero"].ToString())));
                        viaje.Camion = new Empresa().BuscarCamion(new Camion(oReader["idCamion"].ToString()));
                        listaViajes.Add(viaje);
                    }
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listaViajes;
        }
    }
}