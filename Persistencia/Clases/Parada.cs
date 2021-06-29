﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Clases;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia.Clases
{
    public class Parada : Persistencia
    {
        public static bool AgregarParada(Common.Clases.Parada pParada)
        {
            throw new NotImplementedException();
        }

        public static bool EliminarParada(Common.Clases.Parada pParada)
        {
            throw new NotImplementedException();
        }

        public static bool ModificarParada(Common.Clases.Parada pParada)
        {
            throw new NotImplementedException();
        }
        public static List<Common.Clases.Parada> MostrarParadas()
        {
            List<Common.Clases.Parada> retorno = new List<Common.Clases.Parada>();
            Common.Clases.Parada parada;

            try
            {
                var conexion = new SqlConnection(CadenaDeConexion);
                conexion.Open();

                SqlCommand cmd = new SqlCommand("mostrarParadas", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        parada = new Common.Clases.Parada();
                        parada.IdParada = int.Parse(oReader["IdParada"].ToString());
                        parada.IdViaje = int.Parse(oReader["IdViaje"].ToString());
                        parada.Tipo = oReader["TipoParada"].ToString();
                        parada.Comentario = oReader["Comentario"].ToString();
                        parada.Estado = oReader["Estado"].ToString();


                        retorno.Add(parada);
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
