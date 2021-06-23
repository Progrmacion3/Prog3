using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Clases;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia.Clases
{
    public class Viaje : Persistencia
    {
        public static bool AgregarViaje(Common.Clases.Viaje pViaje)
        {
            bool retorno = true;

            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("AgregarCamion", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add(new SqlParameter("@matricula", pCamion.Matricula));
                //cmd.Parameters.Add(new SqlParameter("@marca", pCamion.Marca));
                //cmd.Parameters.Add(new SqlParameter("@modelo", pCamion.Modelo));
                //cmd.Parameters.Add(new SqlParameter("@año", pCamion.Año));

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

        public static bool EliminarViaje(Common.Clases.Viaje pViaje)
        {
            throw new NotImplementedException();
        }

        public static bool ModificarViaje(Common.Clases.Viaje pViaje)
        {
            throw new NotImplementedException();
        }
    }
}
