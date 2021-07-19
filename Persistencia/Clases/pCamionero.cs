using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Persistencia.Clases
{
    public class pCamionero:Persistencia
    {

        public static bool AgregarCamionero(Common.Clases.Camionero pCamio)
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
                cmd.Parameters.Add(new SqlParameter("@Cedula", pCamio.Cedula));
                cmd.Parameters.Add(new SqlParameter("@Nombre", pCamio.Nombre));
                cmd.Parameters.Add(new SqlParameter("@Apellido", pCamio.Apellido));
               cmd.Parameters.Add(new SqlParameter("@Telefono", pCamio.Telefono));
                cmd.Parameters.Add(new SqlParameter("@Tipo", pCamio.Tipo));
                cmd.Parameters.Add(new SqlParameter("@Usuario", pCamio.Usuario));
               cmd.Parameters.Add(new SqlParameter("@Contrasenia", pCamio.Contrasenia));
                cmd.Parameters.Add(new SqlParameter("@Estado", pCamio.Estado));
                cmd.Parameters.Add(new SqlParameter("@Edad", pCamio.Edad));
                cmd.Parameters.Add(new SqlParameter("@TipoLibreta", pCamio.TipoLibreta));
                cmd.Parameters.Add(new SqlParameter("@FechaVencLib", pCamio.FechaVenLib));

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
        public static Common.Clases.Camionero TraerEspecifico(Common.Clases.Camionero pCamionero)
        {
            Common.Clases.Camionero cam = null;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Camionero_TraerEspecifico", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Cedula", pCamionero.Cedula));

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        cam = new Common.Clases.Camionero();

                        cam.Cedula = int.Parse(oReader["Cedula"].ToString());
                        cam.TipoLibreta = oReader["TipoLibreta"].ToString();
                        cam.Edad = int.Parse(oReader["Edad"].ToString());
                        cam.FechaVenLib =DateTime.Parse(oReader["FechaVenLib"].ToString());

                        cam.Nombre= oReader["Nombre"].ToString();
                        cam.Apellido = oReader["Apellido"].ToString();
                        cam.Cargo = oReader["Cargo"].ToString();
                        cam.Tipo= oReader["Tipo"].ToString();
                        cam.Telefono = oReader["Telefono"].ToString();
                        cam.Usuario= oReader["Usuario"].ToString();
                        cam.Contrasenia = oReader["Contrasenia"].ToString();
                        cam.Estado= int.Parse(oReader["Estado"].ToString());
                       
                    }
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return cam;

        }




          public static List<Common.Clases.Camionero> TraerTodosLosCamioneros()
          {
              List<Common.Clases.Camionero> retorno = new List<Common.Clases.Camionero>();
            Common.Clases.Camionero cam = null;

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
                        cam.Cedula = int.Parse(oReader["Cedula"].ToString());
                        cam.TipoLibreta = oReader["TipoLibreta"].ToString();
                        cam.Edad = int.Parse(oReader["Edad"].ToString());
                        cam.FechaVenLib =DateTime.Parse(oReader["FechaVenLib"].ToString());

                        cam.Nombre= oReader["Nombre"].ToString();
                        cam.Apellido = oReader["Apellido"].ToString();
                        cam.Cargo = oReader["Cargo"].ToString();
                        cam.Tipo= oReader["Tipo"].ToString();
                        cam.Telefono = oReader["Telefono"].ToString();
                        cam.Usuario= oReader["Usuario"].ToString();
                        cam.Contrasenia = oReader["Contrasenia"].ToString();
                        cam.Estado= int.Parse(oReader["Estado"].ToString());

                          retorno.Add(cam);


                      }

                      conn.Close();
                  }

              }
              catch (Exception ex)
              {
                  throw ex;
              }

              return retorno;
          }
        public static bool ModificarEmpleado(Common.Clases.Camionero pCamio)
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
                cmd.Parameters.Add(new SqlParameter("@Cedula", pCamio.Cedula));
                cmd.Parameters.Add(new SqlParameter("@Nombre", pCamio.Nombre));
                cmd.Parameters.Add(new SqlParameter("@Apellido", pCamio.Apellido));
                cmd.Parameters.Add(new SqlParameter("@Telefono", pCamio.Telefono));
                cmd.Parameters.Add(new SqlParameter("@Tipo", pCamio.Telefono));
                cmd.Parameters.Add(new SqlParameter("@Usuario", pCamio.Usuario));
                cmd.Parameters.Add(new SqlParameter("@Contrasenia", pCamio.Contrasenia));
                cmd.Parameters.Add(new SqlParameter("@Estado", pCamio.Estado));
                cmd.Parameters.Add(new SqlParameter("@Edad", pCamio.Edad));
                cmd.Parameters.Add(new SqlParameter("@TipoLibreta", pCamio.TipoLibreta));
                cmd.Parameters.Add(new SqlParameter("@FechaVencLib", pCamio.FechaVenLib));

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
        public static bool EliminarCamionero(Common.Clases.Camionero pCamio)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Camionero_Eliminar", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del S
                cmd.Parameters.Add(new SqlParameter("@Estado", pCamio.Estado));
                cmd.Parameters.Add(new SqlParameter("@Cedula", pCamio.Cedula));

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


    }


}

