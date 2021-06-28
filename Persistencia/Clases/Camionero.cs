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
            bool retorno = true;

            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("EliminarCamionero", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@cedula", pCamionero.Cedula));


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

        public static bool ModificarCamionero(Common.Clases.Camionero pCamionero)
        {
            bool retorno = true;

            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("ModificarCamionero", conexion);

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

        public static List<Common.Clases.Camionero> MostrarCamionero()
        {
            List<Common.Clases.Camionero> retorno = new List<Common.Clases.Camionero>();
            Common.Clases.Camionero camionero;

            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("mostrarCamioneros", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        camionero = new Common.Clases.Camionero();
                        camionero.IdCamionero = int.Parse(oReader["IdCamionero"].ToString());
                        camionero.Cedula = int.Parse(oReader["Cedula"].ToString());
                        camionero.Nombre = oReader["Nombre"].ToString();
                        camionero.Apellido = oReader["Apellido"].ToString();
                        camionero.Edad = int.Parse(oReader["Edad"].ToString());
                        camionero.FechaNacimiento = Convert.ToDateTime(oReader["FechaNacimiento"]);
                        camionero.Cargo = oReader["Cargo"].ToString();
                        camionero.Telefono = oReader["Telefono"].ToString();
                        camionero.Usuario = oReader["Usuario"].ToString();
                        camionero.Contraseña = oReader["Contrasenia"].ToString();
                        camionero.CategoriaLibreta = oReader["CategoriaLibreta"].ToString();
                        camionero.FechaVencimiento = Convert.ToDateTime(oReader["FechaVencimiento"]);
                        retorno.Add(camionero);
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
        public static Common.Clases.Camionero MostrarCamioneroEspecifico(Common.Clases.Camionero pCamionero)
        {
            Common.Clases.Camionero retorno = null;
            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("mostrarCamioneroEspecifico", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@cedula", pCamionero.Cedula));

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        retorno = new Common.Clases.Camionero();
                        retorno.Cedula = int.Parse(oReader["Cedula"].ToString());
                        retorno.Nombre = oReader["Nombre"].ToString();
                        retorno.Apellido = oReader["Apellido"].ToString();
                        retorno.Edad = int.Parse(oReader["Edad"].ToString());
                        retorno.FechaNacimiento = Convert.ToDateTime(oReader["FechaNacimiento"]);
                        retorno.Cargo = oReader["Cargo"].ToString();
                        retorno.Telefono = oReader["Telefono"].ToString();
                        retorno.Usuario = oReader["Usuario"].ToString();
                        retorno.Contraseña = oReader["Contrasenia"].ToString();
                        retorno.CategoriaLibreta = oReader["CategoriaLibreta"].ToString();
                        retorno.FechaVencimiento = Convert.ToDateTime(oReader["FechaVencimiento"]);
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
        public static Common.Clases.Camionero MostrarCamioneroEspecifico2(Common.Clases.Camionero pCamionero)
        {
            Common.Clases.Camionero retorno = null;
            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("mostrarCamioneroEspecifico2", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@idCamionero", pCamionero.IdCamionero));

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        retorno = new Common.Clases.Camionero();
                        retorno.IdCamionero = int.Parse(oReader["IdCamionero"].ToString());
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
