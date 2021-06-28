using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using obligatorio.Dominio;


namespace obligatorio.Persistencia.Clases
{
    public class pCamionero : Persistencia
    {
        public static bool AgregarCamionero(Camionero pCamionero)
        {
            bool retorno = true;
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Camionero_Agregar", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@nombreEmp", pCamionero.Nombre));
                cmd.Parameters.Add(new SqlParameter("@apellidoEmp", pCamionero.Apellido));
                cmd.Parameters.Add(new SqlParameter("@CI", pCamionero.Cedula));
                cmd.Parameters.Add(new SqlParameter("@cargo", pCamionero.Cargo));
                cmd.Parameters.Add(new SqlParameter("@telefonoEmp", pCamionero.Telefono));
                cmd.Parameters.Add(new SqlParameter("@usuarioEmp", pCamionero.Usuario));
                cmd.Parameters.Add(new SqlParameter("@contraseñaEmp", pCamionero.Contrasena));
                cmd.Parameters.Add(new SqlParameter("@fechaVencimiento", pCamionero.FechaVencimiento));
                cmd.Parameters.Add(new SqlParameter("@edad", pCamionero.Edad));
                cmd.Parameters.Add(new SqlParameter("@tipoLibreta", pCamionero.TipoLibreta));
                cmd.Parameters.Add(new SqlParameter("@fechaVencimiento", pCamionero.FechaVencimiento));


                int rtn = cmd.ExecuteNonQuery();

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

        public static bool EliminarCamionero(Camionero pCamionero)
        {
            bool retorno = true;
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Camionero_Eliminar", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idCamionero", pCamionero.Id));

                int rtn = cmd.ExecuteNonQuery();

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

        public static bool ModificarCamionero(Camionero pCamionero)
        {
            bool retorno = true;
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Camionero_Modificar", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idCamionero", pCamionero.Id));
                cmd.Parameters.Add(new SqlParameter("@nombreEmp", pCamionero.Nombre));
                cmd.Parameters.Add(new SqlParameter("@apellidoEmp", pCamionero.Apellido));
                cmd.Parameters.Add(new SqlParameter("@CI", pCamionero.Cedula));
                cmd.Parameters.Add(new SqlParameter("@cargo", pCamionero.Cargo));
                cmd.Parameters.Add(new SqlParameter("@telefonoEmp", pCamionero.Telefono));
                cmd.Parameters.Add(new SqlParameter("@usuarioEmp", pCamionero.Usuario));
                cmd.Parameters.Add(new SqlParameter("@contraseñaEmp", pCamionero.Contrasena));
                cmd.Parameters.Add(new SqlParameter("@fechaVencimiento", pCamionero.FechaVencimiento));
                cmd.Parameters.Add(new SqlParameter("@edad", pCamionero.Edad));
                cmd.Parameters.Add(new SqlParameter("@tipoLibreta", pCamionero.TipoLibreta));
                cmd.Parameters.Add(new SqlParameter("@fechaVencimiento", pCamionero.FechaVencimiento));


                int rtn = cmd.ExecuteNonQuery();

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