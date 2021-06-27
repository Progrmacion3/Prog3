using Common.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Persistencia.Clases
{
    public class pAdministrador : Persistencia
    {
        public static bool AltaAdministrador(Common.Clases.Administrador pAdministrador)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Administrador_Agregar", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@ci", pAdministrador.CI));
                cmd.Parameters.Add(new SqlParameter("@nombre", pAdministrador.Nombre));
                cmd.Parameters.Add(new SqlParameter("@apellido", pAdministrador.Apellido));
                cmd.Parameters.Add(new SqlParameter("@cargo", pAdministrador.Cargo));
                cmd.Parameters.Add(new SqlParameter("@telefono", pAdministrador.Telefono));
                cmd.Parameters.Add(new SqlParameter("@tipo", pAdministrador.Tipo));
                cmd.Parameters.Add(new SqlParameter("@usuario", pAdministrador.Usuario));
                cmd.Parameters.Add(new SqlParameter("@password", pAdministrador.Password));

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
        public static bool ModificarAdministrador(Common.Clases.Administrador pAdministrador)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Administrador_Modificar", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@ci", pAdministrador.CI));
                cmd.Parameters.Add(new SqlParameter("@nombre", pAdministrador.Nombre));
                cmd.Parameters.Add(new SqlParameter("@apellido", pAdministrador.Apellido));
                cmd.Parameters.Add(new SqlParameter("@cargo", pAdministrador.Cargo));
                cmd.Parameters.Add(new SqlParameter("@telefono", pAdministrador.Telefono));
                cmd.Parameters.Add(new SqlParameter("@tipo", pAdministrador.Tipo));
                cmd.Parameters.Add(new SqlParameter("@usuario", pAdministrador.Usuario));
                cmd.Parameters.Add(new SqlParameter("@password", pAdministrador.Password));


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
        public static bool BajaAdministrador(Common.Clases.Administrador pAdministrador)
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
                cmd.Parameters.Add(new SqlParameter("@ci", pAdministrador.CI));
                cmd.Parameters.Add(new SqlParameter("@estado", pAdministrador.Estado));

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
        public static Common.Clases.Administrador TraerAdministrador(Common.Clases.Administrador pAdministrador)
        {
            Common.Clases.Administrador Administrador = null;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Administrador_TraerEspecifico", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@ci", pAdministrador.CI));
                

                // ejecutamos el store desde c#
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {

                    while (oReader.Read())
                    {
                        Administrador = new Common.Clases.Administrador();
                        Administrador.CI = int.Parse(oReader["ciEmpleado"].ToString());
                        Administrador.Nombre = oReader["nombreEmpleado"].ToString();
                        Administrador.Apellido = oReader["apellidoEmpleado"].ToString();
                        Administrador.Cargo = oReader["cargoEmpleado"].ToString();
                        Administrador.Telefono = oReader["telefonoEmpleado"].ToString();
                        Administrador.Tipo = oReader["tipoEmpleado"].ToString();
                        Administrador.Usuario = oReader["usuarioEmpleado"].ToString();
                        Administrador.Password = oReader["passwordEmpleado"].ToString();


                    }

                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Administrador;
        }
        public static List<Common.Clases.Administrador> ListarAdministradores()
        {
            List<Common.Clases.Administrador> ListaAdministradores = new List<Common.Clases.Administrador>();
            Common.Clases.Administrador adm;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Administrador_TraerTodos", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // ejecutamos el store desde c#
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {

                    while (oReader.Read())
                    {
                        adm = new Common.Clases.Administrador();
                        adm.CI = int.Parse(oReader["ciEmpleado"].ToString());
                        adm.Nombre = oReader["nombreEmpleado"].ToString();
                        adm.Apellido = oReader["apellidoEmpleado"].ToString();
                        adm.Cargo = oReader["cargoEmpleado"].ToString();
                        adm.Telefono= oReader["telefonoEmpleado"].ToString();
                        adm.Tipo = oReader["tipoEmpleado"].ToString();


                        ListaAdministradores.Add(adm);
                    }

                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ListaAdministradores;
        }

    }
}
