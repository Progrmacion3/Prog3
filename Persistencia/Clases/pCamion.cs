

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace Persistencia.Clases
{
    public class pCamion : Persistencia
    {
        public static bool AgregarCamion(Common.Clases.Camion pCam)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Camion_Agregar", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@Matricula", pCam.Matricula));
                cmd.Parameters.Add(new SqlParameter("@Marca", pCam.Marca));
                cmd.Parameters.Add(new SqlParameter("@Modelo", pCam.Modelo));
                cmd.Parameters.Add(new SqlParameter("@Anio", pCam.Anio));


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
        public static Common.Clases.Camion TraerEspecifico(Common.Clases.Camion pCamion)
        {
            Common.Clases.Camion cam = null;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Camion_TraerEspecifico", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Matricula", pCamion.Matricula));

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        cam = new Common.Clases.Camion();

                        cam.Matricula = oReader["Matricula"].ToString();
                        cam.Marca = oReader["Marca"].ToString();
                        cam.Modelo = oReader["Modelo"].ToString();
                        cam.Anio = DateTime.Parse(oReader["Anio"].ToString());

                       
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




          public static List<Common.Clases.Camion> TraerTodosLosCamiones()
          {
              List<Common.Clases.Camion> retorno = new List<Common.Clases.Camion>();
              Common.Clases.Camion cam;

              try
              {
                  var conn = new SqlConnection(CadenaDeConexion);
                  conn.Open();

                  // 1. identificamos el store procedure a ejecutar
                  SqlCommand cmd = new SqlCommand("Camion_TraerTodos", conn);

                  // 2. identificamos el tipo de ejecución, en este caso un SP
                  cmd.CommandType = CommandType.StoredProcedure;

                  // ejecutamos el store desde c#
                  using (SqlDataReader oReader = cmd.ExecuteReader())
                  {

                      while (oReader.Read())
                      {
                          cam = new Common.Clases.Camion();

                        cam.Matricula = oReader["Matricula"].ToString();
                        cam.Marca = oReader["Marca"].ToString();
                        cam.Modelo = oReader["Modelo"].ToString();
                        cam.Anio = DateTime.Parse(oReader["Anio"].ToString());

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


        public static bool ModificarCamion(Common.Clases.Camion pCam)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Camion_Modificar", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@Matricula", pCam.Matricula));
                cmd.Parameters.Add(new SqlParameter("@Marca", pCam.Marca));
                cmd.Parameters.Add(new SqlParameter("@Modelo", pCam.Modelo));
                cmd.Parameters.Add(new SqlParameter("@Anio", pCam.Anio));


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
        public static bool EliminarCamion(Common.Clases.Camion pCam)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Camion_Eliminar", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del S
                cmd.Parameters.Add(new SqlParameter("@Matricula", pCam.Matricula));

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









