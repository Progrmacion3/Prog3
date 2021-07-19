using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia.Clases
{
    public class pCamionero:Persistencia
    {
            public static bool AgregarCamionero(Common.Clases.Camionero pCamionero)
            {
                bool retorno = true;

                try
                {
                    var conn = new SqlConnection(CadenaDeConexion);
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Agregar_Camionero", conn);

                    cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@EdadCamionero", pCamionero.Edad));
                cmd.Parameters.Add(new SqlParameter("@tipoLibretaCamionero", pCamionero.Tipo_Libreta));
                cmd.Parameters.Add(new SqlParameter("@fechaVencimientoLibreta", pCamionero.Fecha_Vencimiento_Libreta));


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




            public static bool ModificarCamionero(Common.Clases.Camionero pCamionero)
            {
                bool retorno = true;

                try
                {
                    var conn = new SqlConnection(CadenaDeConexion);
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Modificar_Camionero", conn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@idCamionero", pCamionero.identificadorCam));
                    cmd.Parameters.Add(new SqlParameter("@EdadCamionero", pCamionero.Edad));
                    cmd.Parameters.Add(new SqlParameter("@tipoLibretaCamionero", pCamionero.Tipo_Libreta));
                    cmd.Parameters.Add(new SqlParameter("@fechaVencimientoLibreta", pCamionero.Fecha_Vencimiento_Libreta));

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


            public static bool EliminarCamionero(Common.Clases.Camionero pCamionero)
            {
                bool retorno = true;

                try
                {
                    var conn = new SqlConnection(CadenaDeConexion);
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Eliminar_Camionero", conn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@idCamionero", pCamionero.identificadorCam));

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

        public static List<Common.Clases.Camionero> TraerTodosLosCamioneros()
        {
            List<Common.Clases.Camionero> retornarCamionero = new List<Common.Clases.Camionero>();
            Common.Clases.Camionero camionero;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("TraerTodosLosCamioneros", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        camionero = new Common.Clases.Camionero();
                        camionero.identificadorCam = int.Parse(oReader["idCamionero"].ToString());
                        camionero.Edad = int.Parse(oReader["edadCamionero"].ToString());
                        camionero.Tipo_Libreta = oReader["tipoLibretaCamionero"].ToString();
                        camionero.Fecha_Vencimiento_Libreta = DateTime.Parse(oReader["fechaVencimientoLibreta"].ToString());
                        retornarCamionero.Add(camionero);
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retornarCamionero;
        }

        public static Common.Clases.Camionero TraerUnCamioneroEnEspecifico(Common.Clases.Camionero pCamionero)
        {
          
            Common.Clases.Camionero camionero= null;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("TraerUnCamioneroEnEspecifico", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idCamionero", pCamionero.identificadorCam));

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        camionero = new Common.Clases.Camionero();
                        camionero.identificadorCam = int.Parse(oReader["idCamionero"].ToString());
                        camionero.Edad = int.Parse(oReader["edadCamionero"].ToString());
                        camionero.Tipo_Libreta = oReader["tipoLibretaCamionero"].ToString();
                        camionero.Fecha_Vencimiento_Libreta = DateTime.Parse(oReader["fechaVencimientoLibreta"].ToString());
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return camionero;
        }
    }
}

