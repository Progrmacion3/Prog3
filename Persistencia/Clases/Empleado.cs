using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Clases;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia.Clases
{
    public class Empleado : Persistencia
    {
        public static bool AgregarEmpleado(Common.Clases.Empleado pEmpleado)
        {
            throw new NotImplementedException();
        }

        public static bool EliminarEmpleado(Common.Clases.Empleado pEmpleado)
        {
            throw new NotImplementedException();
        }

        public static bool ModificarEmpleado(Common.Clases.Empleado pEmpleado)
        {
            throw new NotImplementedException();
        }

        public static List<Common.Clases.Empleado> MostrarEmpleadosActivos()
        {
            List<Common.Clases.Empleado> retorno = new List<Common.Clases.Empleado>();
            Common.Clases.Empleado empleado;

            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("mostrarEmpleadosActivos", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        empleado = new Common.Clases.Empleado();
                        empleado.Cedula = int.Parse(oReader["Cedula"].ToString());
                        empleado.Nombre = oReader["Nombre"].ToString();
                        empleado.Apellido = oReader["Apellido"].ToString();
                        empleado.Edad = int.Parse(oReader["Edad"].ToString());
                        empleado.FechaNacimiento = DateTime.Parse(oReader["FechaNacimiento"].ToString());
                        empleado.Cargo = oReader["Cargo"].ToString();
                        empleado.Telefono = oReader["Telefono"].ToString();
                        empleado.Usuario = oReader["Usuario"].ToString();
                        empleado.Contraseña = oReader["Contrasenia"].ToString();

                        retorno.Add(empleado);
                    }
                    conexion.Close();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return retorno;
        }
        //public static Common.Clases.Empleado MostrarEmpleadoEspecifico(Common.Clases.Empleado pEmpleado)
        //{
        //    Common.Clases.Empleado retorno = null;
        //    try
        //    {
        //        var conexion = new SqlConnection(CadenaDeConexion);
        //        conexion.Open();

        //        SqlCommand cmd = new SqlCommand("mostrarEmpleadoEspecifico", conexion);

        //        cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.Parameters.Add(new SqlParameter(@))

        //        using(SqlDataReader oReader = cmd.ExecuteReader())
        //        {
        //            while (oReader.Read())
        //            {
        //                empleado = new Common.Clases.Empleado();
        //                empleado.Cedula = int.Parse(oReader["Cedula"].ToString());
        //                empleado.Nombre = oReader["Nombre"].ToString();
        //                empleado.Apellido = oReader["Apellido"].ToString();
        //                empleado.FechaNacimiento = Convert.ToDateTime(oReader["FechaNacimiento"]);
        //                empleado.Cargo = oReader["Cargo"].ToString();
        //                empleado.Telefono = oReader["Telefono"].ToString();
        //                empleado.Usuario = oReader["Usuario"].ToString();
        //            }
        //            conexion.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return retorno;
        //}
    }
}
