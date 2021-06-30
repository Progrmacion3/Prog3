using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Clases
{
    public class Viaje
    {
        public short Id { get; set; }
        public Camionero Camionero { get; set; }
        public int CamioneroCI { get { return Camionero.CI; } }
        public Camion Camion { get; set; }
        public string CamionMatricula { get { return Camion.Matricula; } }
        public string TipoCarga { get; set; }
        public int Kilaje { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFinalizacion { get; set; }
        public string Estado { get; set; }
        public string Comentario { get; set; }

        //public List<Parada> Paradas { get; set; }

        //public short agregarParada(Parada pParada)
        //{
            
        //    if (pParada != null)
        //    {
        //        this.Paradas.Add(pParada);
        //        return 2;
        //    }
        //    else
        //    {
        //        return 1;
        //    }
        //}

    

        //public short quitarParada(Viaje pViaje, Parada pParada)
        //{
        //    if (pViaje != null)
        //    {
        //        if (pParada != null)
        //        {
        //            pViaje.Paradas.Remove(pParada);
        //            return 3;
        //        }
        //        else
        //        {
        //            return 2;
        //        }
        //    }
        //    else
        //    {
        //        return 1;
        //    }

        //}
    }
}
