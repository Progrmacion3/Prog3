
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
        /* public static Common.Clases.Cliente TraerEspecifico(Common.Clases.Cliente pCli)
         {
             Common.Clases.Cliente cli = null;

             try
             {
                 var conn = new SqlConnection(CadenaDeConexion);
                 conn.Open();

                 SqlCommand cmd = new SqlCommand("Cliente_TraerEspecifico", conn);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add(new SqlParameter("@Identificador", pCli.Identificador));

                 using (SqlDataReader oReader = cmd.ExecuteReader())
                 {
                     while (oReader.Read())
                     {
                         cli = new Common.Clases.Cliente();

                         cli.Identificador = int.Parse(oReader["IdentificadorCli"].ToString());
                         cli.Nombre = oReader["Nombre"].ToString();
                         cli.Apellido = oReader["Apellido"].ToString();
                         cli.Direccion = oReader["Direccion"].ToString();
                         cli.Categoria = new Common.Clases.Categoria();
                         cli.Categoria.Identificador = int.Parse(oReader["IdCategoria"].ToString());
                         cli.Categoria.Nombre = oReader["cat_nombre"].ToString();
                     }
                     conn.Close();
                 }

             }
             catch (Exception ex)
             {
                 throw ex;
             }

             return cli;

         }




         public static List<Common.Clases.Cliente> TraerTodosLosClientes()
         {
             List<Common.Clases.Cliente> retorno = new List<Common.Clases.Cliente>();
             Common.Clases.Cliente cli;

             try
             {
                 var conn = new SqlConnection(CadenaDeConexion);
                 conn.Open();

                 // 1. identificamos el store procedure a ejecutar
                 SqlCommand cmd = new SqlCommand("Cliente_TraerTodos", conn);

                 // 2. identificamos el tipo de ejecución, en este caso un SP
                 cmd.CommandType = CommandType.StoredProcedure;

                 // ejecutamos el store desde c#
                 using (SqlDataReader oReader = cmd.ExecuteReader())
                 {

                     while (oReader.Read())
                     {
                         cli = new Common.Clases.Cliente();

                         cli.Identificador = int.Parse(oReader["IdentificadorCli"].ToString());

                         cli.Nombre = oReader["Nombre"].ToString();

                         cli.Apellido = oReader["Apellido"].ToString();

                         cli.Direccion = oReader["Direccion"].ToString();

                         cli.Categoria = new Common.Clases.Categoria();
                         cli.Categoria.Identificador = int.Parse(oReader["IdCategoria"].ToString());

                         retorno.Add(cli);


                     }

                     conn.Close();
                 }

             }
             catch (Exception ex)
             {
                 throw ex;
             }

             return retorno;
         }*/

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





