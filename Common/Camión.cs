namespace Common
{
    public class Camión
    {
        public int Id { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Matrícula { get; set; }

        public int Año { get; set; }

        public Camión()
        {
        }

        public Camión(string marca, string modelo, string matrícula, int año)
        {
            Marca = marca;
            Modelo = modelo;
            Matrícula = matrícula;
            Año = año;
        }
    }
}
