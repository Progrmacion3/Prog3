using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

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

                SqlCommand cmd = new SqlCommand("Agregar_Empleado", conn);

                cmd.CommandType = CommandType.StoredProcedure;

;
                cmd.Parameters.Add(new SqlParameter("@CIEmpleado",        pEmp.CI));
                cmd.Parameters.Add(new SqlParameter("@NombreEmpleado",    pEmp.Nombre));
                cmd.Parameters.Add(new SqlParameter("@ApellidoEmpleado",  pEmp.Apellido));
                cmd.Parameters.Add(new SqlParameter("@CargoEmpleado",     pEmp.Estado));
                cmd.Parameters.Add(new SqlParameter("@TelefonoEmpleado",  pEmp.Telefono));
                cmd.Parameters.Add(new SqlParameter("@TipoEmpleado",      pEmp.Tipo));
                cmd.Parameters.Add(new SqlParameter("@UsuarioEmpleado",   pEmp.Usuario));
                cmd.Parameters.Add(new SqlParameter("@ContraseñaEmpleado",pEmp.Contraseña));


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




        public static bool ModificarEmpleado(Common.Clases.Empleado pEmp)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Modificar_Empleadp", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idEmpleado", pEmp.idEmpleado));
                cmd.Parameters.Add(new SqlParameter("@CIEmpleado", pEmp.CI));
                cmd.Parameters.Add(new SqlParameter("@NombreEmpleado", pEmp.Nombre));
                cmd.Parameters.Add(new SqlParameter("@ApellidoEmpleado", pEmp.Apellido));
                cmd.Parameters.Add(new SqlParameter("@CargoEmpleado", pEmp.Estado));
                cmd.Parameters.Add(new SqlParameter("@TelefonoEmpleado", pEmp.Telefono));
                cmd.Parameters.Add(new SqlParameter("@TipoEmpleado", pEmp.Tipo));
                cmd.Parameters.Add(new SqlParameter("@UsuarioEmpleado", pEmp.Usuario));
                cmd.Parameters.Add(new SqlParameter("@ContraseñaEmpleado", pEmp.Contraseña));

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


        public static bool EliminarEmpleado(Common.Clases.Empleado pEmp)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Eliminar_Empleado", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idEmpleado", pEmp.idEmpleado));
                cmd.Parameters.Add(new SqlParameter("@estado", pEmp.Estado));

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

