using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Persistencia
{
    public class PersistenciaCamionero : PersistenciaUsuario
    {
        public static bool Alta(Camionero camionero)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "alta_camionero";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@id", SqlDbType.Int);
            comando.Parameters["@id"].Direction = ParameterDirection.Output;
            comando.Parameters.AddWithValue("@nombre", camionero.Nombre);
            comando.Parameters.AddWithValue("@apellido", camionero.Apellido);
            comando.Parameters.AddWithValue("@cedula", camionero.Cédula);
            comando.Parameters.AddWithValue("@cargo", camionero.Cargo);
            comando.Parameters.AddWithValue("@telefono", camionero.Teléfono);
            comando.Parameters.AddWithValue("@usuario", camionero.UsuarioLogin);
            comando.Parameters.AddWithValue("@contrasenia", camionero.Contraseña);
            comando.Parameters.AddWithValue("@fec_nac", camionero.Nacimiento);
            comando.Parameters.AddWithValue("@tipo_lib", camionero.TipoLibreta);
            comando.Parameters.AddWithValue("@venc_lib", camionero.VencimientoLibreta);
            try
            {
                conexión.Open();
                comando.ExecuteNonQuery();
                camionero.Id = Convert.ToInt32(comando.Parameters["@id"].Value);
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

        public static bool Modificar(Camionero camionero)
        {
            var conexión = new SqlConnection(CadenaDeConexion);
            var comando = conexión.CreateCommand();
            comando.CommandText = "modificar_administrador";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", camionero.Id);
            comando.Parameters.AddWithValue("@nombre", camionero.Nombre);
            comando.Parameters.AddWithValue("@apellido", camionero.Apellido);
            comando.Parameters.AddWithValue("@cedula", camionero.Cédula);
            comando.Parameters.AddWithValue("@cargo", camionero.Cargo);
            comando.Parameters.AddWithValue("@telefono", camionero.Teléfono);
            comando.Parameters.AddWithValue("@usuario", camionero.UsuarioLogin);
            comando.Parameters.AddWithValue("@contrasenia", camionero.Contraseña);
            comando.Parameters.AddWithValue("@fec_nac", camionero.Nacimiento);
            comando.Parameters.AddWithValue("@tipo_lib", camionero.TipoLibreta);
            comando.Parameters.AddWithValue("@venc_lib", camionero.VencimientoLibreta);
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

        public static bool Listar(List<Camionero> lista)
        {
            throw new NotImplementedException();
        }
    }
}
