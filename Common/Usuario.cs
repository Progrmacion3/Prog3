namespace Common
{
    public abstract class Usuario
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Cédula { get; set; }

        public string Cargo { get; set; }

        public string Teléfono { get; set; }

        public string UsuarioLogin { get; set; }

        public string Contraseña { get; set; }

        protected Usuario()
        {
        }

        // Otros constructores: modificar también Administrador y Camionero
    }
}
