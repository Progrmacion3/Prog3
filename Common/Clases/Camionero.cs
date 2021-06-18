using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Common.Clases
{
    class Camionero
    {
        private int _edad;
        private string _tipo_libreta;
        private DateTime _fecha_vencimiento_libreta;


        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        public string Tipo_Libreta
        {
            get { return _tipo_libreta; }
            set { _tipo_libreta = value; }
        }

        public DateTime Fecha_Vencimiento_Libreta
        {
            get { return _fecha_vencimiento_libreta; }
            set { _fecha_vencimiento_libreta = value; }
        }
    }
}
