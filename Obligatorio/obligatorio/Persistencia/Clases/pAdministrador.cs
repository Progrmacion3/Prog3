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

                SqlCommand cmd = new SqlCommand("Empleado_Agregar", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@nombreEmp", pAdministrador.Nombre));
                cmd.Parameters.Add(new SqlParameter("@apellidoEmp", pAdministrador.Apellido));
                cmd.Parameters.Add(new SqlParameter("@CI", pAdministrador.Cedula));
                cmd.Parameters.Add(new SqlParameter("@cargo", pAdministrador.Cargo));
                cmd.Parameters.Add(new SqlParameter("@telefonoEmp", pAdministrador.Telefono));
                cmd.Parameters.Add(new SqlParameter("@usuarioEmp", pAdministrador.Usuario));
                cmd.Parameters.Add(new SqlParameter("@contrasenaEmp", pAdministrador.Contrasena));
                cmd.Parameters.Add(new SqlParameter("@estado", 1));

                int rtn = cmd.ExecuteNonQuery();

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();
                SqlCommand cmd2 = new SqlCommand("Administrador_Agregar", conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                int rtn2 = cmd2.ExecuteNonQuery();
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

                conn.Open();

                SqlCommand cmd2 = new SqlCommand("Empleado_Eliminar", conn);

                cmd2.CommandType = CommandType.StoredProcedure;

                cmd2.Parameters.Add(new SqlParameter("@idEmp", pAdministrador.Id));

                int rtn2 = cmd2.ExecuteNonQuery();

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

                SqlCommand cmd = new SqlCommand("Empleado_Modificar", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idEmp", pAdministrador.Id));
                cmd.Parameters.Add(new SqlParameter("@nombreEmp", pAdministrador.Nombre));
                cmd.Parameters.Add(new SqlParameter("@apellidoEmp", pAdministrador.Apellido));
                cmd.Parameters.Add(new SqlParameter("@CI", pAdministrador.Cedula));
                cmd.Parameters.Add(new SqlParameter("@cargo", pAdministrador.Cargo));
                cmd.Parameters.Add(new SqlParameter("@telefonoEmp", pAdministrador.Telefono));
                cmd.Parameters.Add(new SqlParameter("@usuarioEmp", pAdministrador.Usuario));
                cmd.Parameters.Add(new SqlParameter("@contrasenaEmp", pAdministrador.Contrasena));
                cmd.Parameters.Add(new SqlParameter("@estado", 1));


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

        public static List<Administrador> pListaAdmins()
        {
            List<Administrador> listaAdmins = new List<Administrador>();
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Administrador_TraerTodos", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Administrador admin = new Administrador();
                        admin.Id = int.Parse(oReader["IdEmp"].ToString());
                        admin.Nombre = oReader["nombreEmp"].ToString();
                        admin.Apellido = oReader["apellidoEmp"].ToString();
                        admin.Cedula = oReader["CI"].ToString();
                        admin.Cargo = oReader["cargo"].ToString();
                        admin.Telefono = oReader["telefonoEmp"].ToString();
                        admin.Usuario = oReader["usuarioEmp"].ToString();
                        admin.Contrasena = oReader["contrasenaEmp"].ToString();

                        listaAdmins.Add(admin);
                    }
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listaAdmins;
        }
    }
}