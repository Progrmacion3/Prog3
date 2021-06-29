using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Persistencia.Clases
{
    public class pUtilidades: Persistencia
    {
        public static Common.Clases.Empleado TraerEmpleadoInicioSesion(Common.Clases.Empleado pEmpleado)
        {
            Common.Clases.Empleado empleado = null;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("EmpleadoInicioSesion_TraerEspecifico", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@usuario", pEmpleado.Usuario));
                cmd.Parameters.Add(new SqlParameter("@password", pEmpleado.Password));

                // ejecutamos el store desde c#
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {

                    while (oReader.Read())
                    {
                        empleado = new Common.Clases.Empleado();
                        empleado.CI = int.Parse(oReader["ciEmpleado"].ToString());
                        empleado.Nombre = oReader["nombreEmpleado"].ToString();
                        empleado.Apellido = oReader["apellidoEmpleado"].ToString();
                        empleado.Cargo = oReader["cargoEmpleado"].ToString();
                        empleado.Telefono = oReader["telefonoEmpleado"].ToString();
                        empleado.Tipo = oReader["tipoEmpleado"].ToString();
                        empleado.Usuario = oReader["usuarioEmpleado"].ToString();
                        empleado.Password = oReader["passwordEmpleado"].ToString();
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return empleado;
        }
    }
}
