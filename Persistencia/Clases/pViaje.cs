using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Persistencia.Clases
{
    public class pViaje : Persistencia
    {
        public static bool AgregarViaje(Common.Clases.Viaje pVia)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Viajes_Agregar", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@idViaje", pVia.idViaje));
                //cmd.Parameters.Add(new SqlParameter("@CedulaCam", pVia.CedulaCam));
                //cmd.Parameters.Add(new SqlParameter("@Matricula", pVia.Matricula));
                cmd.Parameters.Add(new SqlParameter("@Kilos", pVia.Kilos));
                cmd.Parameters.Add(new SqlParameter("@TipoCarga", pVia.TipoCarga));
                cmd.Parameters.Add(new SqlParameter("@Origen", pVia.Origen));
                cmd.Parameters.Add(new SqlParameter("@Destino", pVia.Destino));
                cmd.Parameters.Add(new SqlParameter("@FechaIni", pVia.FechaIni));
                cmd.Parameters.Add(new SqlParameter("@FechaFin", pVia.FechaFin));
                //cmd.Parameters.Add(new SqlParameter("@idCategoria", pCli.Categoria.Identificador));

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
         public static Common.Clases.Viaje TraerEspecifico(Common.Clases.Viaje pViaje)
         {
             Common.Clases.Viaje via = null;

             try
             {
                 var conn = new SqlConnection(CadenaDeConexion);
                 conn.Open();

                 SqlCommand cmd = new SqlCommand("Viajes_TraerEspecifico", conn);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add(new SqlParameter("@idViaje", pViaje.idViaje));

                 using (SqlDataReader oReader = cmd.ExecuteReader())
                 {
                     while (oReader.Read())
                     {
                         via = new Common.Clases.Viaje();

                        via.idViaje = int.Parse(oReader["idViaje"].ToString());
                        via.CedulaCam = int.Parse(oReader["CedulaCam"].ToString());
                        via.Matricula = oReader["Matricula"].ToString();
                        via.TipoCarga = oReader["TipoCarga"].ToString();
                        via.Origen = oReader["Origen"].ToString();
                        via.Destino = oReader["Destino"].ToString();
                        via.FechaIni =DateTime.Parse(oReader["FechaIni"].ToString());
                        via.FechaFin = DateTime.Parse(oReader["FechaFin"].ToString());
                    }
                     conn.Close();
                 }

             }
             catch (Exception ex)
             {
                 throw ex;
             }

             return via;

         }




         public static List<Common.Clases.Viaje> TraerTodosLosViajes()
         {
             List<Common.Clases.Viaje> retorno = new List<Common.Clases.Viaje>();
             Common.Clases.Viaje via;

             try
             {
                 var conn = new SqlConnection(CadenaDeConexion);
                 conn.Open();

                 // 1. identificamos el store procedure a ejecutar
                 SqlCommand cmd = new SqlCommand("Viajes_TraerTodos", conn);

                 // 2. identificamos el tipo de ejecución, en este caso un SP
                 cmd.CommandType = CommandType.StoredProcedure;

                 // ejecutamos el store desde c#
                 using (SqlDataReader oReader = cmd.ExecuteReader())
                 {

                     while (oReader.Read())
                     {
                         via = new Common.Clases.Viaje();

                        via.idViaje = int.Parse(oReader["idViaje"].ToString());
                        via.CedulaCam = int.Parse(oReader["CedulaCam"].ToString());
                        via.Matricula = oReader["Matricula"].ToString();
                        via.TipoCarga = oReader["TipoCarga"].ToString();
                        via.Origen = oReader["Origen"].ToString();
                        via.Destino = oReader["Destino"].ToString();
                        via.FechaIni = DateTime.Parse(oReader["FechaIni"].ToString());
                        via.FechaFin = DateTime.Parse(oReader["FechaFin"].ToString());

                        retorno.Add(via);

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

        public static bool ModificarViaje(Common.Clases.Viaje pVia)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Viajes_Modificar", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@idViaje", pVia.idViaje));
               // cmd.Parameters.Add(new SqlParameter("@CedulaCam", pVia.CedulaCam));
               // cmd.Parameters.Add(new SqlParameter("@Matricula", pVia.Matricula));
                cmd.Parameters.Add(new SqlParameter("@Kilos", pVia.Kilos));
                cmd.Parameters.Add(new SqlParameter("@TipoCarga", pVia.TipoCarga));
                cmd.Parameters.Add(new SqlParameter("@Origen", pVia.Origen));
                cmd.Parameters.Add(new SqlParameter("@Destino", pVia.Destino));
                cmd.Parameters.Add(new SqlParameter("@FechaIni", pVia.FechaIni));
                cmd.Parameters.Add(new SqlParameter("@FechaFin", pVia.FechaFin));

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
        public static bool EliminarViaje(Common.Clases.Viaje pVia)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Viajes_Eliminar", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del S

                cmd.Parameters.Add(new SqlParameter("@idViaje", pVia.idViaje));

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





