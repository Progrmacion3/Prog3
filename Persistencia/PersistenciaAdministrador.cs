using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Persistencia
{
    public class PersistenciaAdministrador : PersistenciaUsuario
    {
        public static bool Alta(Administrador administrador)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "alta_administrador";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@id", SqlDbType.Int);
            comando.Parameters["@id"].Direction = ParameterDirection.Output;
            comando.Parameters.AddWithValue("@nombre", administrador.Nombre);
            comando.Parameters.AddWithValue("@apellido", administrador.Apellido);
            comando.Parameters.AddWithValue("@cedula", administrador.Cédula);
            comando.Parameters.AddWithValue("@cargo", administrador.Cargo);
            comando.Parameters.AddWithValue("@telefono", administrador.Teléfono);
            comando.Parameters.AddWithValue("@usuario", administrador.UsuarioLogin);
            comando.Parameters.AddWithValue("@contrasenia", administrador.Contraseña);
            try
            {
                conexión.Open();
                comando.ExecuteNonQuery();
                administrador.Id = Convert.ToInt32(comando.Parameters["@id"].Value);
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conexión.Close();
            }
        }

        public static bool Modificar(Administrador administrador)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "modificar_administrador";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", administrador.Id);
            comando.Parameters.AddWithValue("@nombre", administrador.Nombre);
            comando.Parameters.AddWithValue("@apellido", administrador.Apellido);
            comando.Parameters.AddWithValue("@cedula", administrador.Cédula);
            comando.Parameters.AddWithValue("@cargo", administrador.Cargo);
            comando.Parameters.AddWithValue("@telefono", administrador.Teléfono);
            comando.Parameters.AddWithValue("@usuario", administrador.UsuarioLogin);
            comando.Parameters.AddWithValue("@contrasenia", administrador.Contraseña);
            try
            {
                conexión.Open();
                comando.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conexión.Close();
            }
        }

        public static bool Listar(List<Administrador> lista)
        {
            return true;
            /*var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "select dbo.listar_administrador";
            comando.CommandType = CommandType.;
            comando.Parameters.AddWithValue("@id", administrador.Id);
            comando.Parameters.AddWithValue("@nombre", administrador.Nombre);
            comando.Parameters.AddWithValue("@apellido", administrador.Apellido);
            comando.Parameters.AddWithValue("@cedula", administrador.Cédula);
            comando.Parameters.AddWithValue("@cargo", administrador.Cargo);
            comando.Parameters.AddWithValue("@telefono", administrador.Teléfono);
            comando.Parameters.AddWithValue("@usuario", administrador.UsuarioLogin);
            comando.Parameters.AddWithValue("@contrasenia", administrador.Contraseña);
            try
            {
                conexión.Open();
                comando.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conexión.Close();
            }*/
        }
    }
}
