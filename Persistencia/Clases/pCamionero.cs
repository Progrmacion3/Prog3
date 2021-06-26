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

                    cmd.Parameters.Add(new SqlParameter("@idViaje", pCamionero.identificadorCam));

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

