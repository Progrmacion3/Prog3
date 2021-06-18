using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Persistencia
{
    public class PersistenciaUsuario : Persistencia
    {
        public static bool VerificarLogin(Usuario usuario)
        {
            try
            {
                var conexión = new SqlConnection(CadenaDeConexion);
                var comando = new SqlCommand("verificar_login", conexión);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@usuario", usuario.UsuarioLogin));
                comando.Parameters.Add(new SqlParameter("@contrasenia", usuario.Contraseña));
                conexión.Open();
                int retorno = (int)comando.ExecuteScalar();
                conexión.Close();
                return retorno > 0;
            }
            catch // (Exception ex)
            {
                // Hacer algo?
                return false;
            }
        }

        public static bool Alta(Usuario usuario)
        {
            try
            {
                var conexión = new SqlConnection(CadenaDeConexion);
                var comando = new SqlCommand("agregar_usuario", conexión);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@nombre", usuario.Nombre));
                comando.Parameters.Add(new SqlParameter("@apellido", usuario.Apellido));
                comando.Parameters.Add(new SqlParameter("@cedula", usuario.Cédula));
                comando.Parameters.Add(new SqlParameter("@cargo", usuario.Cargo));
                comando.Parameters.Add(new SqlParameter("@telefono", usuario.Teléfono));
                comando.Parameters.Add(new SqlParameter("@usuario", usuario.UsuarioLogin));
                comando.Parameters.Add(new SqlParameter("@contrasenia", usuario.Contraseña));
                conexión.Open();
                int retorno = comando.ExecuteNonQuery();
                conexión.Close();
                return retorno > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
