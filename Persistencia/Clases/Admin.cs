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
            throw new NotImplementedException();
        }

        public static bool ModificarAdmin(Common.Clases.Admin pAdmin)
        {
            throw new NotImplementedException();
        }
    }
}
