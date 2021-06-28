using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using obligatorio.Dominio;


namespace obligatorio.Persistencia.Clases
{
    public class pAdministrador : Persistencia
    {
        public static bool AgregarAdministrador(Administrador pAdministrador)
        {
            bool retorno = true;
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Administrador_Agregar", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@nombreEmp", pAdministrador.Nombre));
                cmd.Parameters.Add(new SqlParameter("@apellidoEmp", pAdministrador.Apellido));
                cmd.Parameters.Add(new SqlParameter("@CI", pAdministrador.Cedula));
                cmd.Parameters.Add(new SqlParameter("@cargo", pAdministrador.Cargo));
                cmd.Parameters.Add(new SqlParameter("@telefonoEmp", pAdministrador.Telefono));
                cmd.Parameters.Add(new SqlParameter("@usuarioEmp", pAdministrador.Usuario));
                cmd.Parameters.Add(new SqlParameter("@contraseñaEmp", pAdministrador.Contrasena));


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

        public static bool EliminarAdministrador(Administrador pAdministrador)
        {
            bool retorno = true;
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Administrador_Eliminar", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idAdmin", pAdministrador.Id));

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

        public static bool ModificarAdministrador(Administrador pAdministrador)
        {
            bool retorno = true;
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Administrador_Modificar", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idAdmin", pAdministrador.Id));
                cmd.Parameters.Add(new SqlParameter("@nombreEmp", pAdministrador.Nombre));
                cmd.Parameters.Add(new SqlParameter("@apellidoEmp", pAdministrador.Apellido));
                cmd.Parameters.Add(new SqlParameter("@CI", pAdministrador.Cedula));
                cmd.Parameters.Add(new SqlParameter("@cargo", pAdministrador.Cargo));
                cmd.Parameters.Add(new SqlParameter("@telefonoEmp", pAdministrador.Telefono));
                cmd.Parameters.Add(new SqlParameter("@usuarioEmp", pAdministrador.Usuario));
                cmd.Parameters.Add(new SqlParameter("@contraseñaEmp", pAdministrador.Contrasena));


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