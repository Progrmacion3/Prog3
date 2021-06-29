using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Common.Clases;

namespace Persistencia.Clases
{
    public class pEstado : Persistencia
    {

        public static bool Agregar(Common.Clases.Estado pEstado)
        {
            bool retorno = true;


            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                //1. Identeificamos el sotre procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Estado_Agregar", conn);

                //2. Identificamos el tipo de ejecucion, en este caso un SP

                cmd.CommandType = CommandType.StoredProcedure;


                //3. En caso de que los lleve se ponen los parametros de SP
                cmd.Parameters.Add(new SqlParameter("@idEstado", pEstado.Identificador));
                cmd.Parameters.Add(new SqlParameter("@Estados", pEstado.Estados));
                cmd.Parameters.Add(new SqlParameter("@Comentario", pEstado.Comentario));


                //Ejecutamos el store desde c#
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

        public static bool AgregarEstado(Estado pEstado)
        {
            throw new NotImplementedException();
        }

        public static bool Modificar(Camion pEstado)
        {
            throw new NotImplementedException();
        }

      

        public static bool Eliminar(Common.Clases.Estado pEstado)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();


                //1. Identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Estado_Eliminar", conn);

                //2. Identificamos el tipo de ejecucion, en este caso SP
                cmd.CommandType = CommandType.StoredProcedure;

                //3. En caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@idEstado", pEstado.Identificador));
                cmd.Parameters.Add(new SqlParameter("@Estados", pEstado.Estados));
                cmd.Parameters.Add(new SqlParameter("@Comentario", pEstado.Comentario));

                // Ejecutamos el store desde C#

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


        public static bool Modificar(Common.Clases.Estado pEstado)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();


                //1. Identificamos el store Procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Estado_Modificar", conn);

                //2. Identificamos el tipo de ejecucion, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                //3 en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@IdEstado", pEstado.Identificador));
                cmd.Parameters.Add(new SqlParameter("@Estados", pEstado.Estados));
                cmd.Parameters.Add(new SqlParameter("@Comentario", pEstado.Comentario));

                //Ejecutamos el store desde c#
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
        
        
        
        
        
        
        
        
        
        
        
        
        
        //public static Common.Clases.Estado TraerEspecifica(Common.Clases.Estado pEstado);
        // {
        //     Common.Clases.Estado retorno = null;

        //try
        //{
        
        //    var conn = new SqlConnection(CadenaDeConexion);
        //    conn.Open();


        //    //1. Identificamos el store porcedure a ejecutar
        //    SqlCommand cmd = new SqlCommand("Estado_TraerEspecifica", conn);
            
        ////2. Identificamos el tipo de ejecucion, en este caso es un SP
        //    cmd.CommandType = CommandType.StoreProcedure;

        //    //3. En caso de que los lleve se ponen los parametros del SP
        //    cmd.Parameters.Add(new SqlParameters("@Identificador", pEstado.Identificador));


        //    //Ejecturamos el sotre desde C#

        //    using(SqlDataReader oReader = cmd.ExecuteReader())
        //    {
        //         while (oReader.Read())
        //            {
        //                retorno = new Common.Clases.Estado();
        //                retorno.Identificador = int.Parse(oReader["Identificador"].ToString());
        //                retorno.Estados = oReader["Estados"].ToString();
        //                retorno.Comentario = oReader["Comentario"].ToString();
        //            }
        //            conn.Close();

        //        }
        //   }
        //   catch (Expeption ex)
        //    {
        //         throw ex;
        //    }
        //        return retorno;

        // }





        }
        

    }

