namespace Common
{
    public class Administrador : Usuario
    {
        public Administrador(int id) : base(id)
        {
        }

        public Administrador(int id, string nombre, string apellido, int cédula, string teléfono, string usuarioLogin, string contraseña)
            : base(id, nombre, apellido, cédula, teléfono, usuarioLogin, contraseña)
        {
        }

        public Administrador(string nombre, string apellido, int cédula, string teléfono, string usuarioLogin, string contraseña)
           : base(nombre, apellido, cédula, teléfono, usuarioLogin, contraseña)
        {
        }
    }
}
