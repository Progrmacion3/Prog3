namespace Common
{
    public class Usuario : Base
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Cédula { get; set; }

        public string Teléfono { get; set; }

        public string UsuarioLogin { get; set; }

        public string Contraseña { get; set; }

        public Usuario()
        {
        }

        public Usuario(int id) : base(id)
        {
        }

        public Usuario(int id, string nombre, string apellido) : base(id)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public Usuario(string usuario, string contraseña)
        {
            UsuarioLogin = usuario;
            Contraseña = contraseña;
        }

        public Usuario(int id, string nombre, string apellido, int cédula, string teléfono, string usuarioLogin, string contraseña) : base(id)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cédula = cédula;
            Teléfono = teléfono;
            UsuarioLogin = usuarioLogin;
            Contraseña = contraseña;
        }

        public Usuario(string nombre, string apellido, int cédula, string teléfono, string usuarioLogin, string contraseña)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cédula = cédula;
            Teléfono = teléfono;
            UsuarioLogin = usuarioLogin;
            Contraseña = contraseña;
        }

        public override string ToString()
        {
            return Nombre + " " + Apellido + ", cédula " + Cédula; 
        }
    }
}
