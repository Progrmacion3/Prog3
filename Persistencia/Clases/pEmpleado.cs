


















using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace Persistencia.Clases
{
    public class pEmpleado : Persistencia
    {
        public static bool AgregarEmpleado(Common.Clases.Empleado pEmp)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Empleados_Agregar", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@Cedula", pEmp.Cedula));
                cmd.Parameters.Add(new SqlParameter("@Nombre", pEmp.Nombre));
                cmd.Parameters.Add(new SqlParameter("@Apellido", pEmp.Apellido));
                cmd.Parameters.Add(new SqlParameter("@Telefono", pEmp.Telefono));
                cmd.Parameters.Add(new SqlParameter("@Tipo", pEmp.Tipo));
                cmd.Parameters.Add(new SqlParameter("@Usuario", pEmp.Usuario));
                cmd.Parameters.Add(new SqlParameter("@Contrasenia", pEmp.Contrasenia));
                cmd.Parameters.Add(new SqlParameter("@Estado", pEmp.Estado));

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
        /*public static Common.Clases.Cliente TraerEspecifico(Common.Clases.Cliente pCli)
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

        }*/




        /*  public static List<Common.Clases.Cliente> TraerTodosLosClientes()
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
        public static bool ModificarEmpleado(Common.Clases.Empleado pEmp)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Empleado_Modificar", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@Cedula", pEmp.Cedula));
                cmd.Parameters.Add(new SqlParameter("@Nombre", pEmp.Nombre));
                cmd.Parameters.Add(new SqlParameter("@Apellido", pEmp.Apellido));
                cmd.Parameters.Add(new SqlParameter("@Telefono", pEmp.Telefono));
                cmd.Parameters.Add(new SqlParameter("@Tipo", pEmp.Tipo));
                cmd.Parameters.Add(new SqlParameter("@Usuario", pEmp.Usuario));
                cmd.Parameters.Add(new SqlParameter("@Contrasenia", pEmp.Contrasenia));
                cmd.Parameters.Add(new SqlParameter("@Estado", pEmp.Estado));


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
        public static bool EliminarEmpleado(Common.Clases.Empleados pEmp)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Cliente_Eliminar", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del S
                cmd.Parameters.Add(new SqlParameter("@Estado", pEmp.Estado));
                cmd.Parameters.Add(new SqlParameter("@Cedula", pEmp.Cedula));

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






