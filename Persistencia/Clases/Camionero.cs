using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Clases;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia.Clases
{
    public class Camionero : Persistencia
    {
        public static bool AgregarCamionero(Common.Clases.Camionero pCamionero)
        {
            bool retorno = true;

            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("AgregarCamionero", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@cedula", pCamionero.Cedula));
                cmd.Parameters.Add(new SqlParameter("@nombre", pCamionero.Nombre));
                cmd.Parameters.Add(new SqlParameter("@apellido", pCamionero.Apellido));
                cmd.Parameters.Add(new SqlParameter("@fechaNacimiento", pCamionero.FechaNacimiento));
                cmd.Parameters.Add(new SqlParameter("@cargo", pCamionero.Cargo));
                cmd.Parameters.Add(new SqlParameter("@telefono", pCamionero.Telefono));
                cmd.Parameters.Add(new SqlParameter("@usuario", pCamionero.Usuario));
                cmd.Parameters.Add(new SqlParameter("@contrasenia", pCamionero.Contraseña));
                cmd.Parameters.Add(new SqlParameter("@categoriaLibreta", pCamionero.CategoriaLibreta));
                cmd.Parameters.Add(new SqlParameter("@fechaVencimiento", pCamionero.FechaVencimiento));

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

        public static bool EliminarCamionero(Common.Clases.Camionero pCamionero)
        {
            throw new NotImplementedException();
        }

        public static bool ModificarCamionero(Common.Clases.Camionero pCamionero)
        {
            throw new NotImplementedException();
        }
    }
}
