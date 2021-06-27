using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Persistencia.Clases
{
   public class pCamionero : Persistencia
    {
        public static bool AltaCamionero(Common.Clases.Camionero pCamionero)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Camionero_Agregar", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@ci", pCamionero.CI));
                cmd.Parameters.Add(new SqlParameter("@nombre", pCamionero.Nombre));
                cmd.Parameters.Add(new SqlParameter("@apellido", pCamionero.Apellido));
                cmd.Parameters.Add(new SqlParameter("@cargo", pCamionero.Cargo));
                cmd.Parameters.Add(new SqlParameter("@telefono", pCamionero.Telefono));
                cmd.Parameters.Add(new SqlParameter("@tipo", pCamionero.Tipo));
                cmd.Parameters.Add(new SqlParameter("@usuario", pCamionero.Usuario));
                cmd.Parameters.Add(new SqlParameter("@password", pCamionero.Password));
                cmd.Parameters.Add(new SqlParameter("@edad", pCamionero.Edad));
                cmd.Parameters.Add(new SqlParameter("@tipoLibretaCamionero", pCamionero.Tipo_Libreta));
                cmd.Parameters.Add(new SqlParameter("@fechaVencimientoLibreta", pCamionero.FechaVencimientoLibreta));

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
        public static bool ModificarCamionero(Common.Clases.Camionero pCamionero)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Camionero_Modificar", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@ci", pCamionero.CI));
                cmd.Parameters.Add(new SqlParameter("@nombre", pCamionero.Nombre));
                cmd.Parameters.Add(new SqlParameter("@apellido", pCamionero.Apellido));
                cmd.Parameters.Add(new SqlParameter("@cargo", pCamionero.Cargo));
                cmd.Parameters.Add(new SqlParameter("@telefono", pCamionero.Telefono));
                cmd.Parameters.Add(new SqlParameter("@tipo", pCamionero.Tipo));
                cmd.Parameters.Add(new SqlParameter("@usuario", pCamionero.Usuario));
                cmd.Parameters.Add(new SqlParameter("@password", pCamionero.Password));
                cmd.Parameters.Add(new SqlParameter("@edad", pCamionero.Edad));
                cmd.Parameters.Add(new SqlParameter("@tipoLibretaCamionero", pCamionero.Tipo_Libreta));
                cmd.Parameters.Add(new SqlParameter("@fechaVencimientoLibreta", pCamionero.FechaVencimientoLibreta));


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
        public static bool BajaCamionero(Common.Clases.Camionero pCamionero)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Empleado_Eliminar", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@ci", pCamionero.CI));
                cmd.Parameters.Add(new SqlParameter("@estado", pCamionero.Estado));

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
        public static Common.Clases.Camionero TraerCamionero(Common.Clases.Camionero pCamionero)
        {
            Common.Clases.Camionero Camionero = null;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Camionero_TraerEspecifico", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@ci", pCamionero.CI));


                // ejecutamos el store desde c#
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {

                    while (oReader.Read())
                    {
                        Camionero = new Common.Clases.Camionero();
                        Camionero.CI = int.Parse(oReader["ciEmpleado"].ToString());
                        Camionero.Nombre = oReader["nombreEmpleado"].ToString();
                        Camionero.Apellido = oReader["apellidoEmpleado"].ToString();
                        Camionero.Cargo = oReader["cargoEmpleado"].ToString();
                        Camionero.Telefono = oReader["telefonoEmpleado"].ToString();
                        Camionero.Tipo = oReader["tipoEmpleado"].ToString();
                        Camionero.Usuario = oReader["usuarioEmpleado"].ToString();
                        Camionero.Password = oReader["passwordEmpleado"].ToString();
                        Camionero.Edad = short.Parse(oReader["edadCamionero"].ToString());
                        Camionero.Tipo_Libreta = oReader["tipoLibretaCamionero"].ToString();
                        Camionero.FechaVencimientoLibreta = oReader["fechaVenc_LibretaCamionero"].ToString();

                    }

                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Camionero;
        }
        public static List<Common.Clases.Camionero> ListarCamioneros()
        {
            List<Common.Clases.Camionero> ListaCamioneros = new List<Common.Clases.Camionero>();
            Common.Clases.Camionero cam;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Camionero_TraerTodos", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // ejecutamos el store desde c#
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {

                    while (oReader.Read())
                    {
                        cam = new Common.Clases.Camionero();
                        cam.CI = int.Parse(oReader["ciEmpleado"].ToString());
                        cam.Nombre = oReader["nombreEmpleado"].ToString();
                        cam.Apellido = oReader["apellidoEmpleado"].ToString();
                        cam.Cargo = oReader["cargoEmpleado"].ToString();
                        cam.Telefono = oReader["telefonoEmpleado"].ToString();
                        cam.Tipo = oReader["tipoEmpleado"].ToString();
                        cam.Edad = short.Parse(oReader["edadCamionero"].ToString());
                        cam.Tipo_Libreta = oReader["tipoLibretaCamionero"].ToString();
                        cam.FechaVencimientoLibreta = oReader["fechaVenc_LibretaCamionero"].ToString();

                        ListaCamioneros.Add(cam);
                    }

                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ListaCamioneros;
        }
    }
}
