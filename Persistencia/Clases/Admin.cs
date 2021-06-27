using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Clases;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia.Clases
{
    public class Admin : Persistencia
    {
        public static bool AgregarAdmin(Common.Clases.Admin pAdmin)
        {
            bool retorno = true;

            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("AgregarAdmin", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@cedula", pAdmin.Cedula));
                cmd.Parameters.Add(new SqlParameter("@nombre", pAdmin.Nombre));
                cmd.Parameters.Add(new SqlParameter("@apellido", pAdmin.Apellido));
                cmd.Parameters.Add(new SqlParameter("@fechaNacimiento", pAdmin.FechaNacimiento));
                cmd.Parameters.Add(new SqlParameter("@cargo", pAdmin.Cargo));
                cmd.Parameters.Add(new SqlParameter("@telefono", pAdmin.Telefono));
                cmd.Parameters.Add(new SqlParameter("@usuario", pAdmin.Usuario));
                cmd.Parameters.Add(new SqlParameter("@contrasenia", pAdmin.Contraseña));

                int rtn = cmd.ExecuteNonQuery();
                if (rtn <= 0)
                {
                    retorno = false;
                }

                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public static bool EliminarAdmin(Common.Clases.Admin pAdmin)
        {
            bool retorno = true;

            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("EliminarAdmin", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@cedula", pAdmin.Cedula));


                int rtn = cmd.ExecuteNonQuery();
                if (rtn <= 0)
                {
                    retorno = false;
                }

                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public static bool ModificarAdmin(Common.Clases.Admin pAdmin)
        {
            throw new NotImplementedException();
        }
        public static List<Common.Clases.Admin> MostrarAdmin()
        {
            List<Common.Clases.Admin> retorno = new List<Common.Clases.Admin>();
            Common.Clases.Admin admin;

            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("mostrarAdministradores", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        admin = new Common.Clases.Admin();
                        admin.Cedula = int.Parse(oReader["Cedula"].ToString());
                        admin.Nombre = oReader["Nombre"].ToString();
                        admin.Apellido = oReader["Apellido"].ToString();
                        admin.Edad = int.Parse(oReader["Edad"].ToString());
                        admin.FechaNacimiento = Convert.ToDateTime(oReader["FechaNacimiento"]);
                        admin.Cargo = oReader["Cargo"].ToString();
                        admin.Telefono = oReader["Telefono"].ToString();
                        admin.Usuario = oReader["Usuario"].ToString();
                        admin.Contraseña = oReader["Contrasenia"].ToString();

                        retorno.Add(admin);
                    }
                    conexion.Close();
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
