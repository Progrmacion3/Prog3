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

                SqlCommand cmd = new SqlCommand("Empleado_Agregar", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@nombreEmp", pCamionero.Nombre));
                cmd.Parameters.Add(new SqlParameter("@apellidoEmp", pCamionero.Apellido));
                cmd.Parameters.Add(new SqlParameter("@CI", pCamionero.Cedula));
                cmd.Parameters.Add(new SqlParameter("@cargo", pCamionero.Cargo));
                cmd.Parameters.Add(new SqlParameter("@telefonoEmp", pCamionero.Telefono));
                cmd.Parameters.Add(new SqlParameter("@usuarioEmp", pCamionero.Usuario));
                cmd.Parameters.Add(new SqlParameter("@contrasenaEmp", pCamionero.Contrasena));
                cmd.Parameters.Add(new SqlParameter("@estado", 1));

                int rtn = cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

  
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("Camionero_Agregar", conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.Add(new SqlParameter("@fechaVencimiento", pCamionero.FechaVencimiento));
                cmd2.Parameters.Add(new SqlParameter("@edad", pCamionero.Edad));
                cmd2.Parameters.Add(new SqlParameter("@tipoLibreta", pCamionero.TipoLibreta));
                cmd2.Parameters.Add(new SqlParameter("@estado", 1));

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

                conn.Open();

                SqlCommand cmd2 = new SqlCommand("Empleado_Eliminar", conn);

                cmd2.CommandType = CommandType.StoredProcedure;

                cmd2.Parameters.Add(new SqlParameter("@idEmp", pCamionero.Id));

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

        public static bool ModificarCamionero(Camionero pCamionero)
        {
            bool retorno = true;
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Empleado_Modificar", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idEmp", pCamionero.Id));
                cmd.Parameters.Add(new SqlParameter("@nombreEmp", pCamionero.Nombre));
                cmd.Parameters.Add(new SqlParameter("@apellidoEmp", pCamionero.Apellido));
                cmd.Parameters.Add(new SqlParameter("@CI", pCamionero.Cedula));
                cmd.Parameters.Add(new SqlParameter("@cargo", pCamionero.Cargo));
                cmd.Parameters.Add(new SqlParameter("@telefonoEmp", pCamionero.Telefono));
                cmd.Parameters.Add(new SqlParameter("@usuarioEmp", pCamionero.Usuario));
                cmd.Parameters.Add(new SqlParameter("@contrasenaEmp", pCamionero.Contrasena));
                cmd.Parameters.Add(new SqlParameter("@estado", 1));


                int rtn = cmd.ExecuteNonQuery();

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();

                SqlCommand cmd2 = new SqlCommand("Camionero_Modificar", conn);

                cmd2.CommandType = CommandType.StoredProcedure;

                cmd2.Parameters.Add(new SqlParameter("@idCamionero", pCamionero.Id));
                cmd2.Parameters.Add(new SqlParameter("@fechaVencimiento", pCamionero.FechaVencimiento));
                cmd2.Parameters.Add(new SqlParameter("@edad", pCamionero.Edad));
                cmd2.Parameters.Add(new SqlParameter("@tipoLibreta", pCamionero.TipoLibreta));
                cmd2.Parameters.Add(new SqlParameter("@estado", 1));

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

        public static List<Camionero> pListaCamioneros()
        {
            List<Camionero> listaCamioneros = new List<Camionero>();
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Camionero_TraerTodos", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Camionero camionero = new Camionero();
                        camionero.Id = int.Parse(oReader["IdEmp"].ToString());
                        camionero.Nombre = oReader["nombreEmp"].ToString();
                        camionero.Apellido = oReader["apellidoEmp"].ToString();
                        camionero.Cedula = oReader["CI"].ToString();
                        camionero.Cargo = oReader["cargo"].ToString();
                        camionero.Telefono = oReader["telefonoEmp"].ToString();
                        camionero.Usuario = oReader["usuarioEmp"].ToString();
                        camionero.Contrasena = oReader["contrasenaEmp"].ToString();
                        camionero.Edad = int.Parse(oReader["edad"].ToString());
                        camionero.TipoLibreta = oReader["tipoLibreta"].ToString();
                        camionero.FechaVencimiento = DateTime.Parse(oReader["fechaVencimiento"].ToString());

                        listaCamioneros.Add(camionero);
                    }
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listaCamioneros;
        }
    }
}