using System;

namespace Common
{
    public class Camionero : Usuario
    {
        public DateTime Nacimiento { get; set; }

        public string TipoLibreta { get; set; }

        public DateTime VencimientoLibreta { get; set; }

        public Camionero()
        {
        }

        public Camionero(int id) : base(id)
        {
        }

        public Camionero(int id, string nombre, string apellido) : base(id, nombre, apellido)
        {
        }

        public Camionero(int id, string nombre, string apellido, int cédula, string teléfono, string usuarioLogin, string contraseña, DateTime nacimiento, string tipoLibreta, DateTime vencimientoLibreta)
            : base(id, nombre, apellido, cédula, teléfono, usuarioLogin, contraseña)
        {
            Nacimiento = nacimiento;
            TipoLibreta = tipoLibreta;
            VencimientoLibreta = vencimientoLibreta;
        }

        public Camionero(string nombre, string apellido, int cédula, string teléfono, string usuarioLogin, string contraseña, DateTime nacimiento, string tipoLibreta, DateTime vencimientoLibreta)
            : base(nombre, apellido, cédula, teléfono, usuarioLogin, contraseña)
        {
            Nacimiento = nacimiento;
            TipoLibreta = tipoLibreta;
            VencimientoLibreta = vencimientoLibreta;
        }

        public int Edad()
        {
            return (int)((DateTime.Now - Nacimiento).Days / 365.2425);
        }

        public override string ToString()
        {
            return base.ToString() + ", " + Edad() + " años";
        }
    }
}
